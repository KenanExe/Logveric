using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Logveric
{
    static public class FileReader
    {
        public static long fileRealSize { get; set; }
        public static void OpenFile()
        {
            var filePath = string.Empty;
            String line;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Desktop\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|log files (*.log)|*.log|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
                fileRealSize = new FileInfo(filePath).Length;
            }
            try
            {
                if (fileRealSize > 0)
                {
                    Form1.MainGrid.Rows.Clear();
                    Form1.MainGrid.Columns.Clear();
                    string nowColumns = null;
                    int colIndex = 0;
                    int rowIndex = 0;
                    bool canBeColumn = false;
                    StreamReader sr = new StreamReader(filePath);
                    FileReader.fileRealSize = new System.IO.FileInfo(filePath).Length;

                    while (true)
                    {
                        line = sr.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (!string.IsNullOrEmpty(line))
                        {
                            if (line.StartsWith("[") && line.EndsWith("]"))
                            {
                                    string trimedColum = line.Trim('[', ']');
                                    nowColumns = trimedColum;
                                    colIndex = Form1.MainGrid.Columns.Add(trimedColum, trimedColum);
                                    rowIndex = 0;
                                canBeColumn = true;
                                continue;
                                
                            }
                            else if (line.StartsWith("(") && line.EndsWith(")")){
                                string trimedColum = line.Trim('(', ')');
                                nowColumns = trimedColum;
                                colIndex = Form1.MainGrid.Columns.Add(trimedColum, trimedColum);
                                rowIndex = 0;
                                canBeColumn = true;
                                continue;
                            }
                            else
                            {
                                if (nowColumns == null)
                                {
                                    colIndex = Form1.MainGrid.Columns.Add("", "");
                                    nowColumns = "";
                                }
                            }
                            if (rowIndex >= Form1.MainGrid.Rows.Count)
                            {
                                Form1.MainGrid.Rows.Add();
                            }
                            Form1.MainGrid.Rows[rowIndex].Cells[colIndex].Value = line;
                            rowIndex++;

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
