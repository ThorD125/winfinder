﻿namespace explorerrrrrappp
{
    partial class Form1
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
            this.OpenFolder = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.TextBox();
            this.Folder = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // OpenFolder
            // 
            this.OpenFolder.AccessibleName = "";
            this.OpenFolder.Location = new System.Drawing.Point(689, 12);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(99, 34);
            this.OpenFolder.TabIndex = 0;
            this.OpenFolder.Text = "Open folder";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(13, 20);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(670, 20);
            this.Location.TabIndex = 1;
            // 
            // Folder
            // 
            this.Folder.Location = new System.Drawing.Point(80, 115);
            this.Folder.MinimumSize = new System.Drawing.Size(20, 20);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(515, 244);
            this.Folder.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.OpenFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.WebBrowser Folder;
    }
}
