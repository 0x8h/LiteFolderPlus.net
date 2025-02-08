using Litefolderplus.csharp;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace Litefolderplus
{

    public partial class mainwindow : Form
    {
        static string mem1;
        static string mem2;
        static string title = "LiteFolderPlus";
        public mainwindow()
        {
            InitializeComponent();
            gohome();
            
        }
        public void Getdriveletter()
        {
            if (godir.Text == "")
            {
                string[] drives = Directory.GetLogicalDrives();
                foreach (string s in drives)
                {
                    DriveInfo d = new DriveInfo(s);
                    long total = d.TotalSize;
                    itemsadd(s, $"{total / (1024 * 1024 * 1024)}GB", $"{driveformattype.formattype(s)}", "");
                }
            }
        }

        public void GetDirctoryItems(string sDir)
        {
            Mainview.Items.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo(sDir);
                foreach (var dir in di.GetDirectories())
                {
                    itemsadd(dir.Name, "", "Folder", $"{Directory.GetLastWriteTime(dir.FullName)}", dir.FullName);
                }
            }
            catch (Exception e)
            {
                Exceptionwriter.exceptionwrite(e);
            }
        }
        private void GetFiles(string sDir)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(sDir);
                FileInfo[] fi = di.GetFiles("*");
                foreach(FileInfo fi2 in fi)
                {
                    itemsadd(fi2.Name, $"{files.GetFilesize(fi2)}", "file", $"{Directory.GetLastWriteTime(fi2.FullName)}", fi2.FullName);
                }
            }
            catch(Exception ex)
            {
                Exceptionwriter.exceptionwrite(ex);
            }
        }
        private void itemsadd(string item, string size, string type, string date, string optitem = null)
        {
            if (optitem == null)
            {
                optitem = item;
            }
            var Item = new ListViewItem(item)
            {
                Tag = optitem
            };
            Item.SubItems.Add(size);
            Item.SubItems.Add(type);
            Item.SubItems.Add(date);
            Mainview.Items.Add(Item);
        }

        private void Mainview_Click(object sender, EventArgs e)
        {

        }

        private void godir_KeyDown(object sender, KeyEventArgs e)
        {
            string a = godir.Text;
            try
            {
                if (Directory.Exists(a))
                {
                    GetDirctoryItems(a);
                    GetFiles(a);
                }
                else if (File.Exists(a))
                {
                    Openfile.openfileindefaultapplication(a);
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.exceptionwrite(ex);
            } 
        }

        private void gohome()
        {
            godir.Text = "";
            Mainview.Items.Clear();
            Getdriveletter();
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gohome();
        }

        private void Mainview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0 && Mainview.SelectedItems.Count < 2)
                {
                    string a = Mainview.SelectedItems[0].Text;
                    mem2 = a;
                    if (directorys.IsDrive(a))
                    {
                        godir.Text = a;
                        Text = $"{title} - {godir.Text}";
                        GetDirctoryItems(a);
                        GetFiles(a);
                    }
                    else
                    {
                        godir.Text += $@"{a}\";
                        if (Directory.Exists(godir.Text))
                        {
                            Text = $"{title} - {godir.Text}";
                            GetDirctoryItems(godir.Text);
                            GetFiles(godir.Text);
                        }
                        else if (File.Exists(godir.Text = godir.Text.Substring(0, godir.Text.Length - 1)))
                        {
                            mem1 = a;
                            Openfile.openfileindefaultapplication(godir.Text);
                            godir.Text = godir.Text.Substring(0, godir.Text.Length - a.Length);
                        }
                        else
                        {
                            Text = $"{title} - Not found files / dirctory";
                            gohome();
                        }
                    }

                }
                else
                {
                    win32.MessageBeep(0);
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.exceptionwrite(ex);
            }
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0)
                {
                    string a = $@"{godir.Text}{Mainview.SelectedItems[0].Text}";
                    StringCollection str = new StringCollection();
                    str.Add(a);
                    Movedialog movedialog = new Movedialog();
                    movedialog.ShowDialog();
                }
            }
            catch (Exception ez)
            {
                Exceptionwriter.exceptionwrite(ez);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0)
                {
                    StringCollection strings = new StringCollection();
                    if (Mainview.SelectedItems.Count > 1)
                    {
                        for (int i = 0; i < Mainview.SelectedItems.Count; i++)
                        {
                            string aa = $@"{godir.Text}{Mainview.SelectedItems[i].Text}";
                            strings.Add(aa);
                        }
                        Clipboard.SetFileDropList(strings);
                    }
                    string a = $@"{godir.Text}{Mainview.SelectedItems[0].Text}";
                    strings.Add(a);
                    Clipboard.SetFileDropList(strings);
                }
            }
            catch (Exception ez)
            {
                Exceptionwriter.exceptionwrite(ez);
            }
        }
    }
    public class DoubleBufferingthis : ListView
    {
        public DoubleBufferingthis()
        {
            DoubleBuffered = false;
        }
    }
}