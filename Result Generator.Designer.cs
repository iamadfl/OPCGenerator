
namespace Reticle_OPC_Generator
{
    partial class Reticle_OPC_Generator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start_button = new System.Windows.Forms.Button();
            this.Start_Label = new System.Windows.Forms.Label();
            this.desired_result_pictureBox = new System.Windows.Forms.PictureBox();
            this.Generate_Recticle_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desired_result_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examplesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.examplesToolStripMenuItem.Text = "Examples";
            this.examplesToolStripMenuItem.Click += new System.EventHandler(this.examplesToolStripMenuItem_Click);
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
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(172, 221);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 22);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Click here";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Start_Label
            // 
            this.Start_Label.AutoSize = true;
            this.Start_Label.Enabled = false;
            this.Start_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Label.Location = new System.Drawing.Point(71, 193);
            this.Start_Label.Name = "Start_Label";
            this.Start_Label.Size = new System.Drawing.Size(309, 25);
            this.Start_Label.TabIndex = 3;
            this.Start_Label.Text = "Upload a desired result to Start";
            // 
            // desired_result_pictureBox
            // 
            this.desired_result_pictureBox.Enabled = false;
            this.desired_result_pictureBox.Location = new System.Drawing.Point(12, 27);
            this.desired_result_pictureBox.Name = "desired_result_pictureBox";
            this.desired_result_pictureBox.Size = new System.Drawing.Size(455, 452);
            this.desired_result_pictureBox.TabIndex = 6;
            this.desired_result_pictureBox.TabStop = false;
            // 
            // Generate_Recticle_button
            // 
            this.Generate_Recticle_button.Location = new System.Drawing.Point(145, 502);
            this.Generate_Recticle_button.Name = "Generate_Recticle_button";
            this.Generate_Recticle_button.Size = new System.Drawing.Size(164, 23);
            this.Generate_Recticle_button.TabIndex = 7;
            this.Generate_Recticle_button.Text = "Generate Reticle(Mask)";
            this.Generate_Recticle_button.UseVisualStyleBackColor = true;
            this.Generate_Recticle_button.Click += new System.EventHandler(this.Generate_Recticle_button_Click);
            // 
            // Reticle_OPC_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 573);
            this.Controls.Add(this.Generate_Recticle_button);
            this.Controls.Add(this.Start_Label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.desired_result_pictureBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reticle_OPC_Generator";
            this.Text = "Recticle OPC Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desired_result_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label Start_Label;
        private System.Windows.Forms.PictureBox desired_result_pictureBox;
        private System.Windows.Forms.Button Generate_Recticle_button;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

