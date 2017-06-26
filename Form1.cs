using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace WebScrapingg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            string sourceCode = TekstStrony.GetSourceCode(url);
            StreamWriter sw = new StreamWriter("website.txt");
            sw.Write(sourceCode);
            sw.Close();
        }
    }

}
