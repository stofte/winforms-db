namespace DvdRental.WinForm
{
    partial class EditDvdWin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DvdImageBox = new System.Windows.Forms.PictureBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.yearEdit = new System.Windows.Forms.TextBox();
            this.titleEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvdImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DvdImageBox);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.genreBox);
            this.groupBox1.Controls.Add(this.yearEdit);
            this.groupBox1.Controls.Add(this.titleEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // DvdImageBox
            // 
            this.DvdImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DvdImageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DvdImageBox.Location = new System.Drawing.Point(110, 185);
            this.DvdImageBox.Name = "DvdImageBox";
            this.DvdImageBox.Size = new System.Drawing.Size(155, 125);
            this.DvdImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DvdImageBox.TabIndex = 8;
            this.DvdImageBox.TabStop = false;
            this.DvdImageBox.Click += new System.EventHandler(this.DvdImageBox_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(110, 102);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(331, 77);
            this.descriptionBox.TabIndex = 7;
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(110, 77);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(331, 21);
            this.genreBox.TabIndex = 6;
            // 
            // yearEdit
            // 
            this.yearEdit.Location = new System.Drawing.Point(110, 54);
            this.yearEdit.Name = "yearEdit";
            this.yearEdit.Size = new System.Drawing.Size(67, 20);
            this.yearEdit.TabIndex = 5;
            // 
            // titleEdit
            // 
            this.titleEdit.Location = new System.Drawing.Point(110, 29);
            this.titleEdit.Name = "titleEdit";
            this.titleEdit.Size = new System.Drawing.Size(331, 20);
            this.titleEdit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // OpenDialog1
            // 
            this.OpenDialog1.Filter = "PNG Image|*.png";
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(388, 358);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 10;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(307, 358);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // EditDvdWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 389);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditDvdWin";
            this.Text = "EditDvdWin";
            this.Load += new System.EventHandler(this.EditDvdWin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvdImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox DvdImageBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.TextBox yearEdit;
        private System.Windows.Forms.TextBox titleEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenDialog1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}