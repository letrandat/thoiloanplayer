/*
 * Created by SharpDevelop.
 * Author: Dat - trandatnh@gmail.com
 * Date: 10/5/2014
 * Time: 10:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace thoiloanplayer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool triedLogin = false;
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
			if (textBox_user.Text == String.Empty || textBox_password.Text == String.Empty) {
				MessageBox.Show("Username or password is empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			wb.Navigate(@"http://id.thoiloan.vn/?sid=none&err=1&v=4");
			triedLogin = false;
		}
		void WbDocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
		{
			if (triedLogin != true) {
				wb.Document.GetElementById("username").SetAttribute("value", textBox_user.Text);
				wb.Document.GetElementById("password").SetAttribute("value", textBox_password.Text);
				HtmlElementCollection classButton = wb.Document.All;
				foreach (HtmlElement element in classButton) {
					if (element.GetAttribute("className") == "ChoiNgay") {
						element.InvokeMember("click");
					}
				}
				triedLogin = true;
			}
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
			KeepConnectionAlive();
		}
	}
}
