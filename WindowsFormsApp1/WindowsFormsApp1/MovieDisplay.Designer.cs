﻿namespace WindowsFormsApp1
{
    partial class MovieDisplay
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
            this.TV = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.Release = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.Visit = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TV.Location = new System.Drawing.Point(758, 12);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(126, 43);
            this.TV.TabIndex = 0;
            this.TV.Text = "Tv Shows";
            this.TV.UseVisualStyleBackColor = true;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 18);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(90, 29);
            this.Header.TabIndex = 1;
            this.Header.Text = "Movies";
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(109, 23);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(42, 23);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Prev";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(158, 23);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(41, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Cover
            // 
            this.Cover.Location = new System.Drawing.Point(17, 62);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(237, 376);
            this.Cover.TabIndex = 4;
            this.Cover.TabStop = false;
            // 
            // Release
            // 
            this.Release.AutoSize = true;
            this.Release.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Release.Location = new System.Drawing.Point(270, 121);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(80, 16);
            this.Release.TabIndex = 6;
            this.Release.Text = "Aug 17,2018";
            // 
            // Summary
            // 
            this.Summary.AllowDrop = true;
            this.Summary.Location = new System.Drawing.Point(270, 141);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(614, 265);
            this.Summary.TabIndex = 7;
            this.Summary.Text = "Summary";
            this.Summary.UseCompatibleTextRendering = true;
            // 
            // Visit
            // 
            this.Visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visit.Location = new System.Drawing.Point(270, 409);
            this.Visit.Name = "Visit";
            this.Visit.Size = new System.Drawing.Size(75, 29);
            this.Visit.TabIndex = 8;
            this.Visit.Text = "Visit";
            this.Visit.UseVisualStyleBackColor = true;
            this.Visit.Click += new System.EventHandler(this.Visit_Click);
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download.Location = new System.Drawing.Point(351, 409);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(118, 29);
            this.Download.TabIndex = 9;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(273, 62);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(152, 55);
            this.Title.TabIndex = 10;
            this.Title.Text = "Movie";
            // 
            // MovieDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Visit);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.Release);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.TV);
            this.Name = "MovieDisplay";
            this.Text = "MovieDisplay";
            this.Load += new System.EventHandler(this.MovieDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TV;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.Label Release;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Button Visit;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label Title;
    }
}