using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Screenshot_Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Task> taskList = new List<Task>();
        public string currDir = Directory.GetCurrentDirectory();
        public void readList()
        {
            string json = File.ReadAllText("organizer.json");
            taskList = JsonConvert.DeserializeObject<List<Task>>(json);
        }
        public void writeList()
        {
            string json = JsonConvert.SerializeObject(taskList, Formatting.Indented);
            File.WriteAllText("organizer.json", json);
        }
        public ListViewItem getTaskAsListViewItem(Task t)
        {
            var theItem = new ListViewItem(t.FileName);
            theItem.SubItems.Add(string.Join(",", t.Extensions));
            theItem.SubItems.Add(t.SourceFolder);
            theItem.SubItems.Add(t.DestinationFolder);
            return theItem;
        }
        public Task getListViewItemAsTask(ListViewItem i)
        {
            var theTask = new Task(i.SubItems[0].Text, i.SubItems[1].Text.ToLower().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries), i.SubItems[2].Text, i.SubItems[3].Text);
            return theTask;
        }
        public void refreshListView()
        {
            listView1.Items.Clear();
            foreach (Task t in taskList)
            {
                listView1.Items.Add(getTaskAsListViewItem(t));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("organizer.json"))
            {
                File.Create("organizer.json").Close();
                File.WriteAllText("organizer.json", "[]");
            }
            readList();
            refreshListView();
            srcFolderBox.Text = currDir;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileNameBox.Text) || string.IsNullOrWhiteSpace(dstFolderBox.Text) || string.IsNullOrWhiteSpace(extensionsBox.Text) || string.IsNullOrWhiteSpace(srcFolderBox.Text))
            {
                MessageBox.Show("Data missing.");
                return;
            }
            if (!validPath(srcFolderBox.Text))
            {
                MessageBox.Show("Invalid source path.");
                return;
            }
            if (!validName(fileNameBox.Text))
            {
                MessageBox.Show("Invalid name.");
                return;
            }
            var currTask = new Task(fileNameBox.Text, extensionsBox.Text.ToLower().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries), srcFolderBox.Text, dstFolderBox.Text);
            if (destFolderRadioCurr.Checked)
            {
                if (!validName(dstFolderBox.Text))
                {
                    MessageBox.Show("Invalid destination path");
                    return;
                }
                currTask.DestinationFolder = currDir + @"\" + currTask.DestinationFolder;
            }
            if (!validPath(currTask.DestinationFolder))
            {
                MessageBox.Show("Invalid destination path");
                return;
            }
            foreach (Task t in taskList)
            {
                if (TasksAreEqual(currTask, t))
                {
                    MessageBox.Show("Entry already exists.");
                    return;
                }
            }
            taskList.Add(currTask);
            refreshListView();
            writeList();
        }
        public bool TasksAreEqual(Task a, Task b)
        {
            if (a.FileName.ToLower() != b.FileName.ToLower())
                return false;
            if (a.SourceFolder.ToLower() != b.SourceFolder.ToLower())
                return false;
            if (a.DestinationFolder.ToLower() != b.DestinationFolder.ToLower())
                return false;
            if (a.Extensions.Length != b.Extensions.Length)
                return false;
            else
            {
                foreach (string s in a.Extensions)
                {
                    if (!b.Extensions.Contains(s))
                        return false;
                }
            }
            return true;
        }
        public void RemoveTask(Task a)
        {
            foreach(Task target in taskList)
            {
                if(a.FileName == target.FileName && a.SourceFolder == target.SourceFolder && a.DestinationFolder == target.DestinationFolder 
                    && string.Join(",", a.Extensions) == string.Join(",", target.Extensions))
                {
                    taskList.Remove(target);
                    return;
                }
            }
        }
        private void organizeBtn_Click(object sender, EventArgs e)
        {
            if(taskList.Count < 1)
            {
                MessageBox.Show("Nothing to organize.");
                return;
            }
            //var opStart = DateTime.Now;
            foreach(Task x in taskList)
            {
                if (!Directory.Exists(x.DestinationFolder))
                    Directory.CreateDirectory(x.DestinationFolder);
                if (x.Extensions[0] == "all")
                {
                    string[] filesToMove = Directory.GetFiles(x.SourceFolder, x.FileName + "*.*");
                    foreach (string f in filesToMove)
                    {
                        File.Move(f, f.Replace(x.SourceFolder, x.DestinationFolder));
                    }
                } else
                {
                    foreach (string ext in x.Extensions)
                    {
                        string[] filesToMove = Directory.GetFiles(x.SourceFolder, x.FileName + "*." + ext);
                        foreach (string f in filesToMove)
                        { 
                            File.Move(f, f.Replace(x.SourceFolder, x.DestinationFolder));
                        }
                    }
                }
            }
            //var opEnd = DateTime.Now;
            //debugBox.Text = "Operation completed in: " + (opEnd - opStart).TotalMilliseconds.ToString() + "ms";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("No items selected.");
                return;
            }
            foreach (ListViewItem curr in listView1.SelectedItems)
            {
                var taskToRemove = getListViewItemAsTask(curr);
                RemoveTask(taskToRemove);
            }
            refreshListView();
            writeList();
        }

        private void sourceFolderRadioCurr_CheckedChanged(object sender, EventArgs e)
        {
            if (sourceFolderRadioCurr.Checked)
            {
                srcFolderBox.Enabled = false;
                srcFolderBox.Text = currDir;
                srcBrowseBtn.Enabled = false;
            }
            if (sourceFolderRadioPath.Checked)
            {
                srcFolderBox.Enabled = true;
                srcBrowseBtn.Enabled = true;
            }
        }

        private void destFolderRadioCurr_CheckedChanged(object sender, EventArgs e)
        {
            if (destFolderRadioCurr.Checked)
            {
                dstBrowseBtn.Enabled = false;
            }
            if (destFolderRadioPath.Checked)
            {
                dstBrowseBtn.Enabled = true;
            }
        }

        private void allExtCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (allExtCheckbox.Checked)
            {
                extensionsBox.Enabled = false;
                extensionsBox.Text = "all";
            }
            else
            {
                extensionsBox.Enabled = true;
                extensionsBox.Text = "";
            }
        }

        private void srcBrowseBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                srcFolderBox.Text = fbd.SelectedPath;
        }

        private void dstBrowseBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                dstFolderBox.Text = fbd.SelectedPath;
        }
        public bool isAlpha(char c)
        {
            if (c >= 'a' && c <= 'z')
                return true;
            if (c >= 'A' && c <= 'Z')
                return true;
            return false;
        }
        public bool validPath(string p)
        {
            if(isAlpha(p[0]) && p[1] == ':' && p[2] == '\\')
            {
                return true;
            }
            return false;
        }
        public bool validName(string p)
        {
            string forbidden = "\\/:*?\"<>|";
            foreach(char f in forbidden)
            {
                if (p.Contains(f))
                    return false;
            }
            return true;
        }
    }
    public class Task
    {
        public string FileName, SourceFolder, DestinationFolder;
        public string[] Extensions;
        public Task(string _fileName, string[] _extensions, string _sourceFolder, string _destinationFolder)
        {
            FileName = _fileName;
            Extensions = _extensions;
            SourceFolder = _sourceFolder;
            DestinationFolder = _destinationFolder;
        }
    }
}
