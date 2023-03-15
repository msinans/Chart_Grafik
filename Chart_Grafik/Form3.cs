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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         /* chart1.Series["Otomobil"].Points.AddXY("BMW", 250);
            chart1.Series["Otomobil"].Points.AddXY("Mercedes", 240);
            chart1.Series["Otomobil"].Points.AddXY("Ami", 40);
            chart1.Series["Otomobil"].Points.AddXY("Porsche", 300);
            chart1.Series["Otomobil"].Points.AddXY("Bugatti", 350);
         */

            string[] otomobil = { "BMW", "Mercedes", "Ami", "Porsche", "Şahin", "Bugatti" };
            int[] hiz = { 250, 240, 40, 300, 180, 350 };

            for (int i = 0; i < otomobil.Length; i++)
            {
                chart1.Series["Otomobil"].Points.AddXY(otomobil[i], hiz[i]);
            }

        }
    }
}
