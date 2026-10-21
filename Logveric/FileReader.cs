using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Logveric
{
    static public class FileReader
    {
        public static void OpenFile()
        {
            var filePath = string.Empty;
            String line;
            long fileSize = 0;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|log files (*.log)|*.log|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                fileSize = stream.Length;
            }
            try
            {
                if (fileSize > 0)
                {
                    StreamReader sr = new StreamReader(filePath);
                    while (true)
                    {
                        line = sr.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (!string.IsNullOrEmpty(line))
                        {
                            Form1.MainGrid.Rows.Add(line);
                        }
                    }
                    sr.Close();

                }
                else
                {
                    MessageBox.Show("File is empty.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }
    }
}
