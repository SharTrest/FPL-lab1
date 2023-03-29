using Microsoft.Office.Interop.Excel;
using System;
using System.Diagnostics;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;


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

            System.Windows.Forms.Application.Run(new Form1());
        }

    }



    public class Lab1
    {
        public string path;
        public string[] codeNamesTxt(string[] code)
        {
            using (FileStream fileRead = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader stream = new StreamReader(fileRead, Encoding.Default))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        int lengthstr = line.Length;
                        int sym = line[0];
                        int ii = 4;
                        code[sym - 1072] = null;
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

        public string[] codeNamesXLS(string[] code)
        {
            int k = 0;
            Excel.Range Rng;
            Excel.Workbook xlWB;
            Excel.Worksheet xlSht;
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            System.Diagnostics.Process excelProc = System.Diagnostics.Process.GetProcessesByName("EXCEL").Last();
            xlWB = ex.Workbooks.Open(this.path);
            xlSht = xlWB.ActiveSheet;

                for (int j = 1; j <= 32; j++)
                {
                    Excel.Range forYach = xlSht.Cells[j, 2] as Excel.Range;
                    try
                    {
                        string yach = forYach.Value2.ToString();
                        code[k] = yach;
                    }
                    catch { }
                    
                    k++;
                }


            ex.Quit();
            xlWB = null;
            xlSht = null;
            Rng = null;
            ex = null;
            CloseProcess();


            return code;
        }

        public string decoding(string text, string[] code)
        {
            int i = 0;
            int length = text.Length;
            char ch;
            string result = null;

            try
            {
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
            catch
            {
                MessageBox.Show("Отсутствует код в классификаторе!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return " ";
            }
                
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

        public void CloseProcess()
        {
            Process[] List;
            List = Process.GetProcessesByName("EXCEL");
            foreach (Process proc in List)
            {
                proc.Kill();

            }
        }

    }

}
