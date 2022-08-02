using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace vize_sınavı_hazırlık_6_
{
    public class Faramir:Bromir
    {
        public int yas;
        Yuzuk y = new Yuzuk(27);
        public Faramir() : this("yas")
        {
            yas = 27;
            MessageBox.Show("Faramir 1");
        }
        public Faramir(int a) : this("ad")
        {
            yas = 28;
            MessageBox.Show("Faramir 2");
        }
        public Faramir(string ad) : base(16)
        {
            yas = 29;
            MessageBox.Show("Faramir 3");
            Yuzuk y = new Yuzuk();
        }
    }
}
