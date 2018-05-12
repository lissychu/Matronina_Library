namespace Matronina_Library
{
    partial class BookListForm
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
            this.ButtonBookAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBookAdd
            // 
            this.ButtonBookAdd.Location = new System.Drawing.Point(15, 412);
            this.ButtonBookAdd.Name = "ButtonBookAdd";
            this.ButtonBookAdd.Size = new System.Drawing.Size(763, 28);
            this.ButtonBookAdd.TabIndex = 0;
            this.ButtonBookAdd.Text = "Добавить новую книгу";
            this.ButtonBookAdd.UseVisualStyleBackColor = true;
            this.ButtonBookAdd.Click += new System.EventHandler(this.ButtonBookAdd_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBookAdd);
            this.Name = "BookListForm";
            this.Text = "Список книг";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBookAdd;
    }
}