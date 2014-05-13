/*
 * Created by SharpDevelop.
 * Author: Dat - trandatnh@gmail.com
 * Date: 11/5/2014
 * Time: 16:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing;

namespace thoiloanplayer
{
	/// <summary>
	/// Description of FormController.
	/// </summary>
	public class FormController
	{
		public Point chatboxSend = new Point(251, 683);
		public Point chatboxZoom = new Point(296, 684);
		public Point achievement = new Point(41, 152);
		public Point attack = new Point(887, 586);
		public Point raid = new Point(669, 561);
		public Point endRaid = new Point(506, 21);
		
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();
		
		public FormController()
		{
		}
		private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);
 
		[DllImport("user32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr lParam);
 
		List<IntPtr> GetAllChildHandles(IntPtr handle)
		{
			var childHandles = new List<IntPtr>();
 
			GCHandle gcChildhandlesList = GCHandle.Alloc(childHandles);
			IntPtr pointerChildHandlesList = GCHandle.ToIntPtr(gcChildhandlesList);
 
			try {
				var childProc = new EnumWindowProc(EnumWindow);
				EnumChildWindows(handle, childProc, pointerChildHandlesList);
			} finally {
				gcChildhandlesList.Free();
			}
 
			return childHandles;
		}
 
		bool EnumWindow(IntPtr hWnd, IntPtr lParam)
		{
			GCHandle gcChildhandlesList = GCHandle.FromIntPtr(lParam);
 
			if (gcChildhandlesList == null || gcChildhandlesList.Target == null) {
				return false;
			}
 
			var childHandles = gcChildhandlesList.Target as List<IntPtr>;
			childHandles.Add(hWnd);
 
			return true;
		}
		
		public IntPtr GetGameHandle(IntPtr wbHandle)
		{
			var children = GetAllChildHandles(wbHandle);
			return children[children.Count - 1];
		}
		
		public static bool IsActive(IntPtr handle)
		{
			return handle == GetForegroundWindow();
		}
	}
}
