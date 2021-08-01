using GitHubUpdate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaPatchMaker.Util
{

    public static class PatchUtil
    {
        /// <summary>
        /// Condition Checker
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(string s)
        {
            return (s == null || s == string.Empty) ? true : false;
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

        internal static void CheckUpdates()
        {
            UpdateChecker checker = new UpdateChecker("TeddyHammer", "XeniaPatchMaker");
            checker.CheckUpdate(locked: UpdateType.Patch).ContinueWith(continuation =>
            {
                if (continuation.Result != UpdateType.None)
                {
                    var result = new UpdateNotifyDialog(checker).ShowDialog();
                    
                    if (result == DialogResult.Yes)
                    {
                        checker.DownloadAsset("XeniaPatchMaker.exe");
                    }
                }
                else
                {
                    Loading_Screen.UpToDate = "Up to date!";
                }



            });
        }    
        /// <summary>
        /// Loads Patch Data Back To Textboxes
        /// </summary>
        /// <param name="Placeholder"></param>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ReloadData(string Placeholder, string Start, string End, int length)
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
        public static void CheckKeyword(string word, Color color, int startIndex)
        {
            string outsource = Program.MainForm.OutPut.Text;
            if (Program.MainForm.OutPut.Text.Contains(word))
            {
                int index = -1;
                int selectStart = Program.MainForm.OutPut.SelectionStart;

                while ((index = Program.MainForm.OutPut.Text.IndexOf(word, (index + 1))) != -1)
                {
                    Program.MainForm.OutPut.Select((index + startIndex), word.Length);
                    Program.MainForm.OutPut.SelectionColor = color;
                    Program.MainForm.OutPut.Select(selectStart, 0);
                    Program.MainForm.OutPut.SelectionColor = Color.White;
                }
            }
        }

    }
}
