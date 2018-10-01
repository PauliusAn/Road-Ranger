﻿using System;

namespace Road_rangerVS
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
            this.label1 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.browseImage = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.callPythonCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Road Ranger";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(763, 196);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(208, 23);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.UploadButtonClick);
            // 
            // browseImage
            // 
            this.browseImage.Location = new System.Drawing.Point(763, 133);
            this.browseImage.Name = "browseImage";
            this.browseImage.Size = new System.Drawing.Size(208, 23);
            this.browseImage.TabIndex = 2;
            this.browseImage.Text = "Browse Image";
            this.browseImage.UseVisualStyleBackColor = true;
            this.browseImage.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(760, 168);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(16, 13);
            this.filePath.TabIndex = 3;
            this.filePath.Text = "...";
            this.filePath.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(50, 133);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(624, 498);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Camera On/Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CameraClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 637);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(624, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SelectCamera);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Capture VIew";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CaptureCLick);
            // 
            // callPythonCode
            // 
            this.callPythonCode.Location = new System.Drawing.Point(763, 336);
            this.callPythonCode.Name = "callPythonCode";
            this.callPythonCode.Size = new System.Drawing.Size(208, 23);
            this.callPythonCode.TabIndex = 9;
            this.callPythonCode.Text = "Call Python Code";
            this.callPythonCode.UseVisualStyleBackColor = true;
            this.callPythonCode.Click += new System.EventHandler(this.callPythonCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 725);
            this.Controls.Add(this.callPythonCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.browseImage);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoading);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button browseImage;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button callPythonCode;
    }
}

