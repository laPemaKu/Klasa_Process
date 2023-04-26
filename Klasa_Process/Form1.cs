using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Klasa_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void btnStarInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }
    }
}
