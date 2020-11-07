using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8.Clases
{
    class Enfermedades
    {
        private int id;
        private String name;

        public Enfermedades()
        {
        }

        public Enfermedades(string name)
        {
            this.Name = name;
        }

        public Enfermedades(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
