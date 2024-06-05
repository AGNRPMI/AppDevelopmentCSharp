using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar08
{
    internal class Reader
    {
        public static bool FindWord(string path, string word)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var tempStr = sr.ReadLine();
                    if (tempStr.Contains(word))
                    {
                        return true;
                    }
                }
                return false;
            }

        }

        public static void FindFiles(string path, string fileExtension, List<string> list)
        {
            list.AddRange(Directory.GetFiles(path, fileExtension));

            foreach (var dir in Directory.GetDirectories(path))
            {
                FindFiles(dir, fileExtension, list);
            }
        }
    }
}
