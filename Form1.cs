using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga_VS_Liebre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tortuga galapagos=new Tortuga("Squirtle");
            Liebre BugsBony= new Liebre("Bugs");
            textBox1.Text += galapagos.ToString()+BugsBony.ToString();
            while (galapagos.posicion < 80 && BugsBony.posicion < 80)
            {
                galapagos.avanzar();
                BugsBony.avanzar();
                textBox1.Text += galapagos.ToString()+BugsBony.ToString()+Environment.NewLine;
            }
            if (galapagos.posicion == 80 && BugsBony.posicion == 80)
            {
                textBox1.Text += " Es dificil de creer pero empataron ";
            }
            else if (galapagos.posicion > BugsBony.posicion)
            {
                textBox1.Text += "Bugs perdiste contra Squirtle";
            }
            else if (galapagos.posicion < BugsBony.posicion)
            {
                textBox1.Text += "Que hay de nuevo viejo Gane lml";
            }
        }
    }
}
