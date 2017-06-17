using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zip
{
    public partial class Form1 : Form
    {
        string extractPath = "C://TMP";
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Environment.GetLogicalDrives());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem as String;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            listBoxDir.Items.Clear();
            listBoxDir.Items.Add("..");
            FillListBox(listBoxDir, label1.Text);
        }

        private void listBoxDir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newpath;
            if ((sender as ListBox).SelectedItem.Equals(".."))
            {
                DirectoryInfo dir = Directory.GetParent(label1.Text);
                if (dir != null)
                    newpath = dir.ToString();
                else
                    newpath = label1.Text;
            }
            else
            {
                newpath = Path.Combine(label1.Text, (sender as ListBox).SelectedItem.ToString());
            }
                if (Directory.Exists(newpath))
                    label1.Text = newpath;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxSel.Items.Add(listBoxDir.SelectedItem);

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxSel.Items.Remove(listBoxSel.SelectedItem);

        }

        private void buttonNewZip_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "zip files|*.zip";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelZip.Text = saveFileDialog1.FileName;
            }
        }

        private void buttonLoadZip_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "zip files|*.zip";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(extractPath);
                dir.Delete(true);
                labelZip.Text = openFileDialog1.FileName;
                if (Directory.Exists(extractPath) == false)
                {
                    Directory.CreateDirectory(extractPath);
                }
                ZipFile.ExtractToDirectory(labelZip.Text, extractPath);
                FillListBox(listBoxSel, extractPath);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FillTMP();
            ZipFile.CreateFromDirectory(saveFileDialog1.FileName, extractPath);
        }
        private void FillTMP()
        {
            DirectoryInfo target = new DirectoryInfo(extractPath);
            foreach (var item in listBoxSel.Items)
	        {
                if (item is DirectoryInfo)
                    CopyDir((item as DirectoryInfo), target);
                if (item is FileInfo)
                    (item as FileInfo).CopyTo(Path.Combine(target.ToString(), (item as FileInfo).Name), true);
            }
        }
        private void FillListBox(ListBox list, string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] Files = dir.GetFiles("*.*");
            DirectoryInfo[] Dirs = dir.GetDirectories();
            list.Items.AddRange(Dirs);
            list.Items.AddRange(Files);
        }
        private void CopyDir(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }
            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyDir(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
