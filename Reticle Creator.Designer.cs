
namespace Reticle_OPC_Generator
{
    partial class Reticle_Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reticle_Generator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_Label = new System.Windows.Forms.Label();
            this.Reticle_pictureBox = new System.Windows.Forms.PictureBox();
            this.Positive_resist_radio = new System.Windows.Forms.RadioButton();
            this.Negative_resist_radio = new System.Windows.Forms.RadioButton();
            this.PR_Select_Label = new System.Windows.Forms.Label();
            this.ApplyOPC_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskStartRB = new System.Windows.Forms.RadioButton();
            this.rulerPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reticle_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Start_Label
            // 
            this.Start_Label.AutoSize = true;
            this.Start_Label.Enabled = false;
            this.Start_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Label.Location = new System.Drawing.Point(71, 193);
            this.Start_Label.Name = "Start_Label";
            this.Start_Label.Size = new System.Drawing.Size(0, 25);
            this.Start_Label.TabIndex = 8;
            // 
            // Reticle_pictureBox
            // 
            this.Reticle_pictureBox.Enabled = false;
            this.Reticle_pictureBox.Location = new System.Drawing.Point(12, 27);
            this.Reticle_pictureBox.Name = "Reticle_pictureBox";
            this.Reticle_pictureBox.Size = new System.Drawing.Size(467, 452);
            this.Reticle_pictureBox.TabIndex = 9;
            this.Reticle_pictureBox.TabStop = false;
            // 
            // Positive_resist_radio
            // 
            this.Positive_resist_radio.AutoSize = true;
            this.Positive_resist_radio.Location = new System.Drawing.Point(43, 509);
            this.Positive_resist_radio.Name = "Positive_resist_radio";
            this.Positive_resist_radio.Size = new System.Drawing.Size(94, 17);
            this.Positive_resist_radio.TabIndex = 10;
            this.Positive_resist_radio.TabStop = true;
            this.Positive_resist_radio.Text = "Positive Resist";
            this.Positive_resist_radio.UseVisualStyleBackColor = true;
            this.Positive_resist_radio.CheckedChanged += new System.EventHandler(this.Positive_resist_radio_CheckedChanged);
            // 
            // Negative_resist_radio
            // 
            this.Negative_resist_radio.AutoSize = true;
            this.Negative_resist_radio.Location = new System.Drawing.Point(43, 532);
            this.Negative_resist_radio.Name = "Negative_resist_radio";
            this.Negative_resist_radio.Size = new System.Drawing.Size(100, 17);
            this.Negative_resist_radio.TabIndex = 11;
            this.Negative_resist_radio.TabStop = true;
            this.Negative_resist_radio.Text = "Negative Resist";
            this.Negative_resist_radio.UseVisualStyleBackColor = true;
            this.Negative_resist_radio.CheckedChanged += new System.EventHandler(this.Negative_Resist_radio_CheckedChanged);
            // 
            // PR_Select_Label
            // 
            this.PR_Select_Label.AutoSize = true;
            this.PR_Select_Label.Enabled = false;
            this.PR_Select_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR_Select_Label.Location = new System.Drawing.Point(122, 235);
            this.PR_Select_Label.Name = "PR_Select_Label";
            this.PR_Select_Label.Size = new System.Drawing.Size(172, 25);
            this.PR_Select_Label.TabIndex = 12;
            this.PR_Select_Label.Text = "Select a PR type";
            // 
            // ApplyOPC_button
            // 
            this.ApplyOPC_button.Location = new System.Drawing.Point(339, 509);
            this.ApplyOPC_button.Name = "ApplyOPC_button";
            this.ApplyOPC_button.Size = new System.Drawing.Size(90, 23);
            this.ApplyOPC_button.TabIndex = 16;
            this.ApplyOPC_button.Text = "Apply OPC";
            this.ApplyOPC_button.UseVisualStyleBackColor = true;
            this.ApplyOPC_button.Click += new System.EventHandler(this.ApplyOPC_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reticle_OPC_Generator.Properties.Resources.Questionmark_circle_to_help_page;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // maskStartRB
            // 
            this.maskStartRB.AutoSize = true;
            this.maskStartRB.Location = new System.Drawing.Point(43, 555);
            this.maskStartRB.Name = "maskStartRB";
            this.maskStartRB.Size = new System.Drawing.Size(14, 13);
            this.maskStartRB.TabIndex = 18;
            this.maskStartRB.TabStop = true;
            this.maskStartRB.UseVisualStyleBackColor = true;
            // 
            // rulerPictureBox
            // 
            this.rulerPictureBox.Enabled = false;
            this.rulerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rulerPictureBox.Image")));
            this.rulerPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("rulerPictureBox.InitialImage")));
            this.rulerPictureBox.Location = new System.Drawing.Point(476, 27);
            this.rulerPictureBox.Name = "rulerPictureBox";
            this.rulerPictureBox.Size = new System.Drawing.Size(100, 452);
            this.rulerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rulerPictureBox.TabIndex = 19;
            this.rulerPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reticle_OPC_Generator.Properties.Resources.Questionmark_circle_to_help_page;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(435, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Reticle_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 636);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rulerPictureBox);
            this.Controls.Add(this.maskStartRB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApplyOPC_button);
            this.Controls.Add(this.PR_Select_Label);
            this.Controls.Add(this.Negative_resist_radio);
            this.Controls.Add(this.Positive_resist_radio);
            this.Controls.Add(this.Start_Label);
            this.Controls.Add(this.Reticle_pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Reticle_Generator";
            this.Text = "Reticle Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reticle_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label Start_Label;
        private System.Windows.Forms.PictureBox Reticle_pictureBox;
        private System.Windows.Forms.RadioButton Positive_resist_radio;
        private System.Windows.Forms.RadioButton Negative_resist_radio;
        private System.Windows.Forms.Label PR_Select_Label;
        private System.Windows.Forms.Button ApplyOPC_button;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton maskStartRB;
        private System.Windows.Forms.PictureBox rulerPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}