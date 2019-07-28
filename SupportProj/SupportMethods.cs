using System.Drawing;
using System.IO;

namespace SupportProj
{
	public static class SupportMethods
	{
		public static byte[] ImageToByteArray(Bitmap imageIn)
		{
			using (var ms = new MemoryStream())
			{
				imageIn.Save(ms, imageIn.RawFormat);
				return ms.ToArray();
			}
		}
	}
}