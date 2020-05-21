using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    class Sedan : AbstractFactoryCars
    {
        public override void Lastikler()
        {
            MessageBox.Show("Lastikler takıdı.");
        }

        public override void Motor()
        {
            MessageBox.Show("Motor takılmadı");
        }

        public override void Renk()
        {
            MessageBox.Show("Araç boyandı");
        }

        public override void Test()
        {
            MessageBox.Show("Araç test edildi.");
        }

        public override string IslemSonuc()
        {
            return "Sedan Araç Tamamlandı, satışa hazır.";
        }

    }
}
