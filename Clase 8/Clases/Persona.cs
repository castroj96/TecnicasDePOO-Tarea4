using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8.Clases
{
    class Persona
    {
        private String id;
        private String name;
        private String lastname;
        private String lastName2;

        public Persona()
        {
        }

        public Persona(string id, string name, string lastname, string lastName2)
        {
            this.Id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.LastName2 = lastName2;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string LastName2 { get => lastName2; set => lastName2 = value; }
    }
}
