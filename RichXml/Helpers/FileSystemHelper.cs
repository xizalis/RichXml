using System;
using System.IO;

namespace RichXml.Helpers
{
    static class FileSystemHelper
    {
        private static string BaseDir()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var dir = Path.GetDirectoryName(path);
            return dir;
        }

        public static string Dir(string name)
        {
            var dir = Path.Combine(BaseDir(), name);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return dir;
        }
    }
}