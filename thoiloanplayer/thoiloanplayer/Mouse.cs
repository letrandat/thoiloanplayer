/*
 * Created by SharpDevelop.
 * Author: Dat - trandatnh@gmail.com
 * Date: 11/5/2014
 * Time: 16:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace thoiloanplayer
{
	/// <summary>
	/// Description of Mouse.
	/// </summary>
	public class Mouse
	{
		const int WM_LBUTTONDOWN = 0x201;
		const int WM_LBUTTONUP = 0x202;
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
		
		public Mouse()
		{
		}
		public static void click(IntPtr hWnd, int x, int y)
		{
			SendMessage(hWnd, WM_LBUTTONDOWN, (IntPtr)1, (IntPtr)((y << 0x10) | x));
			SendMessage(hWnd, WM_LBUTTONUP, (IntPtr)0, (IntPtr)((y << 0x10) | x));
		}
		public static void click(IntPtr hWnd, Point p)
		{
			SendMessage(hWnd, WM_LBUTTONDOWN, (IntPtr)1, (IntPtr)((p.Y << 0x10) | p.X));
			SendMessage(hWnd, WM_LBUTTONUP, (IntPtr)0, (IntPtr)((p.Y << 0x10) | p.X));
		}
	}
}
