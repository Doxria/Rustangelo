using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rustangelo
{
    public partial class Menu : Form
    {
		#region vars
		public static bool activ = false;
		public static bool minmax = false;
		public static bool test1 = false;

		public static int smooth = 1;
		public static double sense = 1.0;
		public static int fov = 90;

		public static string weapon;
		public static string attachment;
		public static string scope;

		#endregion
		public Menu()
        {
            InitializeComponent();
        }

		#region HeadUstPanel
		int Move;
		int Mouse_X;
		int Mouse_Y;


		private void HeadUstPanel_MouseUp(object sender, MouseEventArgs e)
		{
			Move = 0;
		}

		private void HeadUstPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Move = 1;
			Mouse_X = e.X;
			Mouse_Y = e.Y;
		}

		private void HeadUstPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (Move == 1)
			{
				this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
			}
		}
		#endregion

		#region HeadUstTitle
		private void HeaderTitleTxt_MouseUp(object sender, MouseEventArgs e)
        {
			Move = 0;
		}

        private void HeaderTitleTxt_MouseDown(object sender, MouseEventArgs e)
        {
			Move = 1;
			Mouse_X = e.X;
			Mouse_Y = e.Y;
		}

        private void HeaderTitleTxt_MouseMove(object sender, MouseEventArgs e)
        {
			if (Move == 1)
			{
				this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
			}
		}
        #endregion

        #region Header Text
        private void KapatTxtBtn_Click(object sender, EventArgs e)
        {
			Application.ExitThread();
			Environment.Exit(1); // Eğer Bunu kaldırısanız uygulama kapatılsa dahi recoil devam eder.
		}

        private void MinimizeTxtBtn_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
		}

        private void WebsiteTxtBtn_Click(object sender, EventArgs e)
        {
			Process.Start("https://dogacankoc.com");
		}

        #endregion

        #region Bool
        private void EtkinCBox_CheckedChanged(object sender, EventArgs e)
        {
			if (EtkinCBox.Checked)
			{
				activ = true;
			}
			else
			{
				activ = false;
			}
		}

        private void YumusaklikCBox_CheckedChanged(object sender, EventArgs e)
        {
			if (YumusaklikCBox.Checked)
			{
				test1 = true;
			}
			else
			{
				test1 = false;
			}
		}
        #endregion

        #region int

        private void YumusaklıkTBar_Scroll(object sender, EventArgs e)
        {
			smooth = YumusaklıkTBar.Value;
		}

        private void HassasiyetUpDown_ValueChanged(object sender, EventArgs e)
        {
			sense = Convert.ToDouble(HassasiyetUpDown.Value);
		}

        private void FovUpDown_ValueChanged(object sender, EventArgs e)
        {
			fov = Convert.ToInt32(FovUpDown.Value);
		}

		#endregion

		#region string
		private void SilahCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			weapon = (string)SilahCBox.SelectedItem;
		}

        private void EklentiCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			attachment = (string)EklentiCBox.SelectedItem;
		}

        private void DürbünCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			scope = (string)DürbünCBox.SelectedItem;
		}

        #endregion

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
			Environment.Exit(1);
		}
    }
}
