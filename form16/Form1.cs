using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            int yas = 32;
            if(yas >= 18)
            {
                MessageBox.Show("Ehliyet Alabilirsiniz");
            }

            if(yas < 18)
            {
                MessageBox.Show("Üzgünüm Biraz Daha Büyümelisin");
            }
        }
    }
}
