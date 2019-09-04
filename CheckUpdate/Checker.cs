using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CheckUpdate
{
    public partial class Checker : Form
    {
        string PathToView = @"Application Files";
        string FolderName = "DebugAssistant_";
        string ExeFileName = "DebugAssistant.exe";
        string version = "0.0.0.0";
        public Checker() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarValue(0);
            CheckFolder();
            progressBarValue(20);
            version = CheckVersion();
            progressBarValue(40);
            label_version.Text = version;
            label_version.Visible = true;
            progressBarValue(60);
            timer1.Interval = 300;
            timer1.Enabled = true;
            timer1.Start();
            //OpenOrCreateXML();
        }

        private void progressBarValue(int i) => progressBar1.Value = i;

        private string CheckVersionFolder()
        {
            string path = PathToView + '\\' + FolderName + version;
            if (Directory.Exists(path))          
                return path + '\\' + ExeFileName;    
            return null;
        }

        private bool try_process(string file)
        {
            try
            {
                Process.Start(file);
                return true;
            }
            catch
            {
                MessageBox.Show("File not found\n" + file, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string CheckVersion()
        {
            var List = GetAvailableFolder();
            string buf_1;
            string LastVersion = "0.0.0.0";
            foreach (string a in List)
            {
                buf_1 = a.Substring(FolderName.Length, a.Length - FolderName.Length);
                LastVersion = CompareVersions(buf_1, LastVersion);
            }
            return LastVersion;
        }

        private string CompareVersions(string buf, string LastVersion)
        {
            string Separator = ".";
            List<int> BufIndexes = IndexList(buf,Separator);
            List<int> LastVIndexes = IndexList(LastVersion, Separator);
            if (BufIndexes.Capacity == LastVIndexes.Capacity)
            {
                int[] BufNumVersion = GetValueArrayFromList(BufIndexes, buf);
                int[] VerNumVersion = GetValueArrayFromList(LastVIndexes, LastVersion);
                for(int i = 0; i < BufNumVersion.Length; i++)
                {
                    if(BufNumVersion[i] > VerNumVersion[i])
                    {
                        LastVersion = buf;
                        break;
                    }
                }
            }
            return LastVersion;
        }

        private int[] GetValueArrayFromList(List<int> list, string buf)
        {
            int[] Array = new int[list.Capacity];
            int i = 0, j = 0;
            foreach (int index in list)
            {
                string _buf = buf.Substring(i, index - i);
                try
                {
                    Array[j] = Convert.ToInt32(_buf);
                }
                catch
                {
                    ;
                }
                i = index + 1;
                j++;                    
            }
            return Array;
        }

        private List<int> IndexList(string buf, string Separator)
        {
            List<int> BufIndexes = new List<int>();
            for (int index = 0; ; index += Separator.Length)
            {
                index = buf.IndexOf(Separator, index);
                if (index == -1)
                    break;
                BufIndexes.Add(index);
            }
            BufIndexes.Add(buf.Length);
            return BufIndexes;
        }

        private List<string> GetAvailableFolder()
        {
            string[] dirs = Directory.GetDirectories(PathToView);
            List<string> AvailableFolderList = new List<string>();
            foreach (string s in dirs)
            {
                int index = s.IndexOf(FolderName);
                if (index > -1)
                    AvailableFolderList.Add(s.Substring(index, s.Length - index));
            }
            return AvailableFolderList;
        }

        private bool CheckFolder()
        {
            if (!Directory.Exists(PathToView))
                Directory.CreateDirectory(PathToView);        
            return true;
        }

        private void OpenOrCreateXML()
        {
            string fileName = "Updater.xml";
            if (File.Exists(fileName))  // open
            {
                OpenXML(fileName);
            }
            else  // create
            {

            }
        }

        private void OpenXML(string fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                
            }
        }

        private void CloseButt_Click(object sender, EventArgs e) => Application.Exit();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            string fullpath = CheckVersionFolder();
            progressBarValue(80);
            if (!String.IsNullOrEmpty(fullpath))
                if (try_process(fullpath))
                {
                    progressBarValue(100);
                    Application.Exit();
                }
                else {}
            else
                label_version.Text = "0.0.0.0";
            progressBar1.MarqueeAnimationSpeed = 100;
            Label_checkVersion.Location = new Point(9, 14);
            Label_checkVersion.Text = "Error: please send the email";
            EmailLabel.Text = "to: Nazarii_Romanchenko@jabil.com";
        }

    }
}
