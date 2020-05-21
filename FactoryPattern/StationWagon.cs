using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    class StationWagon : AbstractFactoryCars
    {
        public override void Lastikler()
        {
            MessageBox.Show("Lastikler takıdı.");
        }

        public override void Motor()
        {
            MessageBox.Show("Motor takıdı.");
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
            return "Station Wagon Araç Tamamlandı, satışa hazır.";
        }
    }
}
