using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static RichXml.Helpers.ColorHelper;
using static RichXml.Helpers.FileSystemHelper;

namespace RichXml.RichTextBoxLogic.Themes
{
    interface IColorsLoader
    {
        List<string> LoadColorSchemeNames();
        ColorScheme LoadColorSchemeByName(string name);
    }

    //for test
    class TColorsLoader : IColorsLoader
    {
        public List<string> LoadColorSchemeNames()
        {
            var result = new List<string>();
            result.Add("Name1");
            result.Add("Name2");
            result.Add("Name3");
            return result;
        }

        public ColorScheme LoadColorSchemeByName(string name)
        {
            var result = new ColorScheme();
            result.Color1 = FromHex("#FF0000");
            result.Color2 = FromHex("#00FF00");
            result.Color3 = FromHex("#0000FF");
            return result;
        }
    }

    class ColorsLoader : IColorsLoader
    {
        public List<string> LoadColorSchemeNames()
        {
            var arr = Directory.GetFiles(Dir("Colors"));
            var result =  arr.ToList();
            return result;
        }

        public ColorScheme LoadColorSchemeByName(string name)
        {
            //TODO - implement downloading themes from files
            throw new NotImplementedException();
        }
    }
}