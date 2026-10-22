using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
namespace Logveric
{
    public partial class Form1 : Form
    {
        public static DataGridView MainGrid { get; private set; }
        public Form1()
        {
            InitializeComponent();
            MainGrid = dataGridView1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //dataGridView1.Columns.Add("Ad", "Ad");
            int colIndex = Form1.MainGrid.Columns.Add("sa", "sa");
            int rowIndex = Form1.MainGrid.Rows.Add();
            Form1.MainGrid.Rows[rowIndex].Cells[colIndex].Value = "0-0";
        }
        public void lbl_LogSize_Text(int LogValue)
        {
            lbl_LogSize.Text = $"Showing {LogValue}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileReader.OpenFile();
        }
    }
}
