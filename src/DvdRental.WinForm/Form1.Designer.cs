namespace DvdRental.WinForm
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
            this.titleListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleListBox
            // 
            this.titleListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleListBox.FormattingEnabled = true;
            this.titleListBox.Location = new System.Drawing.Point(0, 71);
            this.titleListBox.Name = "titleListBox";
            this.titleListBox.Size = new System.Drawing.Size(922, 342);
            this.titleListBox.TabIndex = 1;
            this.titleListBox.DoubleClick += new System.EventHandler(this.titleListBox_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDVDToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // addDVDToolStripMenuItem
            // 
            this.addDVDToolStripMenuItem.Name = "addDVDToolStripMenuItem";
            this.addDVDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDVDToolStripMenuItem.Text = "Add DVD";
            this.addDVDToolStripMenuItem.Click += new System.EventHandler(this.addDVDToolStripMenuItem_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(12, 45);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(128, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "button1";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 413);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.titleListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox titleListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDVDToolStripMenuItem;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;


    }
}

