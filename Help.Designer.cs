
namespace Reticle_OPC_Generator
{
    partial class Help
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Reticle Creator", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("General", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("OPC Generator", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Light will not pass through black areas");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Positive PR: light region is more soluable");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Negative PR: light region is less soluable");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Note: This program uses  the proximity printing method, with a distance L of 10 n" +
        "m");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Any ruler shown is accurate to a 1920x1080 display resolution");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("The wavelength (λ) used in calculations is 193 nm (λ = 193 nm) ");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("The distance between the photoresist and the lens is 10 nm");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("The System Constant K being used is 0.75");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Note: the mask has been blown up for visual appearance. Use scale 1cm:10nm for re" +
        "ference");
            this.HelpListNotes = new System.Windows.Forms.ListView();
            this.Viewer = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // HelpListNotes
            // 
            this.HelpListNotes.AllowColumnReorder = true;
            this.HelpListNotes.AllowDrop = true;
            this.HelpListNotes.BackColor = System.Drawing.SystemColors.Control;
            this.HelpListNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HelpListNotes.FullRowSelect = true;
            listViewGroup1.Header = "Reticle Creator";
            listViewGroup1.Name = "Reticle Creator";
            listViewGroup2.Header = "General";
            listViewGroup2.Name = "General";
            listViewGroup3.Header = "OPC Generator";
            listViewGroup3.Name = "OPC Generator";
            this.HelpListNotes.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.HelpListNotes.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup2;
            listViewItem5.Group = listViewGroup2;
            listViewItem6.Group = listViewGroup3;
            listViewItem7.Group = listViewGroup3;
            listViewItem8.Group = listViewGroup3;
            listViewItem9.Group = listViewGroup2;
            this.HelpListNotes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.HelpListNotes.LabelWrap = false;
            this.HelpListNotes.Location = new System.Drawing.Point(341, 0);
            this.HelpListNotes.Name = "HelpListNotes";
            this.HelpListNotes.Size = new System.Drawing.Size(10, 295);
            this.HelpListNotes.TabIndex = 4;
            this.HelpListNotes.TileSize = new System.Drawing.Size(270, 30);
            this.HelpListNotes.UseCompatibleStateImageBehavior = false;
            this.HelpListNotes.View = System.Windows.Forms.View.Tile;
            // 
            // Viewer
            // 
            this.Viewer.BackColor = System.Drawing.SystemColors.Control;
            this.Viewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Viewer.HideSelection = false;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(335, 295);
            this.Viewer.TabIndex = 5;
            this.Viewer.TileSize = new System.Drawing.Size(335, 30);
            this.Viewer.UseCompatibleStateImageBehavior = false;
            this.Viewer.View = System.Windows.Forms.View.Tile;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 295);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.HelpListNotes);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView HelpListNotes;
        private System.Windows.Forms.ListView Viewer;
    }
}