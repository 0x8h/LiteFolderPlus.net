﻿using Litefolderplus.csharp;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Litefolderplus
{

    public partial class MainWindow : Form
    {
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

        private void ChangeAddressBar(string str)
        {
            AddressBar.Text = "";
            AddressBar.Text = str;
        }

        private void Gohome()
        {
            int current = tabControl1.SelectedIndex;
            HistoryManager.MoveTo("Home");
            Currentaddr = "Home";
            newaddr = "";
            AddressBar.Text = "";
            Mainview.Items.Clear();
            Text = title;
            tabControl1.TabPages[current].Text = "Newtab";
            GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
        }

        private void UpdatePathUi(string nPath)
        {
            AddressBar.Text = (nPath == "Home" ? "" : nPath);
            Mainview.Items.Clear();
            if (nPath == "Home")
            {
                GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
            }
            else
            {
                GetDirctoryItems(nPath);
                GetFile(nPath);
            }
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gohome();
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e) //soon tm
        {
            throw new System.NotImplementedException();
            /*
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
            */
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RightClickMenuFunc.Copy(Mainview, AddressBar);
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
            /*
            TabPage tab = new TabPage();
            tab.Name = "Newtab" + Gettabnum.Get(tabControl1);
            tab.Text = "Newtab";
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            Panel panel = new Panel();
            panel.Controls.AddRange(basepanel.Controls.Cast<Control>().ToArray());
            tab.Controls.Add(panel);
            */
        }

        private void Mainview_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (Mainview.SelectedItems.Count > 0 && Mainview.SelectedItems.Count < 2)
                {
                    newaddr = Mainview.SelectedItems[0].Text;
                    if (Root.IsDrive(newaddr) && Currentaddr == "Home")
                    {
                        Currentaddr = newaddr;
                        AddressBar.Text = newaddr;
                        HistoryManager.MoveTo(newaddr);
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
                                HistoryManager.MoveTo(Currentaddr);
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
            throw new System.NotImplementedException();
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
                        HistoryManager.MoveTo(AddressBar.Text);
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

        private void Clear()
        {
            Mainview.Items.Clear();
            AddressBar.Clear();
        }
        
        private void forwardToolStripMenuItem_Click(object sender, EventArgs e) //forward
        {
            Currentaddr = HistoryManager.Forward();
            if (Currentaddr == "Home")
            {
                Clear();
                GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
            }
            else
            {
                ChangeAddressBar(Currentaddr);
                GetDirctoryItems(Currentaddr);
                GetFile(Currentaddr);
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e) //back
        {
            try
            {
                Currentaddr = HistoryManager.Back();
                if (Currentaddr == "Home")
                {
                    Clear();
                    GetDriveLetter.Get(Mainview, driveToolStripMenuItem);
                }
                else
                {
                    ChangeAddressBar(Currentaddr);
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
}