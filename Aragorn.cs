using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace vize_sınavı_hazırlık_6_
{
   public class Aragorn
    {
        public string unvan;
        Yuzuk y = new Yuzuk(34);
        public Aragorn() : this(23)
        {
            unvan = "gercek kral";
            MessageBox.Show("Aragorn 1");
        }
        public Aragorn(int b) : base()
        {
            unvan = "isildurun varisi";
            MessageBox.Show("Aragorn 2");
            İsildur();
        }
        Yuzuk u = new Yuzuk();
        public Aragorn(string soyad) : this()
        {
            unvan = "elfce bilen";
            MessageBox.Show("Aragorn 3");
        }
        public void İsildur()
        {
            MessageBox.Show("varis Aragorn");
        }
    }
}
