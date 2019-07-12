namespace Screenshot_Organizer
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
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extensionsBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fileNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organizeBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXE name (may be partial)";
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(12, 25);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Folder Name (full path if not in curr. directory)";
            // 
            // folderNameBox
            // 
            this.folderNameBox.Location = new System.Drawing.Point(12, 64);
            this.folderNameBox.Name = "folderNameBox";
            this.folderNameBox.Size = new System.Drawing.Size(276, 20);
            this.folderNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extensions (comma-separated) or write ALL for all extensions.";
            // 
            // extensionsBox
            // 
            this.extensionsBox.Location = new System.Drawing.Point(12, 103);
            this.extensionsBox.Name = "extensionsBox";
            this.extensionsBox.Size = new System.Drawing.Size(100, 20);
            this.extensionsBox.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 131);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(93, 131);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(103, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove Selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameCol,
            this.folderCol,
            this.extensionsCol});
            this.listView1.Location = new System.Drawing.Point(12, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 147);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // fileNameCol
            // 
            this.fileNameCol.Text = "File Name";
            this.fileNameCol.Width = 111;
            // 
            // folderCol
            // 
            this.folderCol.Text = "Folder";
            this.folderCol.Width = 206;
            // 
            // extensionsCol
            // 
            this.extensionsCol.Text = "Extensions";
            this.extensionsCol.Width = 123;
            // 
            // organizeBtn
            // 
            this.organizeBtn.Location = new System.Drawing.Point(381, 131);
            this.organizeBtn.Name = "organizeBtn";
            this.organizeBtn.Size = new System.Drawing.Size(75, 23);
            this.organizeBtn.TabIndex = 8;
            this.organizeBtn.Text = "Organize It!";
            this.organizeBtn.UseVisualStyleBackColor = true;
            this.organizeBtn.Click += new System.EventHandler(this.organizeBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(294, 64);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(66, 20);
            this.browseBtn.TabIndex = 10;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 319);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.organizeBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.extensionsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.folderNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Screenshot Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox extensionsBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button organizeBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.ColumnHeader fileNameCol;
        private System.Windows.Forms.ColumnHeader folderCol;
        private System.Windows.Forms.ColumnHeader extensionsCol;
    }
}

