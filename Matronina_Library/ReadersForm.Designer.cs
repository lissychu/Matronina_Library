﻿namespace Matronina_Library
{
    partial class ReadersForm
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
            this.ButtonReaderAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonReaderAdd
            // 
            this.ButtonReaderAdd.Location = new System.Drawing.Point(32, 417);
            this.ButtonReaderAdd.Name = "ButtonReaderAdd";
            this.ButtonReaderAdd.Size = new System.Drawing.Size(746, 23);
            this.ButtonReaderAdd.TabIndex = 0;
            this.ButtonReaderAdd.Text = "Добавить читателя";
            this.ButtonReaderAdd.UseVisualStyleBackColor = true;
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReaderAdd);
            this.Name = "ReadersForm";
            this.Text = "Наши читатели";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonReaderAdd;
    }
}