using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_3F
{
    class Persona
    {
        public Persona(string nome, string cognome, int anni)
            {

            }

        public string nome { get; set; }

        public string cognome { get; set; }

        private int _anni;
        public int anni
        {
            set
            {
                if (value < 0) value = 1;
                _anni = value;
            }
            get
            {
                return _anni;
            }
        }

        private string _codicefiscale;
        public string codicefiscale { get { return nome + cognome + anni; } }

        public string describe()
        {
            string output = "Nome: " + nome + "\r\n";
            output += "Cognome: " + cognome + "\r\n";
            output += "Anni: " + anni + "\r\n";

            return output;
        }
    }
}
