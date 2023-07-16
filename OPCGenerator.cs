using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging;
using AForge.Imaging.Filters;

public class OPCGenerator
{
    public const double ScalePixelToNM = 0.01;
    public const int DistLenstoWafer = 20; // nanometer
    public const int DistSourceToLens = 10; // milimeters
    public const double Wavelength = 193; // nanometer
    public const double N = 1.5;  //refraction index through glass. credit:https://micro.magnet.fsu.edu/primer/java/speedoflight/index.html#:~:text=Light%20travels%20at%20approximately%20300%2C000,(refractive%20index%20of%201.5). 
    public const double K = 0.75; // system constant
    public static double Resolution = K / (Wavelength / NA);
    public const int Focallength = 10; // milimeters
    public const double halfAngle = (1.107148718 * (Math.PI / 180)); // half angle in radians
    public static double NA = N * Math.Sin(halfAngle); // numerical aperature
    public const double CornerExpansionMultiplier = 1.2;


    private Bitmap image;
    private List<Bitmap> overlays;
    private List<int> shapeAreas;
    private List<double> neededShapeCorrections;

    public OPCGenerator(Bitmap image)
    {
        this.image = image;
        overlays = new List<Bitmap>();
    }
    public void Run()
    {
        shapeAreas = FindShapeAreas();

        neededShapeCorrections = CalculateLightDiff();
    }

    public List<int> FindShapeAreas()
    {
        int width = image.Width;
        int height = image.Height;
        bool[,] visited = new bool[width, height];
        List<int> shapeAreas = new List<int>();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (image.GetPixel(x, y).GetBrightness() < 0.5 && !visited[x, y])
                {
                    int area = FloodFill(x, y, visited);
                    shapeAreas.Add(area);
                }
            }
        }

        return shapeAreas;
    }

    private int FloodFill(int startX, int startY, bool[,] visited)
    {
        int width = image.Width;
        int height = image.Height;
        int area = 0;

        Stack<(int x, int y)> stack = new Stack<(int x, int y)>();
        stack.Push((startX, startY));

        while (stack.Count > 0)
        {
            (int x, int y) = stack.Pop();

            if (x < 0 || x >= width || y < 0 || y >= height)
            {
                continue;
            }

            if (visited[x, y] || image.GetPixel(x, y).GetBrightness() >= 0.5)
            {
                continue;
            }

            visited[x, y] = true;
            area++;

            stack.Push((x + 1, y));
            stack.Push((x - 1, y));
            stack.Push((x, y + 1));
            stack.Push((x, y - 1));
        }

        return area;
    }

    public void ReverseColors(Bitmap image)
    {
        int width = image.Width;
        int height = image.Height;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color pixelColor = image.GetPixel(x, y);
                Color newColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                image.SetPixel(x, y, newColor);
            }
        }
    }

    public List<double> CalculateLightDiff()
    {
        // y = (wavelength * L)/a   L = distLensToWafer    a = area

        List<double> ShapeCorrections = new List<double>();

        foreach (int area in shapeAreas)
        {
            double y = (Wavelength * DistLenstoWafer) / (area * ScalePixelToNM);
            ShapeCorrections.Add(y);
        }

        return ShapeCorrections;
    }

    public void RecolorImageNC(int resist)
    {
        Bitmap adjustedImage = new Bitmap(image);

        if (resist == 0)
        {
            ReverseColors(adjustedImage);
        }

        // Create a blob counter and configure it
        BlobCounter blobCounter = new BlobCounter();
        blobCounter.FilterBlobs = true;

        // Process the image and extract the objects
        blobCounter.ProcessImage(adjustedImage);
        Blob[] blobs = blobCounter.GetObjectsInformation();

        // Create a new bitmap to store the modified image
        Bitmap modifiedBitmap = new Bitmap(adjustedImage.Width, adjustedImage.Height);

        // Copy the original bitmap to the modified bitmap
        using (Graphics graphics = Graphics.FromImage(modifiedBitmap))
        {
            graphics.DrawImage(adjustedImage, 0, 0);
        }

        // Set the color for the perimeter pixels
        Color perimeterColor = Color.Red; // Change this to the desired perimeter color

        int ci = 0;
        // Process each object found
        foreach (Blob blob in blobs)
        {
            // Get the region of interest (ROI) for the object
            Rectangle objectRect = blob.Rectangle;

            // Get the top-left and bottom-right points of the object
            Point topLeft = objectRect.Location;
            Point bottomRight = new Point(objectRect.Right, objectRect.Bottom);

            // Change the color of the perimeter pixels
            ChangePerimeterColor(modifiedBitmap, topLeft, bottomRight, perimeterColor,(int)(neededShapeCorrections[ci] / CornerExpansionMultiplier));
            ci++;
        }

        if (resist == 0)
        {
            ReverseColors(modifiedBitmap);
        }

        image = modifiedBitmap;
    }
    private void ChangePerimeterColor(Bitmap image, Point topLeft, Point bottomRight, Color color, int depth)
    {
        int perimeterDepth = Math.Min(depth, Math.Min(topLeft.X, topLeft.Y));

        // Change the color of the top and bottom rows
        for (int x = topLeft.X; x <= bottomRight.X; x++)
        {
            for (int i = 0; i < perimeterDepth; i++)
            {
                image.SetPixel(x, topLeft.Y + i, color);           // Top row
                image.SetPixel(x, bottomRight.Y - i, color);       // Bottom row
            }
        }

        // Change the color of the left and right columns
        for (int y = topLeft.Y; y <= bottomRight.Y; y++)
        {
            for (int i = 0; i < perimeterDepth; i++)
            {
                image.SetPixel(topLeft.X + i, y, color);           // Left column
                image.SetPixel(bottomRight.X - i, y, color);       // Right column
            }
        }
    }


    public Bitmap RecolorImage(int resist)
    {
        Bitmap adjustedImage = new Bitmap(image);

        if (resist == 0)
        {
            ReverseColors(adjustedImage);
        }

        // Create a blob counter and configure it
        BlobCounter blobCounter = new BlobCounter();
        blobCounter.FilterBlobs = true;

        // Process the image and extract the objects
        blobCounter.ProcessImage(adjustedImage);
        Blob[] blobs = blobCounter.GetObjectsInformation();

        // Create a new bitmap to store the modified image
        Bitmap modifiedBitmap = new Bitmap(adjustedImage.Width, adjustedImage.Height);

        // Copy the original bitmap to the modified bitmap
        using (Graphics graphics = Graphics.FromImage(modifiedBitmap))
        {
            graphics.DrawImage(adjustedImage, 0, 0);
        }

        // Set the color for the corners
        Color cornerColor = Color.Red; // Change this to the desired corner color

        int ci = 0;
        // Process each object found
        foreach (Blob blob in blobs)
        {
            // Get the region of interest (ROI) for the object
            Rectangle objectRect = blob.Rectangle;

            // Calculate the corner expansion amount
            
            int cornerExpansion = (int)(neededShapeCorrections[ci] * CornerExpansionMultiplier); // Adjust this value to control the size of the corner expansion

            // Calculate the corners' positions
            Point topLeftCorner = new Point(objectRect.Left, objectRect.Top);
            Point topRightCorner = new Point(objectRect.Right, objectRect.Top);
            Point bottomLeftCorner = new Point(objectRect.Left, objectRect.Bottom);
            Point bottomRightCorner = new Point(objectRect.Right, objectRect.Bottom);

            // Change the color of the corners
            ChangePixelColor(modifiedBitmap, topLeftCorner, cornerColor, cornerExpansion);
            ChangePixelColor(modifiedBitmap, topRightCorner, cornerColor, cornerExpansion);
            ChangePixelColor(modifiedBitmap, bottomLeftCorner, cornerColor, cornerExpansion);
            ChangePixelColor(modifiedBitmap, bottomRightCorner, cornerColor, cornerExpansion);
        }

        if (resist == 0)
        {
            ReverseColors(modifiedBitmap);
        }
        return modifiedBitmap;
    }

    private void ChangePixelColor(Bitmap image, Point position, Color color, int distance)
    {
        for (int x = position.X - distance; x <= position.X + distance; x++)
        {
            for (int y = position.Y - distance; y <= position.Y + distance; y++)
            {
                if (x >= 0 && x < image.Width && y >= 0 && y < image.Height)
                {
                    image.SetPixel(x, y, color);
                }
            }
        }
    }
}

