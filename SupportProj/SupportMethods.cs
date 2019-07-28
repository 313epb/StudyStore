using System.Drawing;
using System.IO;

namespace SupportProj
{
	public static class SupportMethods
	{
		public static byte[] GetImage(string path)
		{
			var img = (Bitmap) Image.FromFile(path);
			return ImageToByteArray(img);
		}

		public static byte[] ImageToByteArray(Bitmap img)
		{
			using (var ms = new MemoryStream())
			{
				img.Save(ms, img.RawFormat);
				return ms.ToArray();
			}
		}

		public static Bitmap ByteArraytoImage(byte[] img)
		{
			using (var ms= new MemoryStream(img))
			{
				return new Bitmap(ms);
			}
		}
	}
}