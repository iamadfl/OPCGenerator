using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reticle_OPC_Generator
{
    public partial class Reticle_OPC_Generator : Form
    {
        private Tuple<Bitmap, string> file;

        public Reticle_OPC_Generator()
        {
            file = Tuple.Create<Bitmap, string>(null, "");
            InitializeComponent();
        }

        private void change_Image()
        {
            if (file != null) 
            { 
                desired_result_pictureBox.Image = file.Item1;
                start_button.Hide();
                Start_Label.Hide();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_button.Show();
            Start_Label.Show();
            desired_result_pictureBox.Image = null;
            file = Tuple.Create<Bitmap, string>(null, "");
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            file = CommonFunctions.OpenImage();
            change_Image();
        }

        private void examplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = CommonFunctions.OpenImage();
            change_Image();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = CommonFunctions.OpenImage();
            change_Image();
        }

        private void Generate_Recticle_button_Click(object sender, EventArgs e)
        {
            Reticle_Generator RG;
            try
            {
                if (file.Item2 != null)
                {
                    RG = new Reticle_Generator(file);
                    RG.ShowDialog();
                }
                else
                {
                    RG = new Reticle_Generator();
                    RG.ShowDialog();
                }
            }
            catch 
            {
                RG = new Reticle_Generator();
                RG.ShowDialog();
            }
  
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hp = new Help(1);
            hp.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (desired_result_pictureBox.Image != null)
                CommonFunctions.saveImage(desired_result_pictureBox.Image);
        }
    }
}
