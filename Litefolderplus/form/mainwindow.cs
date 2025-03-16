using Litefolderplus.csharp;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Litefolderplus
{

    public partial class MainWindow : Form
    {
        static string mem1;
        static string mem2;
        static string CombineAddr;
        static string Currentaddr;
        static string newaddr;
        static string title = "LiteFolderPlus";
        public MainWindow()
        {
            InitializeComponent();
            Gohome();
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

        private void Gohome()
        {
            int current = tabControl1.SelectedIndex;
            Currentaddr = "Home";
            newaddr = "";
            AddressBar.Text = "";
            Mainview.Items.Clear();
            Text = title;
            tabControl1.TabPages[current].Text = "Newtab";
            GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gohome();
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
                /*
                if (Mainview.SelectedItems.Count > 0 && Mainview.SelectedItems.Count < 2)
                {
                    newaddr = Mainview.SelectedItems[0].Text;
                    Currentaddr = AddressBar.Text;
                    
                    int af = tabControl1.SelectedIndex;

                    if (Root.IsDrive(newaddr) && Currentaddr == "")
                    {
                        AddressBar.Text = newaddr;
                        Text = $"{title} - {AddressBar.Text}";
                        tabControl1.TabPages[af].Text = newaddr;
                        GetDirctoryItems(newaddr);
                        GetFile(newaddr);
                    }
                    else if (AddressBar.Text == "Home")
                    {
                        
                    }
                    else
                    {
                        AddressBar.Text += $@"{newaddr}\";
                        Currentaddr = Path.Combine(Currentaddr, newaddr);
                        if (Directory.Exists(Currentaddr))
                        {
                            Text = $"{title} - {Currentaddr}";
                            tabControl1.TabPages[af].Text = Currentaddr;
                            GetDirctoryItems(Currentaddr);
                            GetFile(Currentaddr);
                        }
                        else if(File.Exists(Currentaddr))
                        {
                            mem1 = newaddr;
                            Openfile.openfileindefaultapplication(Currentaddr);
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
                */
                if (Mainview.SelectedItems.Count > 0 && Mainview.SelectedItems.Count < 2)
                {
                    newaddr = Mainview.SelectedItems[0].Text;
                    if (Root.IsDrive(newaddr) && Currentaddr == "Home")
                    {
                        Currentaddr = newaddr;
                        AddressBar.Text = newaddr;
                        Text = $@"{title} - {newaddr}";
                        GetDirctoryItems(newaddr);
                        GetFile(newaddr);
                    }
                    else
                    {
                        Currentaddr = Path.Combine(Currentaddr, newaddr);
                        switch (Exist.Survey(Currentaddr))
                        {
                            case 0:
                                Gohome();
                                break;
                            case 1:
                                AddressBar.Text = Currentaddr;
                                GetDirctoryItems(Currentaddr);
                                GetFile(Currentaddr);
                                break;
                            case 2:
                                Openfile.openfileindefaultapplication(Path.Combine(Currentaddr));
                                break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }

        private void openItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count == 1)
                {
                    if (Currentaddr == "")
                    {
                        Currentaddr = AddressBar.Text;
                        switch (Exist.Survey(AddressBar.Text)) {
                            case 1:
                                GetDirctoryItems(Path.Combine(Currentaddr, Mainview.SelectedItems[0].Text));
                                GetFile(Path.Combine(Currentaddr, Mainview.SelectedItems[0].Text));
                                break;
                            case 2:
                                Openfile.openfileindefaultapplication(Path.Combine(Currentaddr, Mainview.SelectedItems[0].Text));
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }

        private void driveToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void AddressBar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                switch (Exist.Survey(AddressBar.Text))
                {
                    case 0:
                        Gohome();
                        break;
                    case 1:
                        GetDirctoryItems(AddressBar.Text);
                        GetFile(AddressBar.Text);
                        break;
                    case 2:
                        Openfile.openfileindefaultapplication(AddressBar.Text);
                        break;
                }
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Currentaddr == "Home")
                {
                    Mainview.Items.Clear();
                    GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
                }
                else
                {
                    GetDirctoryItems(Currentaddr);
                    GetFile(Currentaddr);
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
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