using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_sınavı_hazırlık_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Faramir F = new Faramir();
            Bromir B = new Bromir();
            MessageBox.Show(F.yas.ToString());
            MessageBox.Show(B.vade);
            Legolas L = new Legolas(19);
            L.İsildur();
            MessageBox.Show(L.unvan);
            Aragorn A = new Aragorn();
            MessageBox.Show(A.unvan);
        }
    }
}
