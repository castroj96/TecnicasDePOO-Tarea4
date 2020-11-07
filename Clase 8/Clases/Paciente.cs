using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8.Clases
{
    class Paciente : Persona
    {
        private List<Enfermedades> enfermedades;

        public Paciente()
        {
        }

        internal List<Enfermedades> Enfermedades { get => enfermedades; set => enfermedades = value; }
    }
}
