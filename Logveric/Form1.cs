using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace Logveric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void importLogs()
        {

        }
        public void lbl_LogSize_Text(int LogValue)
        {
            lbl_LogSize.Text = $"Showing {LogValue}";
        }

    }
}
