using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucgen_bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar1 = 0;
            int kenar2 = 0;
            int kenar3 = 0;

            kenar1 = Convert.ToInt32(textBox1.Text);
            kenar2 = Convert.ToInt32(textBox2.Text);
            kenar3 = Convert.ToInt32(textBox3.Text);

            if ((kenar1 == 0) || (kenar2 == 0) || (kenar3 == 0))
            {
                label4.Text = "ÜÇGEN OLABİLMESİ İÇİN KENARLARDAN HERHANGİ BİRİ 0 OLAMAZ";
            }
            else if((kenar1 == kenar2) && (kenar2 == kenar3) && (kenar1 == kenar3))
            {
                label4.Text = "BU BİR EŞKENAR ÜÇGENDİR";
            }
            else if((kenar1 == kenar2) || (kenar2 == kenar3) || (kenar1 == kenar3))
            {
                label4.Text = "BU BİR İKİZKENAR ÜÇGENDİR";
            }
            else if ((((kenar1 * kenar1) + (kenar2 * kenar2)) == (kenar3 * kenar3)) || (((kenar2 * kenar2) + (kenar3 * kenar3)) == (kenar1 * kenar1)) || (((kenar1 * kenar1) + (kenar3 * kenar3)) == (kenar2 * kenar2)))
            {
                label4.Text = "BU BİR DİK ÜÇGENDİR";
            }
            else if(((kenar1+kenar2) > kenar3) && ((kenar2+kenar3) > kenar1) && ((kenar1+kenar3) > kenar2))
            {
                label4.Text = "BU BİR ÜÇGENDİR";
            }
            else
            {
                label4.Text = "BU BİR ÜÇGEN DEĞİLDİR";
            }
        }
    }
}
