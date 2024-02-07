﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using File = System.IO.File;
namespace FileManager
{
    public partial class FileManager : Form
    {
        Window right = new Window();
        Window left = new Window();
        public FileManager()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            leftFilePathTextBox.Text = left.FilePath;
            rightFilePathTextBox.Text = right.FilePath;
            right.loadFilesAndDirectories(rightFileNameLabel, rightFileTypeLabel, rightFileSizeLabel, rightListView);
            left.loadFilesAndDirectories(LeftFileNameLabel, leftFileTypeLabel, leftFileSizeLabel, leftListView);
        }

        private void rightloadButtonAction()
        {
            right.FilePath = rightFilePathTextBox.Text;
            right.loadFilesAndDirectories(rightFileNameLabel, rightFileTypeLabel, rightFileSizeLabel, rightListView);
            right.IsFile = false;
        }
        private void leftloadButtonAction()
        {
            left.FilePath = leftFilePathTextBox.Text;
            left.loadFilesAndDirectories(LeftFileNameLabel, leftFileTypeLabel, leftFileSizeLabel, leftListView);
            left.IsFile = false;
        }

        private void leftNextBtn_Click(object sender, EventArgs e)
        {
            leftloadButtonAction();
        }
        private void rightNextBtn_Click(object sender, EventArgs e)
        {
            rightloadButtonAction();
        }

        private void leftlistView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            left.CurrentlySelectedItem = e.Item.Text;
            left.directoryCheckSetPath(leftFilePathTextBox);

        }
        private void rightlistView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            right.CurrentlySelectedItem = e.Item.Text;
            right.directoryCheckSetPath(rightFilePathTextBox);
        }

        private void leftListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                leftloadButtonAction();
            }
            catch (Exception ex)
            {
                left.goBack(leftFilePathTextBox);
                throw new Exception(ex.Message);
            }
        }
        private void rightListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                rightloadButtonAction();
            }
            catch (Exception ex)
            {
                right.goBack(rightFilePathTextBox);
                throw new Exception(ex.Message);
            }
        }

        private void leftBackBtn_Click(object sender, EventArgs e)
        {
            left.goBack(leftFilePathTextBox);
            leftloadButtonAction();
        }
        private void rightBackBtn_Click(object sender, EventArgs e)
        {
            right.goBack(rightFilePathTextBox);
            rightloadButtonAction();
        }

        private void leftListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // pass the items to move...
            leftListView.DoDragDrop(items, DragDropEffects.Move);
        }

        private void rightListView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    right.DropItem(left, rightListView, lvi);
                }
            }
        }
        private void rightListView_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void rightListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>();
            items.Add((ListViewItem)e.Item);
            leftListView.DoDragDrop(items, DragDropEffects.Move);
        }

        private void leftListView_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void leftListView_DragDrop(object sender, DragEventArgs e)
        {
            var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
            // move to dest LV
            foreach (ListViewItem lvi in items)
            {
                left.DropItem(right, leftListView, lvi);
            }
        }

        private void leftListView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var focusedItem = leftListView.FocusedItem;
                if (focusedItem != null)
                {
                    leftContextMenu.Show(Cursor.Position);
                    left.focusedItem = focusedItem;
                }
            }
        }

        private void leftCopy_Click(object sender, EventArgs e)
        {
            left.Copy(leftListView);
        }

        private void leftDelete_Click(object sender, EventArgs e)
        {
            left.Delete(leftListView);
        }

        private void rightCopy_Click(object sender, EventArgs e)
        {
            right.Copy(rightListView);
        }

        private void rightDelete_Click(object sender, EventArgs e)
        {
            right.Delete(rightListView);
        }

        private void rightListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = rightListView.FocusedItem;
                if (focusedItem != null)
                {
                    rightContextMenu.Show(Cursor.Position);
                    right.focusedItem = focusedItem;
                }
            }
        }

        private void leftRename_Click(object sender, EventArgs e)
        {
            left.focusedItem.BeginEdit();
        }

        private void leftListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            left.RenameItem(e.Label);
        }

        private void rightRename_Click(object sender, EventArgs e)
        {
            right.focusedItem.BeginEdit();
        }

        private void rightListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            right.RenameItem(e.Label);
        }

        private void rightOpen_Click(object sender, EventArgs e)
        {
            right.Open();
        }

        private void leftOpen_Click(object sender, EventArgs e)
        {
            left.Open();
        }
    }
    class Window
    {
        private string filePath = "C:/";
        private bool isFile = false;
        private string currentlySelectedItem = "";
        public ListViewItem focusedItem { get; set; }
            
        public string FilePath { get => filePath; set => filePath = value; }
        public string CurrentlySelectedItem { get => currentlySelectedItem; set => currentlySelectedItem = value; }
        public bool IsFile { get => isFile; set => isFile = value; }
        public Window() { }

        public void loadFilesAndDirectories(Label fileNameLabel, Label fileTypeLabel, Label fileSizeLabel, ListView listView)
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            try
            {
                if (IsFile)
                {
                    tempFilePath = this.FilePath + "/" + this.CurrentlySelectedItem;
                    FileInfo fd = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fd.Name;
                    fileTypeLabel.Text = fd.Extension;
                    fileSizeLabel.Text = (fd.Length / 1000).ToString() + " kb";
                }
                else
                {
                    fileList = new DirectoryInfo(FilePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listView.Items.Clear();
                    foreach (FileInfo file in files)
                    {
                        listView.Items.Add(file.Name, 1);
                    }
                    foreach (var dir in dirs)
                    {
                        listView.Items.Add(dir.Name, 0);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void removeLastSlash(TextBox filePathTextBox)
        {
            string path = filePathTextBox.Text;
            if (path[path.Length - 1] == '/')
            {
                path.Remove(path.Length - 1);
                filePathTextBox.Text = path;
            }
        }
        public void goBack(TextBox filePathTextBox)
        {
            string path = filePathTextBox.Text;
            if (path == "C:/") return;
            try
            {
                removeLastSlash(filePathTextBox);
                path = path.Substring(0, path.LastIndexOf("/"));
                this.IsFile = false;
                filePathTextBox.Text = path;
                removeLastSlash(filePathTextBox);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public void directoryCheckSetPath(TextBox filePathTextBox)
        {
            try
            {
                FileAttributes fileAttr = File.GetAttributes(this.FilePath + "/" + this.CurrentlySelectedItem);
                if (fileAttr.HasFlag(FileAttributes.Directory))
                {
                    this.IsFile = false;
                    filePathTextBox.Text = this.FilePath + "/" + this.CurrentlySelectedItem;
                }
                else
                {
                    this.IsFile = true;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        public void Copy(ListView listView)
        {
            string this_file_path = this.FilePath + "/" + this.focusedItem.Text;
            FileAttributes attr = File.GetAttributes(this_file_path);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                CopyDirectory(this_file_path, this.FilePath + "/" + this.focusedItem.Text + "_copy", false);
                ListViewItem item = (ListViewItem)this.focusedItem.Clone();
                item.Text = this.focusedItem.Text + "_copy";
                listView.Items.Add(item);
            }

            else
            {
                string name = this.focusedItem.Text.Substring(0, this.focusedItem.Text.LastIndexOf('.'));
                string ext = this.focusedItem.Text.Substring(this.focusedItem.Text.LastIndexOf('.'), this.focusedItem.Text.Length - name.Length);
                File.Copy(this_file_path, this.FilePath + "/" + name + "_copy" + ext);
                ListViewItem item = (ListViewItem)this.focusedItem.Clone();
                item.Text = name + "_copy" + ext;
                listView.Items.Add(item);
            }
        }
        public void Delete(ListView listView)
        {
            string this_file_path = this.FilePath + "/" + this.focusedItem.Text;
            FileAttributes attr = File.GetAttributes(this_file_path);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                Directory.Delete(this_file_path, true);
                listView.Items.Remove(focusedItem);
            }

            else
            {
                File.Delete(this_file_path);
                listView.Items.Remove(focusedItem);
            }
        }
        public void DropItem(Window opposite, ListView listView, ListViewItem lvi)
        {
            string lvi_file_path = opposite.FilePath + "/" + lvi.Text;
            FileAttributes attr = File.GetAttributes(lvi_file_path);
            if (attr.HasFlag(FileAttributes.Directory))
                Directory.Move(lvi_file_path, FilePath + "/" + lvi.Text);
            else
                File.Move(lvi_file_path, FilePath + "/" + lvi.Text);

            // LVI obj can only belong to one LVI, remove
            lvi.ListView.Items.Remove(lvi);
            listView.Items.Add(lvi);
        }

        public void RenameItem(string label)
        {
            if (label != null)
            {
                string lastname = focusedItem.Text;
                focusedItem.Text = label;
                string this_file_path = FilePath + "/" + lastname;
                FileAttributes attr = File.GetAttributes(this_file_path);
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    Directory.Move(this_file_path, FilePath + "/" + label);
                }
                else
                {
                    File.Move(this_file_path, FilePath + "/" + label);
                }
            }
        }
        public void Open()
        {
            string tempFilePath = this.FilePath + "/" + this.focusedItem.Text;
            Process.Start(tempFilePath);
        }

        private static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            var dir = new DirectoryInfo(sourceDir);

            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destinationDir);
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
    }
}
