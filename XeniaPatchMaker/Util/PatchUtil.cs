using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaPatchMaker.Util
{

    public static class PatchUtil
    {



        public static string GetTitle(string Placeholder, string Start, string End, int length)
        {
            try
            {
                int x = Placeholder.LastIndexOf(Start/*"Title ID:"*/) + Start.Length + 3;
                length = Placeholder.IndexOf(End/*"Savegame ID:"*/);
                string s = Placeholder.Substring(x, length);
                //////////////////////////////////////////////
                int xx = s.IndexOf("{}");
                string q = Placeholder.Substring(x, xx - 1);
                return q;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string GetMediaID(string Placeholder, string Start, string End, int length)
        {
            try
            {
                int x = Placeholder.LastIndexOf(Start/*"Title ID:"*/) + Start.Length + 1;
                length = Placeholder.IndexOf(End/*"Savegame ID:"*/) - x;
                string s = Placeholder.Substring(x, length);
                return string.Concat(s.Where(c => !char.IsWhiteSpace(c)));
            }
            catch
            { 
                return string.Empty;
            }
        }
        public static string GetTitleID(string Placeholder, string Start, string End, int length)
        {
            try
            {
                int x = Placeholder.LastIndexOf(Start) + Start.Length + 1;
                length = Placeholder.IndexOf(End) - x;
                string s = Placeholder.Substring(x, length);
                return string.Concat(s.Where(c => !char.IsWhiteSpace(c)));
            }
            catch
            {
                return string.Empty;
            }

        }
        public static string GetHashKey(string Placeholder, string Start, string End, int length)
        {
            try
            {
                int x = Placeholder.LastIndexOf(Start) + Start.Length + 1;
                length = Placeholder.IndexOf(End);
                string s = Placeholder.Substring(x - 1, 16);
                return string.Concat(s.Where(c => !char.IsWhiteSpace(c)));
            }
            catch
            {

                return string.Empty;
            }
        }

    }
}
