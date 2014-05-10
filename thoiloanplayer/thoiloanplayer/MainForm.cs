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

namespace thoiloanplayer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			loadUser();
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
		
		bool triedLogin = false;
	}
}
