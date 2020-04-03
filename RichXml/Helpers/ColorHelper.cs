using System;
using System.Globalization;
using System.Windows.Media;

namespace RichXml.Helpers
{
    static class ColorHelper
    {
        public static Color FromHex(string hexString)
        {
            if (hexString.IndexOf('#') != -1)
                hexString = hexString.Replace("#", "");

            byte r = byte.Parse(hexString.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            byte g = byte.Parse(hexString.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            byte b = byte.Parse(hexString.Substring(4, 2), NumberStyles.AllowHexSpecifier);

            return Color.FromRgb(r, g, b);
        }
    }
}