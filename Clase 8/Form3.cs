using Clase_8.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Paciente paciente = ListClass.paciente;
            if (paciente != null)
            {
                txt_Id.Text = paciente.Id;
                txt_Name.Text = paciente.Name;
                txt_LastName.Text = paciente.Lastname;
                txt_LastName2.Text = paciente.LastName2;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Paciente paciente = ListClass.paciente;

            //Add new
            if (paciente == null)
            {
                paciente = new Paciente();
                paciente.Id = txt_Id.Text;
                paciente.Name = txt_Name.Text;
                paciente.Lastname = txt_LastName.Text;
                paciente.LastName2 = txt_LastName2.Text;

                ListClass.pacientes.Add(paciente);
            }
                
            //Edit
            else
            {
                Paciente editPaciente = null;
                int index = 0;
                foreach(Paciente editPac in ListClass.pacientes)
                {
                    if (editPac.Id == paciente.Id)
                    {
                        editPaciente = editPac;
                        break;
                    }
                    index += 1;
                }

                ListClass.pacientes[index].Id = txt_Id.Text;
                ListClass.pacientes[index].Name = txt_Name.Text;
                ListClass.pacientes[index].Lastname = txt_LastName.Text;
                ListClass.pacientes[index].LastName2 = txt_LastName2.Text;
            }

            Form2 listPac = new Form2();
            listPac.Show();
            this.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
