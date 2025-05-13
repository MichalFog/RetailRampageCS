using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private readonly static string path = "Log";
        public static string GetPathDir()
        {
            return path + "/" + DateTime.Now.Month.ToString();
        }
        public static string GetPathFile()
        {
            return GetPathDir() + "/" + DateTime.Now.Day.ToString() + "txt";
        }

        public static void writeToLog(string projectName, string funcName, string messeage)
        {
            string dir = GetPathDir();
            string file = GetPathFile();
            if (!Directory.Exists(dir))
            {
                DirectoryInfo d = Directory.CreateDirectory(dir);
            }
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{messeage}");
            }
        }
        public static void ClearLog()
        {
            string[] dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                int monthBefore;
                string month = dirs[i].Substring(dirs[i].Length - 2);
                if (DateTime.Now.Month == 1)
                    monthBefore = 12;
                else
                    monthBefore = DateTime.Now.Month - 1;
                if (month != DateTime.Now.Month.ToString() && month != monthBefore.ToString())
                    Directory.Delete(dirs[i], true);
            }
        }
    }
}

