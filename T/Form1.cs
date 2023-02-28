using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // burada buton kullanamaya gerek kalmadı çünkü timer1 in properties>enabled özelliği true yapılınca program çalışır çalışmaz sayaç da çalışmaya başladı
        int saat = 0, dakika = 0, saniye = 0;      
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye==60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if (dakika==3)
                {
                    saat = saat + 1;
                    label1.Text = saat.ToString();
                    dakika = 0;
                    label2.Text = dakika.ToString(); // bunu yazmazsak dakika hiç sıfır olmaz saniye 60 olunca tekrar 1 olur  
                    MessageBox.Show("Boooooom!");
                }
                if (saat==3)
                {
                    timer1.Stop();
                }
            }
        }
    }
}
