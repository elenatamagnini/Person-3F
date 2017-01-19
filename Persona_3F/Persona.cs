using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_3F
{
    class Persona
    {

        public string nome { get; set; }

        public string cognome { get; set; }

        private int _anni;
        public int anni
        {
            set
            {
                if (value <= 0) value = 1;
                _anni = value;
            }
            get
            {
                return _anni;
            }
        }

      
        public string codicefiscale { get { return nome + cognome + anni.ToString(); } } //To.String funzione propria degli object, converte il valore da int a string

        public virtual string describe()
        {
            return
               "nome: " + nome + System.Environment.NewLine +
               "cognome: " + cognome + System.Environment.NewLine +
               "anni: " + anni.ToString() + System.Environment.NewLine;
            
        }

        public Persona(string nome, string cognome, int anni)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni;
        }

        public override string ToString()
        {
            return this.nome + " " + this.cognome;
        }

    }
}
