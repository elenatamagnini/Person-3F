using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_3F
{
    class Studente : Persona
    {
        public Studente(string nome, string cognome, int anni, string sezione) : base(nome, cognome, anni)
            {

            }

        public string sezione { get; set; }

    }
}
