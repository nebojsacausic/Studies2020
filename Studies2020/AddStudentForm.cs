using Studies2020.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies2020
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        { 

            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBoxIme1.Text;
                string prezime = textBoxPrezime1.Text;
                int indeksBroj = Convert.ToInt32(textBoxIndexBroj1.Text);
                int indeksGodina = Convert.ToInt32(textBoxIndexGodina1.Text);

                DtoStudent dtoStudentNew = new DtoStudent
                {
                    IndeksBroj = indeksBroj,
                    IndeksGodina = indeksGodina,
                    Ime = ime,
                    Prezime = prezime
                };

                OpAddStudent op = new OpAddStudent(dtoStudentNew);
                OperationResult obj = OperationManager.Singleton.executeOperation(op);
                if (obj == null || obj.Items == null)
                    return;
                DtoStudent[] students = obj.Items.Cast<DtoStudent>().ToArray();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }
    }
}
