using System;
using System.Text;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Path());
        }
    }
    public class Lab1
    {
        public string path;
        public string[] codeNames(string pathCode, string[] code)
        {
            using (FileStream fileRead = new FileStream(pathCode, FileMode.OpenOrCreate))
            {
                using (StreamReader stream = new StreamReader(fileRead, Encoding.Default))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        int lengthstr = line.Length;
                        int sym = line[0];
                        int ii = 4;
                        while (ii < lengthstr)
                        {
                            code[sym - 1072] += line[ii].ToString();
                            ii++;
                        }
                    }
                }
            };
            return code;
        }

        public string decoding(string text, string[] code)
        {
            int i = 0;
            int length = text.Length;
            char ch;
            string result = null;

            while (i < length)
            {
                string decode = null;
                while (i < length && (ch = text[i]) != ' ')
                {
                    decode += ch.ToString();
                    i++;
                }
                int j = 0;
                while (decode != code[j])
                {
                    j++;
                }
                j += 1072;
                result += (char)j;
                i++;
            }
            return result;
        }

        public string coding(string text, string[] code)
        {
            int i = 0;
            int length = text.Length;
            char ch;
            string result = null;
            while (i < length) 
            {
                int sym = text[i];

                result += code[sym-1072];
                result += " ";
                i++;
            }
            return result;
        }


        }

}
