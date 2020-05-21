using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(AllCars));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllCars uretilecekarac = (AllCars)this.comboBox1.SelectedItem;
            Creater creater = new Creater();
            AbstractFactoryCars abstractFactoryCars = creater.FactoryMethod(uretilecekarac);
            abstractFactoryCars.Lastikler();
            abstractFactoryCars.Motor();
            abstractFactoryCars.Renk();
            abstractFactoryCars.Test();
            textBox1.Text += abstractFactoryCars.IslemSonuc() + " ";
        }
    }
}
