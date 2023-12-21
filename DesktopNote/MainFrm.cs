using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNote
{
    public partial class MainFrm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        /// <summary>
        /// 系统上安装的字体
        /// </summary>
        InstalledFontCollection myFont = new InstalledFontCollection();

        public MainFrm()
        {
            InitializeComponent();

            //字体设置
            for (int i = 0; i < myFont.Families.Length; i++)
                tsmi_font.Items.Add(myFont.Families[i].Name);
            for (int i = 0; i < tsmi_font.Items.Count; i++)
            {
                if (richTextBox.Font.Name == (string)tsmi_font.Items[i])
                {
                    tsmi_font.SelectedIndex = i;
                    break;
                }
            }
        }

        private void tsmi_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ms_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void tsmi_topmost_Click(object sender, EventArgs e)
        {
            if (tsmi_topmost.Checked)
                TopMost = true;
            else
                TopMost = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            Activate();
        }

        private void tsmi_bold_Click(object sender, EventArgs e)
        {
            if (tsmi_bold.Checked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Bold);
                tsmi_bold.BackColor = Color.DeepSkyBlue;
            }
            else
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Regular);
        }

        private void tsmi_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(myFont.Families[tsmi_font.SelectedIndex], 9, FontStyle.Regular);
        }
    }
}
