using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace vize_sınavı_hazırlık_6_
{
    public class Bromir:Aragorn
    {
        public string vade;
        Yuzuk y = new Yuzuk(16);
        public Bromir() : this(5)
        {
            vade = "kimsin";
            MessageBox.Show("Bromir 1");
            Yuzuk y = new Yuzuk();
        }
        public Bromir(int a) : this("soyad")
        {
            vade = "her zaman";
            MessageBox.Show("Bromir 2");
            base.İsildur();
        }
        Yuzuk u = new Yuzuk();
        public Bromir(string yas) : base("sensin")
        {
            vade = "gitisine";
            MessageBox.Show("Bromir 3");
            Yuzuk y = new Yuzuk(24);
        }
    }
}
