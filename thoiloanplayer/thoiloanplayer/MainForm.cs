/*
 * Created by SharpDevelop.
 * Author: Dat - trandatnh@gmail.com
 * Date: 10/5/2014
 * Time: 10:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace thoiloanplayer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		IntPtr gameHandle = IntPtr.Zero;
		FormController fc = new FormController();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			loadUser();
			pictureBox_show.Hide();
			checkBox_keepOnline.Enabled = false;
			EnableFullFramerateWhenInvisible();
		}
		void EnableFullFramerateWhenInvisible()
		{
			string system32 = Environment.GetEnvironmentVariable("windir") + @"\System32\Macromed\Flash";
			string mms_cfg = "FullFramerateWhenInvisible = 1";
			if (Directory.Exists(system32)) {
				if (!File.Exists(system32 + @"\mms.cfg")) {
					var file = new System.IO.StreamWriter(system32 + @"\mms.cfg");
					file.Write(mms_cfg);
					file.Close();
				}
			}
			string wow64 = Environment.GetEnvironmentVariable("windir") + @"\SysWOW64\Macromed\Flash";
			if (Directory.Exists(wow64)) {
				if (!File.Exists(wow64 + @"\mms.cfg")) {
					var file = new System.IO.StreamWriter(wow64 + @"\mms.cfg");
					file.Write(mms_cfg);
					file.Close();
				}
			}
		}
		void loadUser()
		{
			string user = "";
			string password = "";
			CfgManager.loadUser(ref user, ref password);
			if (user != String.Empty && password != String.Empty) {
				textBox_user.Text = user;
				textBox_password.Text = password;
			}
		}
		void Button_playClick(object sender, EventArgs e)
		{
			wb.Navigate(@"http://sg31.vcmedia.vn/ver1.5.1/dos_vn4.swf?v=0506&uid=48876&sid=5&token=73076896c94fa95985216060d9ab8450");
			checkBox_keepOnline.Enabled = true;
			button_play.Enabled = false;
		}
		void WbDocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
		{
		}
		void CheckBox_saveClick(object sender, System.EventArgs e)
		{
			if (textBox_user.Text == String.Empty || textBox_password.Text == String.Empty) {
				checkBox_save.Checked = false;
				MessageBox.Show("Username or password's empty?!", "Error", MessageBoxButtons.OK);
				return;
			}
			CfgManager.saveUser(textBox_user.Text, textBox_password.Text);
		}
		void PictureBox_hideClick(object sender, System.EventArgs e)
		{
			tabControl1.Hide();
			pictureBox_show.Show();
		}
		void PictureBox_showClick(object sender, System.EventArgs e)
		{
			tabControl1.Show();
			pictureBox_show.Hide();
		}
		void KeepConnectionAlive()
		{
			if (gameHandle == IntPtr.Zero) {
				gameHandle = fc.GetGameHandle(wb.Handle);
			}
			Mouse.click(gameHandle, fc.achievement);
		}
		void CheckBox_keepOnlineClick(object sender, System.EventArgs e)
		{
			timer_keepOnline.Interval = (int)numericUpDown_keepOnline.Value * 60 * 1000;
			if (checkBox_keepOnline.Checked)
				timer_keepOnline.Start();
			else
				timer_keepOnline.Stop();
		}
		void Timer_keepOnlineTick(object sender, System.EventArgs e)
		{
			if (!FormController.IsActive(this.Handle)) {
				Debug.WriteLine("Form is not active, keep online");
				KeepConnectionAlive();
			}
		}
	}
}
