using ParserFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{
    public partial class ParserForm : Form
    {
        DlgFiles[] firstDlg, secondDlg;
        public ParserForm()
        {
            InitializeComponent();
        }

        static void ProgrParser(string file1, string file2, string file3)
        {
            Encoding win1251, utf8;
            win1251 = Encoding.GetEncoding("windows-1251");

            String[] FirstFileLines = File.ReadAllLines(file1, win1251);
            String[] SecondFileLines = File.ReadAllLines(file2, win1251);

            int counts = 0;

            for (int i = 0; i < FirstFileLines.Length; i++)
            {
                if (FirstFileLines[i].Contains("localString"))
                {
                    counts++;
                }
            }

            Part[] First = new Part[counts];

            Regex TheRegex = new Regex("[а-яА-Я]");

            utf8 = Encoding.UTF8;

            int jips = 0;

            for (int i = 0; i < FirstFileLines.Length; i++)
            {
                if (FirstFileLines[i].Contains("localString"))
                {
                    byte[] isoBytesFirst = win1251.GetBytes(FirstFileLines[i]);
                    byte[] utfBytesFirst = Encoding.Convert(win1251, utf8, isoBytesFirst);
                    string msgFirst = utf8.GetString(utfBytesFirst);

                    First[jips] = new Part();
                    First[jips].name = msgFirst;
                    First[jips].id = i;
                    jips++;

                    if (TheRegex.IsMatch(msgFirst))
                    {
                        FirstFileLines[i] = msgFirst;
                    }

                }
            }

            jips = 0;

            for (int i = 0; i < SecondFileLines.Length; i++)
            {
                if (SecondFileLines[i].Contains("localString"))
                {

                    byte[] isoBytesSecond = win1251.GetBytes(SecondFileLines[i]);
                    byte[] utfBytesSecond = Encoding.Convert(win1251, utf8, isoBytesSecond);
                    string msgSecond = utf8.GetString(utfBytesSecond);

                    if (TheRegex.IsMatch(msgSecond))
                    {

                        FirstFileLines[First[jips].id] = msgSecond;

                    }
                    jips++;
                }
            }

            Encoding encoding = Encoding.GetEncoding("windows-1251");
            File.WriteAllLines(file3, FirstFileLines, encoding);
        }

        public void OpenFileMode(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            (sender as TextBox).Text = openFileDialog1.FileName;
        }

        public void OpenFolder(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            (sender as TextBox).Text = folderBrowserDialog1.SelectedPath;
        }

        static void ExecuteCommand(string command)
        {

            // ProcessStartInfo processInfo;
            Process process = new Process {
                StartInfo = {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    WorkingDirectory = Environment.CurrentDirectory,
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    RedirectStandardError = false,
                    RedirectStandardOutput = false
                }
            };
            process.Start();

            // processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            // //processInfo.WorkingDirectory = @"" + Environment.CurrentDirectory;
            // processInfo.CreateNoWindow = false;
            // processInfo.UseShellExecute = false;
            // // *** Redirect the output ***
            // processInfo.RedirectStandardError = true;
            // processInfo.RedirectStandardOutput = true;

            // process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            //string output = process.StandardOutput.ReadToEnd();
            //string error = process.StandardError.ReadToEnd();

            //exitCode = process.ExitCode;

            //Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            //Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            //Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();
        }

        DlgFiles[] GetFileNames(string paht, string razshir) {

            string[] dlgMassive = Directory.GetFiles(paht, razshir);
            DlgFiles[] dlgFile = new DlgFiles[dlgMassive.Count()];

            for (int i = 0; i < dlgMassive.Count(); i++)
            {
                dlgFile[i] = new DlgFiles();
                dlgFile[i].path = dlgMassive[i];
                int newIndex = dlgMassive[i].Split('\\').Count() - 1;
                dlgFile[i].name = dlgMassive[i].Split('\\')[newIndex];
            }
            return dlgFile;
        }

        void AddListGlg(DlgFiles[] dlg) {

            for (int i = 0; i < dlg.Count(); i++)
                checkedListDlg.Items.Add(dlg[i].name);

        }

        int FindMassiveElement(DlgFiles[] mas, string serchElement) {
            for (int i = 0; i < mas.Count(); i++)
            {
                if(mas[i].name==serchElement)
                    return i;

            } 
            return -1;
        }

        static void CopyDerictory(string sourcePath, string targetPath)
        {
            string fileName, destFile;

            System.IO.Directory.CreateDirectory(targetPath);

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textFirstFile.Text == "")
            {
                MessageBox.Show("Укажите 1ый файл исправляемого .MOD");
                return;
            }

            if (textSecondFile.Text == "")
            {
                MessageBox.Show("Укажите 2ый файл на основе которого будут внесены исправления .MOD");
                return;
            }

            if (textSecondFile.Text == textFirstFile.Text)
            {
                MessageBox.Show("Выбирите разные файлы .MOD");
                return;
            }

            string directory = Environment.CurrentDirectory.Substring(0, 2);
            // Environment.CurrentDirectory;
            //ExecuteCommand("set PATH=%PATH%;" + Environment.CurrentDirectory);
            ExecuteCommand(" @java -cp .\\nwn-tools.jar org.progeeks.nwn.ModToXml \"" + textFirstFile.Text + "\" .\\TEMP\\firstMode");
            ExecuteCommand(" @java -cp .\\nwn-tools.jar org.progeeks.nwn.ModToXml \"" + textSecondFile.Text + "\" .\\TEMP\\secondMode");

            firstDlg = GetFileNames(".\\TEMP\\firstMode", "*.dlg.xml");
            AddListGlg(firstDlg);
            secondDlg = GetFileNames(".\\TEMP\\secondMode", "*.dlg.xml");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListDlg.CheckedItems.Count == 0) {
                MessageBox.Show("Выберите файлы для преобразования");
                return;
            }

            if (textFinalDistan.Text == "")
            {
                MessageBox.Show("Укажите путь упаковки");
                return;
            }

            if (fileName.Text == "")
            {
                MessageBox.Show("Укажите имя файла .MOD");
                return;
            }

            string t = textFinalDistan.Text;
            CopyDerictory(".\\TEMP\\firstMode", ".\\TEMP\\EndMode");

            for (int i = 0; i < checkedListDlg.Items.Count; i++)
            {
                if (checkedListDlg.GetItemChecked(i))
                {
                    string chekItems = checkedListDlg.Items[i].ToString();
                    string finalname = ".\\TEMP\\EndMode\\" + chekItems;
                    int fir = FindMassiveElement(firstDlg, chekItems);
                    int sec = FindMassiveElement(secondDlg, chekItems);
                    ProgrParser(firstDlg[fir].path, secondDlg[sec].path, finalname);

                }
            }

            ExecuteCommand(" @java -cp .\\nwn-tools.jar org.progeeks.nwn.XmlToGff .\\TEMP\\GffFiles .\\TEMP\\EndMode/*");
            ExecuteCommand(" @java -cp .\\nwn-tools.jar org.progeeks.nwn.ModPacker .\\TEMP\\GffFiles "+ textFinalDistan.Text +"\\"+fileName.Text+".mod");

        }

    }

}
