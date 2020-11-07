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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Doctor doc = new Doctor();
            doc.Id = "1234";
            doc.Name = "Juan";
            doc.Lastname = "Alvarado";
            doc.LastName2 = "Cordero";

            ListClass.doctors.Add(doc);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            for (int index = 0; index < ListClass.doctors.Count(); index++)
            {
                if (txt_doctorNumber.Text.Equals(ListClass.doctors[index].Id))
                {
                    MessageBox.Show("Bienvenido " + ListClass.doctors[index].Name + " " + ListClass.doctors[index].Lastname);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
                MessageBox.Show("Doctor no encontrado");
            else
            {
                Form1 loginForm = new Form1();
                loginForm.Hide();
                Form2 loggedForm = new Form2();
                loggedForm.Show();
            }
        }
    }
}
