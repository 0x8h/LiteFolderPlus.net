using Litefolderplus.csharp;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Litefolderplus
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
            godir.Text = "";
            Getdriveletter();
        }
        public void Getdriveletter()
        {
            if (godir.Text == "")
            {
                int i = 0;
                string[] drives = Directory.GetLogicalDrives();
                foreach (string s in drives)
                {
                    DriveInfo d = new DriveInfo(s);
                    long total = d.TotalSize;
                    Mainview.Items.Add(s);
                    Mainview.Items[i].SubItems.Add($"{total / (1024 * 1024 * 1024)}GB");
                    Mainview.Items[i].SubItems.Add($"{driveformattype.formattype(s)}");
                    Mainview.Items[i].SubItems.Add("");

                    i++;
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
                    var Item = new ListViewItem(dir.Name)
                    {
                        Tag = dir.FullName
                    };
                    Item.SubItems.Add("");
                    Item.SubItems.Add("");
                    Item.SubItems.Add("Folder");
                    Mainview.Items.Add(Item);
                }
            }
            catch(Exception e)
            {
                Exceptionwriter.exceptionwrite(e);
            }
        }

        private void Mainview_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0 && Mainview.SelectedItems.Count < 2)
                {
                    string a = Mainview.SelectedItems[0].Text;
                    GetDirctoryItems(a);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.exceptionwrite(ex);
            }
        }

        private void godir_KeyDown(object sender, KeyEventArgs e)
        {
            string a = godir.Text;
            try
            {
                if (Directory.Exists(a))
                {
                    GetDirctoryItems(a);
                }
                else if (File.Exists(a))
                {
                    //Open file it
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.exceptionwrite(ex);
            } 
        }
    }
}