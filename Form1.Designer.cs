namespace FileManager
{
    partial class FileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.leftBackBtn = new System.Windows.Forms.Button();
            this.leftNextBtn = new System.Windows.Forms.Button();
            this.leftListView = new System.Windows.Forms.ListView();
            this.leftIconList = new System.Windows.Forms.ImageList(this.components);
            this.leftFilePathTextBox = new System.Windows.Forms.TextBox();
            this.leftFileName = new System.Windows.Forms.Label();
            this.LeftFileNameLabel = new System.Windows.Forms.Label();
            this.leftTypeName = new System.Windows.Forms.Label();
            this.leftFileTypeLabel = new System.Windows.Forms.Label();
            this.rightListView = new System.Windows.Forms.ListView();
            this.rightIconList = new System.Windows.Forms.ImageList(this.components);
            this.rightBackBtn = new System.Windows.Forms.Button();
            this.rightNextBtn = new System.Windows.Forms.Button();
            this.rightFilePathTextBox = new System.Windows.Forms.TextBox();
            this.rightFileNme = new System.Windows.Forms.Label();
            this.rightFileNameLabel = new System.Windows.Forms.Label();
            this.rightTypeName = new System.Windows.Forms.Label();
            this.rightFileTypeLabel = new System.Windows.Forms.Label();
            this.leftFileSize = new System.Windows.Forms.Label();
            this.leftFileSizeLabel = new System.Windows.Forms.Label();
            this.rightFileSize = new System.Windows.Forms.Label();
            this.rightFileSizeLabel = new System.Windows.Forms.Label();
            this.leftContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.leftCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.leftDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.leftRename = new System.Windows.Forms.ToolStripMenuItem();
            this.leftOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.leftNew = new System.Windows.Forms.ToolStripMenuItem();
            this.leftNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.leftNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.rightContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.rightDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.rightRename = new System.Windows.Forms.ToolStripMenuItem();
            this.rightOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNew = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.leftContextMenu.SuspendLayout();
            this.rightContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBackBtn
            // 
            this.leftBackBtn.Location = new System.Drawing.Point(0, -2);
            this.leftBackBtn.Name = "leftBackBtn";
            this.leftBackBtn.Size = new System.Drawing.Size(75, 36);
            this.leftBackBtn.TabIndex = 0;
            this.leftBackBtn.Tag = "backBtn";
            this.leftBackBtn.Text = "Back";
            this.leftBackBtn.UseVisualStyleBackColor = true;
            this.leftBackBtn.Click += new System.EventHandler(this.leftBackBtn_Click);
            // 
            // leftNextBtn
            // 
            this.leftNextBtn.Location = new System.Drawing.Point(536, -2);
            this.leftNextBtn.Name = "leftNextBtn";
            this.leftNextBtn.Size = new System.Drawing.Size(75, 34);
            this.leftNextBtn.TabIndex = 1;
            this.leftNextBtn.Text = "Next";
            this.leftNextBtn.UseVisualStyleBackColor = true;
            this.leftNextBtn.Click += new System.EventHandler(this.leftNextBtn_Click);
            // 
            // leftListView
            // 
            this.leftListView.AllowDrop = true;
            this.leftListView.HideSelection = false;
            this.leftListView.LabelEdit = true;
            this.leftListView.LargeImageList = this.leftIconList;
            this.leftListView.Location = new System.Drawing.Point(0, 29);
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(611, 488);
            this.leftListView.TabIndex = 2;
            this.leftListView.Tag = "";
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.leftListView_AfterLabelEdit);
            this.leftListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.leftListView_ItemDrag);
            this.leftListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.leftlistView_ItemSelectionChanged);
            this.leftListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.leftListView_DragDrop);
            this.leftListView.DragOver += new System.Windows.Forms.DragEventHandler(this.leftListView_DragOver);
            this.leftListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leftListView_MouseClick);
            this.leftListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.leftListView_MouseDoubleClick);
            // 
            // leftIconList
            // 
            this.leftIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("leftIconList.ImageStream")));
            this.leftIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.leftIconList.Images.SetKeyName(0, "icons8-folder-48.png");
            this.leftIconList.Images.SetKeyName(1, "icons8-file-50.png");
            this.leftIconList.Images.SetKeyName(2, "icons8-txt-48.png");
            this.leftIconList.Images.SetKeyName(3, "icons8-system-48.png");
            this.leftIconList.Images.SetKeyName(4, "icons8-image-48.png");
            this.leftIconList.Images.SetKeyName(5, "icons8-video-48.png");
            this.leftIconList.Images.SetKeyName(6, "icons8-audio-48.png");
            this.leftIconList.Images.SetKeyName(7, "icons8-microsoft-powerpoint-48.png");
            this.leftIconList.Images.SetKeyName(8, "icons8-pdf-48.png");
            this.leftIconList.Images.SetKeyName(9, "icons8-xsl-48.png");
            this.leftIconList.Images.SetKeyName(10, "icons8-web-48.png");
            this.leftIconList.Images.SetKeyName(11, "icons8-file-contains-code-to-program-binary-file-system-48.png");
            this.leftIconList.Images.SetKeyName(12, "icons8-archive-48.png");
            // 
            // leftFilePathTextBox
            // 
            this.leftFilePathTextBox.Location = new System.Drawing.Point(78, 6);
            this.leftFilePathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.leftFilePathTextBox.Name = "leftFilePathTextBox";
            this.leftFilePathTextBox.Size = new System.Drawing.Size(455, 20);
            this.leftFilePathTextBox.TabIndex = 3;
            this.leftFilePathTextBox.Tag = "";
            // 
            // leftFileName
            // 
            this.leftFileName.AutoSize = true;
            this.leftFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftFileName.Location = new System.Drawing.Point(12, 534);
            this.leftFileName.Name = "leftFileName";
            this.leftFileName.Size = new System.Drawing.Size(66, 16);
            this.leftFileName.TabIndex = 4;
            this.leftFileName.Text = "FileName";
            // 
            // LeftFileNameLabel
            // 
            this.LeftFileNameLabel.AutoSize = true;
            this.LeftFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftFileNameLabel.Location = new System.Drawing.Point(84, 534);
            this.LeftFileNameLabel.Name = "LeftFileNameLabel";
            this.LeftFileNameLabel.Size = new System.Drawing.Size(15, 16);
            this.LeftFileNameLabel.TabIndex = 5;
            this.LeftFileNameLabel.Tag = "fileNameLabel";
            this.LeftFileNameLabel.Text = "--";
            // 
            // leftTypeName
            // 
            this.leftTypeName.AutoSize = true;
            this.leftTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftTypeName.Location = new System.Drawing.Point(486, 534);
            this.leftTypeName.Name = "leftTypeName";
            this.leftTypeName.Size = new System.Drawing.Size(61, 16);
            this.leftTypeName.TabIndex = 6;
            this.leftTypeName.Text = "FileType";
            // 
            // leftFileTypeLabel
            // 
            this.leftFileTypeLabel.AutoSize = true;
            this.leftFileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftFileTypeLabel.Location = new System.Drawing.Point(553, 534);
            this.leftFileTypeLabel.Name = "leftFileTypeLabel";
            this.leftFileTypeLabel.Size = new System.Drawing.Size(15, 16);
            this.leftFileTypeLabel.TabIndex = 7;
            this.leftFileTypeLabel.Tag = "fileTypeLabel";
            this.leftFileTypeLabel.Text = "--";
            // 
            // rightListView
            // 
            this.rightListView.AllowDrop = true;
            this.rightListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightListView.HideSelection = false;
            this.rightListView.LabelEdit = true;
            this.rightListView.LargeImageList = this.rightIconList;
            this.rightListView.Location = new System.Drawing.Point(617, 29);
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(611, 488);
            this.rightListView.TabIndex = 2;
            this.rightListView.Tag = "";
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.rightListView_AfterLabelEdit);
            this.rightListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.rightListView_ItemDrag);
            this.rightListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.rightlistView_ItemSelectionChanged);
            this.rightListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.rightListView_DragDrop);
            this.rightListView.DragOver += new System.Windows.Forms.DragEventHandler(this.rightListView_DragOver);
            this.rightListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rightListView_MouseClick);
            this.rightListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rightListView_MouseDoubleClick);
            // 
            // rightIconList
            // 
            this.rightIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightIconList.ImageStream")));
            this.rightIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.rightIconList.Images.SetKeyName(0, "icons8-folder-48.png");
            this.rightIconList.Images.SetKeyName(1, "icons8-file-50.png");
            this.rightIconList.Images.SetKeyName(2, "icons8-txt-48.png");
            this.rightIconList.Images.SetKeyName(3, "icons8-system-48.png");
            this.rightIconList.Images.SetKeyName(4, "icons8-image-48.png");
            this.rightIconList.Images.SetKeyName(5, "icons8-video-48.png");
            this.rightIconList.Images.SetKeyName(6, "icons8-audio-48.png");
            this.rightIconList.Images.SetKeyName(7, "icons8-microsoft-powerpoint-48.png");
            this.rightIconList.Images.SetKeyName(8, "icons8-pdf-48.png");
            this.rightIconList.Images.SetKeyName(9, "icons8-xsl-48.png");
            this.rightIconList.Images.SetKeyName(10, "icons8-web-48.png");
            this.rightIconList.Images.SetKeyName(11, "icons8-file-contains-code-to-program-binary-file-system-48.png");
            this.rightIconList.Images.SetKeyName(12, "icons8-archive-48.png");
            // 
            // rightBackBtn
            // 
            this.rightBackBtn.Location = new System.Drawing.Point(617, -2);
            this.rightBackBtn.Name = "rightBackBtn";
            this.rightBackBtn.Size = new System.Drawing.Size(75, 36);
            this.rightBackBtn.TabIndex = 0;
            this.rightBackBtn.Tag = "backBtn";
            this.rightBackBtn.Text = "Back";
            this.rightBackBtn.UseVisualStyleBackColor = true;
            this.rightBackBtn.Click += new System.EventHandler(this.rightBackBtn_Click);
            // 
            // rightNextBtn
            // 
            this.rightNextBtn.Location = new System.Drawing.Point(1153, -2);
            this.rightNextBtn.Name = "rightNextBtn";
            this.rightNextBtn.Size = new System.Drawing.Size(75, 34);
            this.rightNextBtn.TabIndex = 1;
            this.rightNextBtn.Text = "Next";
            this.rightNextBtn.UseVisualStyleBackColor = true;
            this.rightNextBtn.Click += new System.EventHandler(this.rightNextBtn_Click);
            // 
            // rightFilePathTextBox
            // 
            this.rightFilePathTextBox.Location = new System.Drawing.Point(695, 6);
            this.rightFilePathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.rightFilePathTextBox.Name = "rightFilePathTextBox";
            this.rightFilePathTextBox.Size = new System.Drawing.Size(455, 20);
            this.rightFilePathTextBox.TabIndex = 3;
            this.rightFilePathTextBox.Tag = "";
            // 
            // rightFileNme
            // 
            this.rightFileNme.AutoSize = true;
            this.rightFileNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileNme.Location = new System.Drawing.Point(626, 534);
            this.rightFileNme.Name = "rightFileNme";
            this.rightFileNme.Size = new System.Drawing.Size(66, 16);
            this.rightFileNme.TabIndex = 4;
            this.rightFileNme.Text = "FileName";
            // 
            // rightFileNameLabel
            // 
            this.rightFileNameLabel.AutoSize = true;
            this.rightFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileNameLabel.Location = new System.Drawing.Point(698, 534);
            this.rightFileNameLabel.Name = "rightFileNameLabel";
            this.rightFileNameLabel.Size = new System.Drawing.Size(15, 16);
            this.rightFileNameLabel.TabIndex = 5;
            this.rightFileNameLabel.Tag = "fileNameLabel";
            this.rightFileNameLabel.Text = "--";
            // 
            // rightTypeName
            // 
            this.rightTypeName.AutoSize = true;
            this.rightTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightTypeName.Location = new System.Drawing.Point(1103, 534);
            this.rightTypeName.Name = "rightTypeName";
            this.rightTypeName.Size = new System.Drawing.Size(61, 16);
            this.rightTypeName.TabIndex = 6;
            this.rightTypeName.Text = "FileType";
            // 
            // rightFileTypeLabel
            // 
            this.rightFileTypeLabel.AutoSize = true;
            this.rightFileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileTypeLabel.Location = new System.Drawing.Point(1170, 534);
            this.rightFileTypeLabel.Name = "rightFileTypeLabel";
            this.rightFileTypeLabel.Size = new System.Drawing.Size(15, 16);
            this.rightFileTypeLabel.TabIndex = 7;
            this.rightFileTypeLabel.Tag = "fileTypeLabel";
            this.rightFileTypeLabel.Text = "--";
            // 
            // leftFileSize
            // 
            this.leftFileSize.AutoSize = true;
            this.leftFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftFileSize.Location = new System.Drawing.Point(346, 534);
            this.leftFileSize.Name = "leftFileSize";
            this.leftFileSize.Size = new System.Drawing.Size(55, 16);
            this.leftFileSize.TabIndex = 8;
            this.leftFileSize.Text = "FileSize";
            // 
            // leftFileSizeLabel
            // 
            this.leftFileSizeLabel.AutoSize = true;
            this.leftFileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftFileSizeLabel.Location = new System.Drawing.Point(407, 534);
            this.leftFileSizeLabel.Name = "leftFileSizeLabel";
            this.leftFileSizeLabel.Size = new System.Drawing.Size(15, 16);
            this.leftFileSizeLabel.TabIndex = 8;
            this.leftFileSizeLabel.Text = "--";
            // 
            // rightFileSize
            // 
            this.rightFileSize.AutoSize = true;
            this.rightFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileSize.Location = new System.Drawing.Point(969, 534);
            this.rightFileSize.Name = "rightFileSize";
            this.rightFileSize.Size = new System.Drawing.Size(55, 16);
            this.rightFileSize.TabIndex = 8;
            this.rightFileSize.Text = "FileSize";
            // 
            // rightFileSizeLabel
            // 
            this.rightFileSizeLabel.AutoSize = true;
            this.rightFileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileSizeLabel.Location = new System.Drawing.Point(1030, 534);
            this.rightFileSizeLabel.Name = "rightFileSizeLabel";
            this.rightFileSizeLabel.Size = new System.Drawing.Size(15, 16);
            this.rightFileSizeLabel.TabIndex = 8;
            this.rightFileSizeLabel.Text = "--";
            // 
            // leftContextMenu
            // 
            this.leftContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftCopy,
            this.leftDelete,
            this.leftRename,
            this.leftOpen,
            this.leftNew});
            this.leftContextMenu.Name = "contextMenuStrip1";
            this.leftContextMenu.Size = new System.Drawing.Size(118, 114);
            // 
            // leftCopy
            // 
            this.leftCopy.Image = global::FileManager.Properties.Resources.icons8_copy_15;
            this.leftCopy.Name = "leftCopy";
            this.leftCopy.Size = new System.Drawing.Size(117, 22);
            this.leftCopy.Text = "Copy";
            this.leftCopy.Click += new System.EventHandler(this.leftCopy_Click);
            // 
            // leftDelete
            // 
            this.leftDelete.Image = global::FileManager.Properties.Resources.icons8_delete_15;
            this.leftDelete.Name = "leftDelete";
            this.leftDelete.Size = new System.Drawing.Size(117, 22);
            this.leftDelete.Text = "Delete";
            this.leftDelete.Click += new System.EventHandler(this.leftDelete_Click);
            // 
            // leftRename
            // 
            this.leftRename.Image = global::FileManager.Properties.Resources.icons8_rename_15;
            this.leftRename.Name = "leftRename";
            this.leftRename.Size = new System.Drawing.Size(117, 22);
            this.leftRename.Text = "Rename";
            this.leftRename.Click += new System.EventHandler(this.leftRename_Click);
            // 
            // leftOpen
            // 
            this.leftOpen.Image = global::FileManager.Properties.Resources.icons8_open_15;
            this.leftOpen.Name = "leftOpen";
            this.leftOpen.Size = new System.Drawing.Size(117, 22);
            this.leftOpen.Text = "Open";
            this.leftOpen.Click += new System.EventHandler(this.leftOpen_Click);
            // 
            // leftNew
            // 
            this.leftNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftNewFile,
            this.leftNewFolder});
            this.leftNew.Image = global::FileManager.Properties.Resources.icons8_new_15;
            this.leftNew.Name = "leftNew";
            this.leftNew.Size = new System.Drawing.Size(117, 22);
            this.leftNew.Text = "New";
            // 
            // leftNewFile
            // 
            this.leftNewFile.Image = global::FileManager.Properties.Resources.icons8_file_15;
            this.leftNewFile.Name = "leftNewFile";
            this.leftNewFile.Size = new System.Drawing.Size(107, 22);
            this.leftNewFile.Text = "File";
            this.leftNewFile.Click += new System.EventHandler(this.leftNewFile_Click);
            // 
            // leftNewFolder
            // 
            this.leftNewFolder.Image = global::FileManager.Properties.Resources.icons8_folder_15;
            this.leftNewFolder.Name = "leftNewFolder";
            this.leftNewFolder.Size = new System.Drawing.Size(107, 22);
            this.leftNewFolder.Text = "Folder";
            this.leftNewFolder.Click += new System.EventHandler(this.leftNewFolder_Click);
            // 
            // rightContextMenu
            // 
            this.rightContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightCopy,
            this.rightDelete,
            this.rightRename,
            this.rightOpen,
            this.rightNew});
            this.rightContextMenu.Name = "rightContextMenu";
            this.rightContextMenu.Size = new System.Drawing.Size(118, 114);
            // 
            // rightCopy
            // 
            this.rightCopy.Image = global::FileManager.Properties.Resources.icons8_copy_15;
            this.rightCopy.Name = "rightCopy";
            this.rightCopy.Size = new System.Drawing.Size(117, 22);
            this.rightCopy.Text = "Copy";
            this.rightCopy.Click += new System.EventHandler(this.rightCopy_Click);
            // 
            // rightDelete
            // 
            this.rightDelete.Image = global::FileManager.Properties.Resources.icons8_delete_15;
            this.rightDelete.Name = "rightDelete";
            this.rightDelete.Size = new System.Drawing.Size(117, 22);
            this.rightDelete.Text = "Delete";
            this.rightDelete.Click += new System.EventHandler(this.rightDelete_Click);
            // 
            // rightRename
            // 
            this.rightRename.Image = global::FileManager.Properties.Resources.icons8_rename_15;
            this.rightRename.Name = "rightRename";
            this.rightRename.Size = new System.Drawing.Size(117, 22);
            this.rightRename.Text = "Rename";
            this.rightRename.Click += new System.EventHandler(this.rightRename_Click);
            // 
            // rightOpen
            // 
            this.rightOpen.Image = global::FileManager.Properties.Resources.icons8_open_15;
            this.rightOpen.Name = "rightOpen";
            this.rightOpen.Size = new System.Drawing.Size(117, 22);
            this.rightOpen.Text = "Open";
            this.rightOpen.Click += new System.EventHandler(this.rightOpen_Click);
            // 
            // rightNew
            // 
            this.rightNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightNewFile,
            this.rightNewFolder});
            this.rightNew.Image = global::FileManager.Properties.Resources.icons8_new_15;
            this.rightNew.Name = "rightNew";
            this.rightNew.Size = new System.Drawing.Size(117, 22);
            this.rightNew.Text = "New";
            // 
            // rightNewFile
            // 
            this.rightNewFile.Image = global::FileManager.Properties.Resources.icons8_file_15;
            this.rightNewFile.Name = "rightNewFile";
            this.rightNewFile.Size = new System.Drawing.Size(107, 22);
            this.rightNewFile.Text = "File";
            this.rightNewFile.Click += new System.EventHandler(this.rightNewFile_Click);
            // 
            // rightNewFolder
            // 
            this.rightNewFolder.Image = global::FileManager.Properties.Resources.icons8_folder_15;
            this.rightNewFolder.Name = "rightNewFolder";
            this.rightNewFolder.Size = new System.Drawing.Size(107, 22);
            this.rightNewFolder.Text = "Folder";
            this.rightNewFolder.Click += new System.EventHandler(this.rightNewFolder_Click);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 591);
            this.Controls.Add(this.rightFileSizeLabel);
            this.Controls.Add(this.rightFileSize);
            this.Controls.Add(this.leftFileSizeLabel);
            this.Controls.Add(this.leftFileSize);
            this.Controls.Add(this.rightFileTypeLabel);
            this.Controls.Add(this.leftFileTypeLabel);
            this.Controls.Add(this.rightTypeName);
            this.Controls.Add(this.rightFileNameLabel);
            this.Controls.Add(this.leftTypeName);
            this.Controls.Add(this.rightFileNme);
            this.Controls.Add(this.LeftFileNameLabel);
            this.Controls.Add(this.leftFileName);
            this.Controls.Add(this.rightFilePathTextBox);
            this.Controls.Add(this.leftFilePathTextBox);
            this.Controls.Add(this.rightListView);
            this.Controls.Add(this.rightNextBtn);
            this.Controls.Add(this.leftListView);
            this.Controls.Add(this.rightBackBtn);
            this.Controls.Add(this.leftNextBtn);
            this.Controls.Add(this.leftBackBtn);
            this.Name = "FileManager";
            this.Text = "FileManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftContextMenu.ResumeLayout(false);
            this.rightContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leftBackBtn;
        private System.Windows.Forms.Button leftNextBtn;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.TextBox leftFilePathTextBox;
        private System.Windows.Forms.Label leftFileName;
        private System.Windows.Forms.Label LeftFileNameLabel;
        private System.Windows.Forms.Label leftTypeName;
        private System.Windows.Forms.Label leftFileTypeLabel;
        private System.Windows.Forms.ImageList leftIconList;
        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.Button rightBackBtn;
        private System.Windows.Forms.Button rightNextBtn;
        private System.Windows.Forms.TextBox rightFilePathTextBox;
        private System.Windows.Forms.Label rightFileNme;
        private System.Windows.Forms.Label rightFileNameLabel;
        private System.Windows.Forms.Label rightTypeName;
        private System.Windows.Forms.Label rightFileTypeLabel;
        private System.Windows.Forms.ImageList rightIconList;
        private System.Windows.Forms.Label leftFileSize;
        private System.Windows.Forms.Label leftFileSizeLabel;
        private System.Windows.Forms.Label rightFileSize;
        private System.Windows.Forms.Label rightFileSizeLabel;
        private System.Windows.Forms.ContextMenuStrip leftContextMenu;
        private System.Windows.Forms.ToolStripMenuItem leftCopy;
        private System.Windows.Forms.ToolStripMenuItem leftDelete;
        private System.Windows.Forms.ContextMenuStrip rightContextMenu;
        private System.Windows.Forms.ToolStripMenuItem rightCopy;
        private System.Windows.Forms.ToolStripMenuItem rightDelete;
        private System.Windows.Forms.ToolStripMenuItem leftRename;
        private System.Windows.Forms.ToolStripMenuItem rightRename;
        private System.Windows.Forms.ToolStripMenuItem leftOpen;
        private System.Windows.Forms.ToolStripMenuItem rightOpen;
        private System.Windows.Forms.ToolStripMenuItem rightNew;
        private System.Windows.Forms.ToolStripMenuItem rightNewFile;
        private System.Windows.Forms.ToolStripMenuItem rightNewFolder;
        private System.Windows.Forms.ToolStripMenuItem leftNew;
        private System.Windows.Forms.ToolStripMenuItem leftNewFile;
        private System.Windows.Forms.ToolStripMenuItem leftNewFolder;
    }
}

