using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_8.Clases;

namespace Clase_8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Paciente paciente = ListClass.paciente;
            if (paciente != null)
            {
                if (paciente.Enfermedades != null)
                {
                    foreach (Enfermedades enfermedad in paciente.Enfermedades)
                        dataGridView1.Rows.Add(enfermedad.ToString());
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Paciente paciente = ListClass.paciente;
            if (paciente != null)
            {
                Enfermedades enfermedades = new Enfermedades();
                enfermedades.Id = 1;
                enfermedades.Name = txt_Illness.Text;
                paciente.Enfermedades.Add(enfermedades);
            }

            this.Dispose();
            Form4 form = new Form4();
            form.Show();
        }
    }
}
