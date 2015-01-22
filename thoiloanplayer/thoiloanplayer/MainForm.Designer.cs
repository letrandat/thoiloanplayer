/*
 * Created by SharpDevelop.
 * Author: Dat - trandatnh@gmail.com
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
			this.button_F5 = new System.Windows.Forms.Button();
			this.pictureBox_hide = new System.Windows.Forms.PictureBox();
			this.button_play = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pictureBox_show = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).BeginInit();
			this.SuspendLayout();
			// 
			// wb
			// 
			this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wb.Location = new System.Drawing.Point(0, 0);
			this.wb.MinimumSize = new System.Drawing.Size(20, 20);
			this.wb.Name = "wb";
			this.wb.ScriptErrorsSuppressed = true;
			this.wb.Size = new System.Drawing.Size(1034, 701);
			this.wb.TabIndex = 0;
			this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WbDocumentCompleted);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 601);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1034, 100);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button_F5);
			this.tabPage1.Controls.Add(this.pictureBox_hide);
			this.tabPage1.Controls.Add(this.button_play);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1026, 74);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button_F5
			// 
			this.button_F5.Location = new System.Drawing.Point(87, 6);
			this.button_F5.Name = "button_F5";
			this.button_F5.Size = new System.Drawing.Size(75, 23);
			this.button_F5.TabIndex = 6;
			this.button_F5.Text = "F5";
			this.button_F5.UseVisualStyleBackColor = true;
			this.button_F5.Click += new System.EventHandler(this.Button_F5Click);
			// 
			// pictureBox_hide
			// 
			this.pictureBox_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox_hide.Image = global::thoiloanplayer.Resource.right;
			this.pictureBox_hide.Location = new System.Drawing.Point(990, 32);
			this.pictureBox_hide.Name = "pictureBox_hide";
			this.pictureBox_hide.Size = new System.Drawing.Size(31, 33);
			this.pictureBox_hide.TabIndex = 5;
			this.pictureBox_hide.TabStop = false;
			this.pictureBox_hide.Click += new System.EventHandler(this.PictureBox_hideClick);
			// 
			// button_play
			// 
			this.button_play.Location = new System.Drawing.Point(6, 6);
			this.button_play.Name = "button_play";
			this.button_play.Size = new System.Drawing.Size(75, 23);
			this.button_play.TabIndex = 3;
			this.button_play.Text = "Play";
			this.button_play.UseVisualStyleBackColor = true;
			this.button_play.Click += new System.EventHandler(this.Button_playClick);
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
			// pictureBox_show
			// 
			this.pictureBox_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox_show.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_show.Image = global::thoiloanplayer.Resource.left;
			this.pictureBox_show.Location = new System.Drawing.Point(982, 655);
			this.pictureBox_show.Name = "pictureBox_show";
			this.pictureBox_show.Size = new System.Drawing.Size(31, 33);
			this.pictureBox_show.TabIndex = 2;
			this.pictureBox_show.TabStop = false;
			this.pictureBox_show.Click += new System.EventHandler(this.PictureBox_showClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 701);
			this.Controls.Add(this.pictureBox_show);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.wb);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Player";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox pictureBox_show;
		private System.Windows.Forms.PictureBox pictureBox_hide;
		private System.Windows.Forms.Button button_play;
		private System.Windows.Forms.WebBrowser wb;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button_F5;
	}
}