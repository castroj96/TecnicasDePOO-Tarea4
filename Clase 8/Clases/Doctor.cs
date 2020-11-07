using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8.Clases
{
    class Doctor : Persona
    {
        private List<Paciente> pacientes;

        public Doctor()
        {
        }

        internal List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
    }
}
