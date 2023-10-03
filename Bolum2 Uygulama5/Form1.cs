using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            string kullanici_adi;
            kullanici_adi=txtKullanici.Text;

            if (kullanici_adi == "yezdaacik@gmail.com") 
            {
                MessageBox.Show("Kullanıcı sisteme kayıtlıdır.");                
            }

            if (kullanici_adi!= "yezdaacik@gmail.com")
            {
                MessageBox.Show("Kullanıcı adınız yanlıştır.");
            }
        }
    }
}
