/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 10/5/2014
 * Time: 10:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thoiloanplayer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.wb = new System.Windows.Forms.WebBrowser();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button_play = new System.Windows.Forms.Button();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.textBox_user = new System.Windows.Forms.TextBox();
			this.label_user = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// wb
			// 
			this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wb.Location = new System.Drawing.Point(0, 0);
			this.wb.MinimumSize = new System.Drawing.Size(20, 20);
			this.wb.Name = "wb";
			this.wb.ScriptErrorsSuppressed = true;
			this.wb.Size = new System.Drawing.Size(1034, 702);
			this.wb.TabIndex = 0;
			this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WbDocumentCompleted);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 602);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1034, 100);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button_play);
			this.tabPage1.Controls.Add(this.textBox_password);
			this.tabPage1.Controls.Add(this.textBox_user);
			this.tabPage1.Controls.Add(this.label_user);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1026, 74);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button_play
			// 
			this.button_play.Location = new System.Drawing.Point(263, 3);
			this.button_play.Name = "button_play";
			this.button_play.Size = new System.Drawing.Size(75, 23);
			this.button_play.TabIndex = 3;
			this.button_play.Text = "Play";
			this.button_play.UseVisualStyleBackColor = true;
			this.button_play.Click += new System.EventHandler(this.Button_playClick);
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(157, 5);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.PasswordChar = '*';
			this.textBox_password.Size = new System.Drawing.Size(100, 20);
			this.textBox_password.TabIndex = 2;
			// 
			// textBox_user
			// 
			this.textBox_user.Location = new System.Drawing.Point(51, 5);
			this.textBox_user.Name = "textBox_user";
			this.textBox_user.Size = new System.Drawing.Size(100, 20);
			this.textBox_user.TabIndex = 1;
			// 
			// label_user
			// 
			this.label_user.Location = new System.Drawing.Point(8, 8);
			this.label_user.Name = "label_user";
			this.label_user.Size = new System.Drawing.Size(100, 23);
			this.label_user.TabIndex = 0;
			this.label_user.Text = "User";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1026, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 702);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.wb);
			this.Name = "MainForm";
			this.Text = "Thời Loạn";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_play;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.TextBox textBox_user;
		private System.Windows.Forms.Label label_user;
		private System.Windows.Forms.WebBrowser wb;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}