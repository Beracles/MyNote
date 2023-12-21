namespace DesktopNote
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_topmost = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.tsddm_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_bold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_font = new System.Windows.Forms.ToolStripComboBox();
            this.ms_menu.SuspendLayout();
            this.cms_notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.Color.SpringGreen;
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_add,
            this.tsmi_close,
            this.tsmi_menu,
            this.tsmi_font,
            this.tsmi_bold});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(542, 29);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ms_menu_MouseDown);
            // 
            // tsmi_add
            // 
            this.tsmi_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmi_add.Image = global::DesktopNote.Properties.Resources.add;
            this.tsmi_add.Name = "tsmi_add";
            this.tsmi_add.Padding = new System.Windows.Forms.Padding(0);
            this.tsmi_add.Size = new System.Drawing.Size(20, 25);
            // 
            // tsmi_close
            // 
            this.tsmi_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_close.BackColor = System.Drawing.Color.Transparent;
            this.tsmi_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmi_close.Image = global::DesktopNote.Properties.Resources.close;
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Padding = new System.Windows.Forms.Padding(0);
            this.tsmi_close.Size = new System.Drawing.Size(20, 25);
            this.tsmi_close.Click += new System.EventHandler(this.tsmi_close_Click);
            // 
            // tsmi_menu
            // 
            this.tsmi_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmi_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddm_setting});
            this.tsmi_menu.Image = global::DesktopNote.Properties.Resources.menu;
            this.tsmi_menu.Name = "tsmi_menu";
            this.tsmi_menu.Padding = new System.Windows.Forms.Padding(0);
            this.tsmi_menu.Size = new System.Drawing.Size(20, 25);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cms_notify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cms_notify
            // 
            this.cms_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_topmost,
            this.tsmi_exit});
            this.cms_notify.Name = "cms_notify";
            this.cms_notify.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(100, 22);
            this.tsmi_exit.Text = "退出";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsmi_topmost
            // 
            this.tsmi_topmost.CheckOnClick = true;
            this.tsmi_topmost.Name = "tsmi_topmost";
            this.tsmi_topmost.Size = new System.Drawing.Size(100, 22);
            this.tsmi_topmost.Text = "置顶";
            this.tsmi_topmost.Click += new System.EventHandler(this.tsmi_topmost_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox.Location = new System.Drawing.Point(0, 29);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(542, 421);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // tsddm_setting
            // 
            this.tsddm_setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddm_setting.Name = "tsddm_setting";
            this.tsddm_setting.Size = new System.Drawing.Size(180, 22);
            this.tsddm_setting.Text = "设置";
            // 
            // tsmi_bold
            // 
            this.tsmi_bold.BackColor = System.Drawing.Color.SpringGreen;
            this.tsmi_bold.CheckOnClick = true;
            this.tsmi_bold.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmi_bold.Name = "tsmi_bold";
            this.tsmi_bold.Size = new System.Drawing.Size(28, 25);
            this.tsmi_bold.Text = "B";
            this.tsmi_bold.Click += new System.EventHandler(this.tsmi_bold_Click);
            // 
            // tsmi_font
            // 
            this.tsmi_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsmi_font.Name = "tsmi_font";
            this.tsmi_font.Size = new System.Drawing.Size(121, 25);
            this.tsmi_font.SelectedIndexChanged += new System.EventHandler(this.tsmi_font_SelectedIndexChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.ms_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.ms_menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.cms_notify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_add;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cms_notify;
        private System.Windows.Forms.ToolStripMenuItem tsmi_topmost;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem tsddm_setting;
        private System.Windows.Forms.ToolStripMenuItem tsmi_bold;
        private System.Windows.Forms.ToolStripComboBox tsmi_font;
    }
}

