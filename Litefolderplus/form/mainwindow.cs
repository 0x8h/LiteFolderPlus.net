using Litefolderplus.csharp;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
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

        private void GetDirctoryItems(string sDir)
        {
            Mainview.Items.Clear();
            GetFolder.Get(Mainview, sDir);
        }

        private void GetFile(string sDir)
        {
            GetFiles.Get(Mainview, sDir);
        }

        private void gohome()
        {
            int current = tabControl1.SelectedIndex;
            AddressBar.Text = "";
            Mainview.Items.Clear();
            Text = title;
            tabControl1.TabPages[current].Text = "Newtab";
            GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gohome();
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e) //soon tm
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0)
                {
                    string a = $@"{AddressBar.Text}{Mainview.SelectedItems[0].Text}";
                    StringCollection str = new StringCollection();
                    str.Add(a);
                    Movedialog movedialog = new Movedialog();
                    movedialog.ShowDialog();
                }
            }
            catch (Exception ez)
            {
                Exceptionwriter.write(ez);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RightClickMenuFunc.Copy(Mainview, AddressBar);
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "Newtab" + Gettabnum.Get(tabControl1);
            tab.Text = "Newtab";
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            Panel panel = new Panel();
            panel.Controls.AddRange(basepanel.Controls.Cast<Control>().ToArray());
            tab.Controls.Add(panel);
        }

        private void Mainview_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0 && Mainview.SelectedItems.Count < 2)
                {
                    string a = Mainview.SelectedItems[0].Text;
                    int af = tabControl1.SelectedIndex;
                    mem2 = a;
                    if (Root.IsDrive(a))
                    {
                        AddressBar.Text = a;
                        Text = $"{title} - {AddressBar.Text}";
                        tabControl1.TabPages[af].Text = a;
                        GetDirctoryItems(a);
                        GetFile(a);
                    }
                    else if (AddressBar.Text == "Home")
                    {
                        
                    }
                    else
                    {
                        AddressBar.Text += $@"{a}\";
                        if (Directory.Exists(AddressBar.Text))
                        {
                            Text = $"{title} - {AddressBar.Text}";
                            tabControl1.TabPages[af].Text = a;
                            GetDirctoryItems(AddressBar.Text);
                            GetFile(AddressBar.Text);
                        }
                        else if (File.Exists(AddressBar.Text = AddressBar.Text.Substring(0, AddressBar.Text.Length - 1)))
                        {
                            mem1 = a;
                            tabControl1.TabPages[af].Text = a;
                            Openfile.openfileindefaultapplication(AddressBar.Text);
                            AddressBar.Text = AddressBar.Text.Substring(0, AddressBar.Text.Length - a.Length);
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
                    publics.MessageBeep(0);
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }

        private void godir_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (AddressBarFunc.AddressExistCheck(AddressBar))
            {
                case 1:
                    GetDirctoryItems(AddressBar.Text);
                    GetFile(AddressBar.Text);
                    break;
                case 2:
                    Openfile.openfileindefaultapplication(AddressBar.Text);
                    break;
            }
        }

        private void openItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count == 1)
                {
                    Openfile.openfileindefaultapplication($@"{AddressBar.Text}\{Mainview.SelectedItems.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }

        private void driveToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {

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