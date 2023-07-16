using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reticle_OPC_Generator
{
    public partial class Reticle_Generator : Form
    {
        private Tuple<Bitmap, string> file;
        private bool supressRadioButtons;

        public Reticle_Generator()
        {
            file = Tuple.Create<Bitmap, string>(null, "");
            InitializeComponent();
            Positive_resist_radio.Checked = false;
            Negative_resist_radio.Checked = false;
            maskStartRB.Checked = true;
            maskStartRB.Hide();
            Reticle_pictureBox.Image = null;
            PR_Select_Label.Show();
            supressRadioButtons = true;

        }
        public Reticle_Generator(Tuple<Bitmap,string> file)
        {
            this.file = file;
            InitializeComponent();
            Positive_resist_radio.Checked = false;
            Negative_resist_radio.Checked = false;
            maskStartRB.Checked = true;
            maskStartRB.Hide();
            Reticle_pictureBox.Image = this.file.Item1;
            PR_Select_Label.Hide();

        }

        private void OpenedMask()
        {
            char resist = file.Item2[file.Item2.Length - 5];
            switch(resist)
            {
                case 'P':
                {
                    Positive_resist_radio.Checked = true;
                    break;
                }

                case 'N':
                {
                    Negative_resist_radio.Checked = true;
                    break;
                }

                default:
                    break;
            }
            supressRadioButtons = false;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Positive_resist_radio.Checked = false;
            Negative_resist_radio.Checked = false;
            Reticle_pictureBox.Image = null;
            PR_Select_Label.Show();
            supressRadioButtons = true;
        }

        private void Positive_resist_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (!supressRadioButtons)
                if (Positive_resist_radio.Checked == true)
                {

                    if (file.Item2[file.Item2.Length - 5] == 'N') 
                    { 
                        Reticle_pictureBox.Image = ReticleCreatorFunctions.invertImage((Bitmap)Reticle_pictureBox.Image); 
                    }

                    else
                    {
                        Reticle_pictureBox.Image = ReticleCreatorFunctions.removeColor(file.Item1);
                        PR_Select_Label.Hide();
                    }
                }
        }

        private void Negative_Resist_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (!supressRadioButtons)
                if (Negative_resist_radio.Checked == true)
                {
                    Bitmap image = ReticleCreatorFunctions.removeColor(file.Item1);
                    Reticle_pictureBox.Image = ReticleCreatorFunctions.invertImage(image);
                    PR_Select_Label.Hide();
                }
        }
        
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please label a saved mask with the PR type: P or N");
            CommonFunctions.saveImage(Reticle_pictureBox.Image);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = CommonFunctions.OpenImage();
            PR_Select_Label.Hide();
            try
            {
                Reticle_pictureBox.Image = file.Item1;
                OpenedMask();
                rulerPictureBox.Show();
            }
            catch{ }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hp = new Help(1);
            hp.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help hp = new Help(0);
            hp.ShowDialog();
        }

        private void ApplyOPC_button_Click(object sender, EventArgs e)
        {
            OPCGenerator generator = new OPCGenerator((Bitmap)Reticle_pictureBox.Image);

            if (Positive_resist_radio.Checked == true)
            {
                try
                {
                    generator.Run();
                    generator.RecolorImageNC(0);
                    Bitmap OPCapplied = generator.RecolorImage(0);
                    Reticle_pictureBox.Image = OPCapplied;
                }
                catch { }
            }
            if (Negative_resist_radio.Checked == true)
            {
                try
                {
                    generator.ReverseColors((Bitmap)Reticle_pictureBox.Image);
                    generator.Run();
                    generator.ReverseColors((Bitmap)Reticle_pictureBox.Image);
                    generator.RecolorImageNC(1);
                    Bitmap OPCapplied = generator.RecolorImage(1);
                    Reticle_pictureBox.Image = OPCapplied;
                }
                catch { }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help hp = new Help(2);
            hp.ShowDialog();
        }
    }
}
