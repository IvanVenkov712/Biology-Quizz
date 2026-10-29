using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biology_quizz
{
	public static class ImageFromFile
	{
        public static Image ReadFromFile(string path)
        {
			FileStream str = new FileStream(path, FileMode.Open, FileAccess.Read);
			Image res = Image.FromStream(str);
			str.Dispose();
			str.Close();
			return res;
        }
		public static void SaveToFile(Bitmap i, string path, ImageFormat f)
        {
			FileStream str = new FileStream(path, FileMode.Create, FileAccess.Write);
			try
			{
				i.Save(str, f);
			}
			catch (Exception) { }
			str.Dispose();
			str.Close();
		}
	}
}
