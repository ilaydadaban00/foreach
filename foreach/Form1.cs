using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        List<int> sayilar = new List<int>() { 2,2,8,7,2,58,8,4,5,98};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
                
            {
                toplam = toplam + sayi;
                MessageBox.Show(toplam.ToString());
                
            }
        }
    }
}
