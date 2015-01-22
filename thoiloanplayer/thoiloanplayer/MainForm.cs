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
		System.Collections.Generic.Dictionary<string, string> Accounts;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pictureBox_show.Hide();
			EnableFullFramerateWhenInvisible();
			Button_LoadAccClick(null, null);
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
		void Button_playClick(object sender, EventArgs e)
		{
			string url = Accounts[comboBox_Acc.SelectedItem.ToString()];
			wb.Navigate(@url);
		}
		void WbDocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
		{
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
		void Button_F5Click(object sender, EventArgs e)
		{
			if (!wb.Url.Equals("about:blank")) {
				wb.Refresh();
			}
		}
		void Button_LoadAccClick(object sender, EventArgs e)
		{
			if (Accounts != null) {
				Accounts.Clear();
				comboBox_Acc.Items.Clear();
			}
			Accounts = new System.Collections.Generic.Dictionary<string, string>();
			var file = new System.IO.StreamReader(@"url.txt");
			string line;
			while ((line = file.ReadLine()) != null) {
				var account = line.Split(';');
				Accounts.Add(account[0], account[1]);
				comboBox_Acc.Items.Add(account[0]);
			}
			file.Close();
			comboBox_Acc.SelectedIndex = 0;
		}
	}
}
