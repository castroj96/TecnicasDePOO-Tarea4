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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            List<Paciente> pacList = ListClass.pacientes;
            foreach (Paciente paciente in pacList)
                this.dataGridView1.Rows.Add(paciente.Id, paciente.Name, paciente.Lastname, paciente.LastName2);

        }

        private void btn_AddPaciente_Click(object sender, EventArgs e)
        {
            ListClass.paciente = null;
            Form3 saveForm = new Form3();
            saveForm.Show();
            this.Dispose();
                
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = this.dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRow == 0)
            {
                MessageBox.Show("Favor seleccione alguna fila");
                return;
            }

            for (int i = 0; i < selectedRow; i++)
            {
                String idToDelete = dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString();

                List<Paciente> pacList = ListClass.pacientes;
                Paciente pacToDelete = null;

                foreach (Paciente paciente in pacList)
                    if (paciente.Id == idToDelete) {
                        pacToDelete = paciente;
                        break;
                    }

                if (pacToDelete != null)
                    pacList.Remove(pacToDelete);
                else
                    MessageBox.Show("Paciente no encontrado.");

                this.Dispose();
                Form2 form = new Form2();
                form.Show();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = this.dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRow == 0)
            {
                MessageBox.Show("Favor seleccione alguna fila");
                return;
            }

            for (int i = 0; i < selectedRow; i++)
            {
                String idToEdit = dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString();

                List<Paciente> pacList = ListClass.pacientes;
                Paciente pacToEdit = null;

                foreach (Paciente paciente in pacList)
                {
                    if (paciente.Id == idToEdit)
                    {
                        pacToEdit = paciente;
                        break;
                    }
                }

                if (pacToEdit != null)
                {
                    ListClass.paciente = pacToEdit;
                    Form3 editForm = new Form3();
                    editForm.Show();
                    this.Dispose();
                }
                else
                    MessageBox.Show("Paciente no encontrado.");
            }
        }

        private void btn_Illness_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = this.dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRow == 0)
            {
                MessageBox.Show("Favor seleccione alguna fila");
                return;
            }

            for (int i = 0; i < selectedRow; i++)
            {
                String idToIllness = dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString();

                List<Paciente> pacList = ListClass.pacientes;
                Paciente pacToEdit = null;

                foreach (Paciente paciente in pacList)
                {
                    if (paciente.Id == idToIllness)
                    {
                        pacToEdit = paciente;
                        break;
                    }
                }

                if (pacToEdit != null)
                {
                    ListClass.paciente = pacToEdit;
                    Form4 illness = new Form4();
                    illness.Show();
                }
                else
                    MessageBox.Show("Paciente no encontrado.");
            }
        }
    }
}
