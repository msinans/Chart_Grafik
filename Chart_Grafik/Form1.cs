using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Marmara", 17);
            chart1.Series["Kitap"].Points.AddXY("Ege", 13);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 77);
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 99);
            chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu", 13);
        }
    }
}
