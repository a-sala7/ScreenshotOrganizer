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
            this.components = new System.ComponentModel.Container();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.dstFolderBox = new System.Windows.Forms.TextBox();
            this.extensionsBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fileNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.srcFolderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dstFolderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organizeBtn = new System.Windows.Forms.Button();
            this.debugBox = new System.Windows.Forms.Label();
            this.srcFolderBox = new System.Windows.Forms.TextBox();
            this.srcBrowseBtn = new System.Windows.Forms.Button();
            this.dstBrowseBtn = new System.Windows.Forms.Button();
            this.sourceFolderRadioCurr = new System.Windows.Forms.RadioButton();
            this.sourceFolderRadioPath = new System.Windows.Forms.RadioButton();
            this.destFolderRadioCurr = new System.Windows.Forms.RadioButton();
            this.destFolderRadioPath = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.allExtCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(6, 19);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(128, 20);
            this.fileNameBox.TabIndex = 1;
            // 
            // dstFolderBox
            // 
            this.dstFolderBox.Location = new System.Drawing.Point(6, 42);
            this.dstFolderBox.Name = "dstFolderBox";
            this.dstFolderBox.Size = new System.Drawing.Size(248, 20);
            this.dstFolderBox.TabIndex = 10;
            // 
            // extensionsBox
            // 
            this.extensionsBox.Location = new System.Drawing.Point(6, 19);
            this.extensionsBox.Name = "extensionsBox";
            this.extensionsBox.Size = new System.Drawing.Size(128, 20);
            this.extensionsBox.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 223);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(93, 223);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(103, 23);
            this.removeBtn.TabIndex = 13;
            this.removeBtn.Text = "Remove Selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameCol,
            this.extensionsCol,
            this.srcFolderCol,
            this.dstFolderCol});
            this.listView1.Location = new System.Drawing.Point(12, 252);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 225);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // fileNameCol
            // 
            this.fileNameCol.Text = "File Name";
            this.fileNameCol.Width = 79;
            // 
            // extensionsCol
            // 
            this.extensionsCol.Text = "Extensions";
            this.extensionsCol.Width = 70;
            // 
            // srcFolderCol
            // 
            this.srcFolderCol.Text = "From";
            this.srcFolderCol.Width = 178;
            // 
            // dstFolderCol
            // 
            this.dstFolderCol.Text = "To";
            this.dstFolderCol.Width = 226;
            // 
            // organizeBtn
            // 
            this.organizeBtn.Location = new System.Drawing.Point(497, 223);
            this.organizeBtn.Name = "organizeBtn";
            this.organizeBtn.Size = new System.Drawing.Size(75, 23);
            this.organizeBtn.TabIndex = 14;
            this.organizeBtn.Text = "Organize It!";
            this.organizeBtn.UseVisualStyleBackColor = true;
            this.organizeBtn.Click += new System.EventHandler(this.organizeBtn_Click);
            // 
            // debugBox
            // 
            this.debugBox.AutoSize = true;
            this.debugBox.Location = new System.Drawing.Point(9, 480);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(0, 13);
            this.debugBox.TabIndex = 11;
            // 
            // srcFolderBox
            // 
            this.srcFolderBox.Enabled = false;
            this.srcFolderBox.Location = new System.Drawing.Point(6, 42);
            this.srcFolderBox.Name = "srcFolderBox";
            this.srcFolderBox.Size = new System.Drawing.Size(248, 20);
            this.srcFolderBox.TabIndex = 6;
            // 
            // srcBrowseBtn
            // 
            this.srcBrowseBtn.Enabled = false;
            this.srcBrowseBtn.Location = new System.Drawing.Point(259, 41);
            this.srcBrowseBtn.Name = "srcBrowseBtn";
            this.srcBrowseBtn.Size = new System.Drawing.Size(69, 20);
            this.srcBrowseBtn.TabIndex = 7;
            this.srcBrowseBtn.Text = "Browse";
            this.srcBrowseBtn.UseVisualStyleBackColor = true;
            this.srcBrowseBtn.Click += new System.EventHandler(this.srcBrowseBtn_Click);
            // 
            // dstBrowseBtn
            // 
            this.dstBrowseBtn.Enabled = false;
            this.dstBrowseBtn.Location = new System.Drawing.Point(260, 42);
            this.dstBrowseBtn.Name = "dstBrowseBtn";
            this.dstBrowseBtn.Size = new System.Drawing.Size(69, 20);
            this.dstBrowseBtn.TabIndex = 11;
            this.dstBrowseBtn.Text = "Browse";
            this.dstBrowseBtn.UseVisualStyleBackColor = true;
            this.dstBrowseBtn.Click += new System.EventHandler(this.dstBrowseBtn_Click);
            // 
            // sourceFolderRadioCurr
            // 
            this.sourceFolderRadioCurr.AutoSize = true;
            this.sourceFolderRadioCurr.Checked = true;
            this.sourceFolderRadioCurr.Location = new System.Drawing.Point(6, 19);
            this.sourceFolderRadioCurr.Name = "sourceFolderRadioCurr";
            this.sourceFolderRadioCurr.Size = new System.Drawing.Size(104, 17);
            this.sourceFolderRadioCurr.TabIndex = 4;
            this.sourceFolderRadioCurr.TabStop = true;
            this.sourceFolderRadioCurr.Text = "Current Directory";
            this.sourceFolderRadioCurr.UseVisualStyleBackColor = true;
            this.sourceFolderRadioCurr.CheckedChanged += new System.EventHandler(this.sourceFolderRadioCurr_CheckedChanged);
            // 
            // sourceFolderRadioPath
            // 
            this.sourceFolderRadioPath.AutoSize = true;
            this.sourceFolderRadioPath.Location = new System.Drawing.Point(160, 19);
            this.sourceFolderRadioPath.Name = "sourceFolderRadioPath";
            this.sourceFolderRadioPath.Size = new System.Drawing.Size(94, 17);
            this.sourceFolderRadioPath.TabIndex = 5;
            this.sourceFolderRadioPath.TabStop = true;
            this.sourceFolderRadioPath.Text = "Specified Path";
            this.sourceFolderRadioPath.UseVisualStyleBackColor = true;
            // 
            // destFolderRadioCurr
            // 
            this.destFolderRadioCurr.AutoSize = true;
            this.destFolderRadioCurr.Checked = true;
            this.destFolderRadioCurr.Location = new System.Drawing.Point(6, 19);
            this.destFolderRadioCurr.Name = "destFolderRadioCurr";
            this.destFolderRadioCurr.Size = new System.Drawing.Size(148, 17);
            this.destFolderRadioCurr.TabIndex = 8;
            this.destFolderRadioCurr.TabStop = true;
            this.destFolderRadioCurr.Text = "Folder In Current Directory";
            this.destFolderRadioCurr.UseVisualStyleBackColor = true;
            this.destFolderRadioCurr.CheckedChanged += new System.EventHandler(this.destFolderRadioCurr_CheckedChanged);
            // 
            // destFolderRadioPath
            // 
            this.destFolderRadioPath.AutoSize = true;
            this.destFolderRadioPath.Location = new System.Drawing.Point(160, 19);
            this.destFolderRadioPath.Name = "destFolderRadioPath";
            this.destFolderRadioPath.Size = new System.Drawing.Size(94, 17);
            this.destFolderRadioPath.TabIndex = 9;
            this.destFolderRadioPath.TabStop = true;
            this.destFolderRadioPath.Text = "Specified Path";
            this.destFolderRadioPath.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceFolderRadioCurr);
            this.groupBox1.Controls.Add(this.sourceFolderRadioPath);
            this.groupBox1.Controls.Add(this.srcFolderBox);
            this.groupBox1.Controls.Add(this.srcBrowseBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.destFolderRadioCurr);
            this.groupBox2.Controls.Add(this.dstFolderBox);
            this.groupBox2.Controls.Add(this.dstBrowseBtn);
            this.groupBox2.Controls.Add(this.destFolderRadioPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "?";
            this.toolTip1.SetToolTip(this.label2, "If you are moving files to a folder in the current directory, just type the folde" +
        "r name. Or choose a full path.");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.allExtCheckbox);
            this.groupBox3.Controls.Add(this.extensionsBox);
            this.groupBox3.Location = new System.Drawing.Point(254, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extensions (comma-separated)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "?";
            this.toolTip1.SetToolTip(this.label5, "e.g. if you want to move mkv and png only, type \"mkv,png\" without quotes");
            // 
            // allExtCheckbox
            // 
            this.allExtCheckbox.AutoSize = true;
            this.allExtCheckbox.Location = new System.Drawing.Point(140, 21);
            this.allExtCheckbox.Name = "allExtCheckbox";
            this.allExtCheckbox.Size = new System.Drawing.Size(91, 17);
            this.allExtCheckbox.TabIndex = 3;
            this.allExtCheckbox.Text = "All Extensions";
            this.allExtCheckbox.UseVisualStyleBackColor = true;
            this.allExtCheckbox.CheckedChanged += new System.EventHandler(this.allExtCheckbox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.fileNameBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 51);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start of file name (may be partial)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "?";
            this.toolTip1.SetToolTip(this.label3, "e.g. if the screenshot naming format is gamename_date.jpg you can type gamename o" +
        "r part of it. Case insensitive");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.organizeBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Screenshot Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.TextBox dstFolderBox;
        private System.Windows.Forms.TextBox extensionsBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button organizeBtn;
        private System.Windows.Forms.ColumnHeader fileNameCol;
        private System.Windows.Forms.ColumnHeader srcFolderCol;
        private System.Windows.Forms.ColumnHeader extensionsCol;
        private System.Windows.Forms.Label debugBox;
        private System.Windows.Forms.ColumnHeader dstFolderCol;
        private System.Windows.Forms.TextBox srcFolderBox;
        private System.Windows.Forms.Button srcBrowseBtn;
        private System.Windows.Forms.Button dstBrowseBtn;
        private System.Windows.Forms.RadioButton sourceFolderRadioCurr;
        private System.Windows.Forms.RadioButton sourceFolderRadioPath;
        private System.Windows.Forms.RadioButton destFolderRadioCurr;
        private System.Windows.Forms.RadioButton destFolderRadioPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox allExtCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}

