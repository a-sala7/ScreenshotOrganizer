using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshot_Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void readList()
        {
            using (StreamReader reader = new StreamReader("organizer.cfg", true))
            {
                string currLine = reader.ReadLine();
                while (currLine != null)
                {
                    string[] currData = currLine.Split(',');
                    ListViewItem currItem = new ListViewItem(currData[0]);
                    currItem.SubItems.Add(currData[1]);
                    string exts = "";
                    int sz = currData.Length;
                    for (int i = 2; i < sz; i++)
                    {
                        if (i == sz - 1)
                            exts += currData[i];
                        else
                        {
                            exts += currData[i];
                            exts += ',';
                        }
                    }
                    currItem.SubItems.Add(exts);
                    listView1.Items.Add(currItem);
                    currLine = reader.ReadLine();
                }
            }
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                folderNameBox.Text = fbd.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("organizer.cfg"))
            {
                File.Create("organizer.cfg").Close();
            }
            readList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileNameBox.Text) || string.IsNullOrWhiteSpace(folderNameBox.Text) || string.IsNullOrWhiteSpace(extensionsBox.Text))
                return;
            else
            {
                using (StreamWriter writer = new StreamWriter("organizer.cfg", true))
                {
                    writer.Write("{0},{1},", fileNameBox.Text, folderNameBox.Text);
                    if (extensionsBox.Text.ToLower() != "all")
                    {
                        string[] exts = extensionsBox.Text.Split(',');
                        int sz = exts.Length;
                        for (int i = 0; i < sz; i++)
                        {
                            if (i == sz - 1)
                                writer.Write(exts[i]);
                            else
                                writer.Write(exts[i] + ',');
                        }
                        writer.WriteLine();
                    }
                    else
                    {
                        writer.WriteLine("all");
                    }
                }
                listView1.Items.Clear();
                readList();
                fileNameBox.Clear();
                folderNameBox.Clear();
                extensionsBox.Clear();
            }
        }

        private void organizeBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("organizer.cfg", true))
            {
                string currLine = reader.ReadLine();
                while (currLine != null)
                {
                    string[] currData = currLine.Split(',');
                    int sz = currData.Length;
                    string destination;
                    if (currData[1].Contains(':'))
                        destination = currData[1];
                    else
                        destination = @".\" + currData[1] + @"\";
                    if (currData[2] == "all")
                    {
                        string[] filesToMove = Directory.GetFiles(@".\", currData[0] + "*.*");
                        if (filesToMove.Length > 0 && !Directory.Exists(destination))
                        {
                            Directory.CreateDirectory(destination);
                        }
                        foreach (string f in filesToMove)
                        {
                            File.Move(f, destination + f);
                        }
                    }
                    else
                    {
                        for (int i = 2; i < sz; i++)
                        {
                            string[] filesToMove = Directory.GetFiles(@".\", currData[0] + "*." + currData[i]);
                            if (filesToMove.Length > 0 && !Directory.Exists(destination))
                            {
                                Directory.CreateDirectory(destination);
                            }
                            foreach (string f in filesToMove)
                            {
                                File.Move(f, destination + f);
                            }
                        }
                    }
                    currLine = reader.ReadLine();
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;
            List<string> linesToRemove = new List<string>();
            foreach (ListViewItem x in listView1.SelectedItems)
            {
                linesToRemove.Add(string.Format("{0},{1},{2}", x.SubItems[0].Text, x.SubItems[1].Text, x.SubItems[2].Text));
            }
            using (StreamReader reader = new StreamReader("organizer.cfg", true))
            {
                using (StreamWriter writer = new StreamWriter("temp.cfg", true))
                {
                    string currLine = reader.ReadLine();
                    while (currLine != null)
                    {
                        bool removing = false;
                        if (linesToRemove.Contains(currLine))
                            removing = true;
                        if (!removing)
                        {
                            writer.WriteLine(currLine);
                        }
                        currLine = reader.ReadLine();
                    }
                }
            }
            File.Delete("organizer.cfg");
            File.Move("temp.cfg", "organizer.cfg");
            listView1.Items.Clear();
            readList();
        }
    }
}
