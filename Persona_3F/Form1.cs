using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona_3F
{
    public partial class Form1 : Form
    {
        private string[] nomi = { "Tizio", "Caio", "Sempronio" };
        private string[] cognomi = { "Rossi", "Bianchi", "Verdi" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(generateRandomPersona());
            Console.WriteLine(generateRandomPersona());
            Console.WriteLine(generateRandomPersona());
        }

        Random rnd = new Random();
        private Persona generateRandomPersona()
        {
            return new Persona(nomi[rnd.Next(0, 3)], cognomi[rnd.Next(0, 3)], rnd.Next(18, 50));
        }
    }
}
