namespace Litefolderplus
{
    partial class mainwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressBar = new System.Windows.Forms.TextBox();
            this.Namecolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mainview = new System.Windows.Forms.ListView();
            this.basepanel = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.basepanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tabToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItToolStripMenuItem,
            this.showMoreToolStripMenuItem,
            this.goHomeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openItToolStripMenuItem
            // 
            this.openItToolStripMenuItem.Name = "openItToolStripMenuItem";
            this.openItToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openItToolStripMenuItem.Text = "Open it";
            // 
            // showMoreToolStripMenuItem
            // 
            this.showMoreToolStripMenuItem.Name = "showMoreToolStripMenuItem";
            this.showMoreToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showMoreToolStripMenuItem.Text = "Show more";
            // 
            // goHomeToolStripMenuItem
            // 
            this.goHomeToolStripMenuItem.Name = "goHomeToolStripMenuItem";
            this.goHomeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.goHomeToolStripMenuItem.Text = "Go home";
            this.goHomeToolStripMenuItem.Click += new System.EventHandler(this.goHomeToolStripMenuItem_Click);
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTabToolStripMenuItem,
            this.newTabToolStripMenuItem});
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.tabToolStripMenuItem.Text = "Tab";
            // 
            // deleteTabToolStripMenuItem
            // 
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteTabToolStripMenuItem.Text = "Delete tab";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newTabToolStripMenuItem.Text = "New tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.moveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBar.Location = new System.Drawing.Point(3, 3);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(750, 19);
            this.AddressBar.TabIndex = 1;
            this.AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.godir_KeyDown_1);
            // 
            // Namecolumn
            // 
            this.Namecolumn.Text = "Name";
            this.Namecolumn.Width = 389;
            // 
            // Size
            // 
            this.Size.Text = "size";
            this.Size.Width = 101;
            // 
            // filetype
            // 
            this.filetype.DisplayIndex = 3;
            this.filetype.Text = "filetype";
            this.filetype.Width = 116;
            // 
            // date
            // 
            this.date.DisplayIndex = 2;
            this.date.Text = "date";
            this.date.Width = 111;
            // 
            // Mainview
            // 
            this.Mainview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Mainview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namecolumn,
            this.Size,
            this.filetype,
            this.date});
            this.Mainview.ContextMenuStrip = this.contextMenuStrip1;
            this.Mainview.ForeColor = System.Drawing.Color.Black;
            this.Mainview.HideSelection = false;
            this.Mainview.Location = new System.Drawing.Point(3, 28);
            this.Mainview.Name = "Mainview";
            this.Mainview.Size = new System.Drawing.Size(750, 345);
            this.Mainview.TabIndex = 0;
            this.Mainview.UseCompatibleStateImageBehavior = false;
            this.Mainview.View = System.Windows.Forms.View.Details;
            this.Mainview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mainview_MouseDoubleClick_1);
            // 
            // basepanel
            // 
            this.basepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basepanel.Controls.Add(this.AddressBar);
            this.basepanel.Controls.Add(this.Mainview);
            this.basepanel.Location = new System.Drawing.Point(6, 6);
            this.basepanel.Name = "basepanel";
            this.basepanel.Size = new System.Drawing.Size(756, 373);
            this.basepanel.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.basepanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainwindow";
            this.Text = "LiteFolderPlus.net";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.basepanel.ResumeLayout(false);
            this.basepanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;

        #endregion
        private System.Windows.Forms.ToolStripMenuItem goHomeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.TextBox AddressBar;
        private System.Windows.Forms.ColumnHeader Namecolumn;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader filetype;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Panel basepanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.ListView Mainview;
    }
}