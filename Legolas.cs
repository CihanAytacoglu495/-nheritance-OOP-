using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace vize_sınavı_hazırlık_6_
{
    public class Legolas:Aragorn
    {
        Yuzuk y = new Yuzuk(18);
        public Legolas() : this("ad")
        {
            unvan = "elf prens";
            MessageBox.Show("Legolas 1");
            Yuzuk y = new Yuzuk();
        }
        public Legolas(int b) : base(14)
        {
            unvan = "nisancı";
            MessageBox.Show("Legolas 2");
        }
        Yuzuk u = new Yuzuk();
        public Legolas(string cihan)
        {
            unvan = "orman elfi";
            MessageBox.Show("Legolas 3");
        }
        public void İsildur()
        {
            base.İsildur();
            MessageBox.Show("Aragorn varis");
        }
    }
}
