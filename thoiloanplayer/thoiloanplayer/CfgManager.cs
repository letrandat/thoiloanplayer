/*
 * Created by SharpDevelop.
 * Author: Dat - trandatnh@gmail.com
 * Date: 10/5/2014
 * Time: 12:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace thoiloanplayer
{
	/// <summary>
	/// Description of CfgManager.
	/// </summary>
	public class CfgManager
	{
		public CfgManager()
		{
		}
		public static void saveUser(string user, string pass)
		{
			using (var writer = new CsvFileWriter("user.csv")) {
				var row = new CsvRow();
				row.Add(String.Format(user));
				row.Add(String.Format(pass));
				writer.WriteRow(row);
			}
		}
		public static void loadUser(ref string user, ref string password)
		{
			if( ! File.Exists(@"user.csv") )
				return;
			using (var reader = new CsvFileReader("user.csv")) {
				var row = new CsvRow();
				if (reader.ReadRow(row)) {
					user = row[0];
					password = row[1];
				}
			}
		}
	}
}
