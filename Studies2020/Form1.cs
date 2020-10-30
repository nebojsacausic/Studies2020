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
using static Studies2020.BusinessLayer.OpStudentBase;

namespace Studies2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.listViewStudentIspit.View = View.Details;
            this.listViewStudentIspit.Columns.Add("RB");
            this.listViewStudentIspit.Columns.Add("Student");
            this.listViewStudentIspit.Columns.Add("Datum");
            this.listViewStudentIspit.Columns.Add("Predmet");
            this.listViewStudentIspit.Columns.Add("Ocjena");
            this.listViewStudentIspit.Columns.Add("Datum prijave");
            this.listViewStudentIspit.FullRowSelect = true;
            this.listViewStudentIspit.MultiSelect = false;






            //Columns initialization in DataGridView
            this.dataGridViewStudents.Columns.Add("columnRb", "RB");
            this.dataGridViewStudents.Columns.Add("columnIme", "Ime");
            this.dataGridViewStudents.Columns.Add("columnPrezime", "Prezime");
            this.dataGridViewStudents.Columns.Add("columnIndeks", "Indeks");
            this.dataGridViewStudents.Columns.Add("columnIndeksBroj", "Br In");
            this.dataGridViewStudents.Columns.Add("columnIndeksGodina", "God");


            this.dataGridViewStudentIspit.Columns.Add("columnRb", "RB");
            this.dataGridViewStudentIspit.Columns.Add("columnImePrezime", "Ime i prezime");
            this.dataGridViewStudentIspit.Columns.Add("columnDatum", "Datum");
            this.dataGridViewStudentIspit.Columns.Add("columnPredmet", "Predmet");
            this.dataGridViewStudentIspit.Columns.Add("columnOcjena", "Ocjena");
            this.dataGridViewStudentIspit.Columns.Add("columnDatumPrijave", "Datum prijave");

            for (int i = 0; i <= dataGridViewStudentIspit.Columns.Count - 1; i++)
            {
                this.dataGridViewStudentIspit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }


            //Initialization of subjets names in ComboBox
            OpPredmetSelect op = new OpPredmetSelect();
            OperationResult obj = OperationManager.Singleton.executeOperation(op);
            if (obj == null || obj.Items == null)
                return;
            DtoPredmet[] predmeti = obj.Items.Cast<DtoPredmet>().ToArray();
            this.comboBoxPredmets.DisplayMember = "PredmetNaziv";
            this.comboBoxPredmets.ValueMember = "IdPredmet";
            this.comboBoxPredmets.DataSource = predmeti;
            this.comboBoxPredmets.SelectedIndex = -1;

            
            //Calling the data grid function
            FillDataGridViewStudents();
        }

        private void FillDataGridViewStudents()
        {
            OpStudentSelect op = new OpStudentSelect();
            OperationResult obj = OperationManager.Singleton.executeOperation(op);
            if (obj == null || obj.Items == null)
                return;
            DtoStudent[] students = obj.Items.Cast<DtoStudent>().ToArray();

            this.dataGridViewStudents.Rows.Clear();
            int rb = 1;
            foreach (DtoStudent item in students)
            {
                int indeks = this.dataGridViewStudents.Rows.Add(
                    rb.ToString(), item.Ime, item.Prezime, item.IndeksCalc,
                    item.IndeksBroj, item.IndeksGodina);
                DataGridViewRow row = this.dataGridViewStudents.Rows[indeks];
                row.Tag = item;
                rb++;
            }
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = this.dataGridViewStudents.CurrentRow;
            if (currentRow == null)
                return;
            DtoStudent dtoStudent = currentRow.Tag as DtoStudent;
            if (dtoStudent == null)
                return;
            int idStudent = dtoStudent.IdStudent;


            OpStudentIspitSelect op = new OpStudentIspitSelect(idStudent, 0);
            OperationResult obj = OperationManager.Singleton.executeOperation(op);
            if (obj == null || obj.Items == null)
                return;
            DtoStudentIspit[] studIspiti = obj.Items.Cast<DtoStudentIspit>().ToArray();


            this.dataGridViewStudentIspit.Rows.Clear();
            int rb = 1;
            foreach (DtoStudentIspit item in studIspiti)
            {
                int indeks = this.dataGridViewStudentIspit.Rows.Add(
                    rb.ToString(), item.ImePrezime, item.IspitDatum, item.PredmetNaziv, item.Ocena,
                    item.DvPrijave);
                DataGridViewRow row = this.dataGridViewStudentIspit.Rows[indeks];
                row.Tag = item;
                rb++;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            DataGridViewRow currentRow = this.dataGridViewStudents.CurrentRow;
            if (currentRow == null)
                return;
            DtoStudent dtoStudent = currentRow.Tag as DtoStudent;
            if (dtoStudent == null)
                return;
            try
            {
                string ime = currentRow.Cells[1].Value.ToString();
                string prezime = currentRow.Cells[2].Value.ToString();

                if ((dtoStudent.Ime == ime) &&
                    (dtoStudent.Prezime == prezime))
                    return;
                DtoStudent dtoStudentNew = new DtoStudent
                {
                    IdStudent = dtoStudent.IdStudent,
                    Ime = ime,
                    Prezime = prezime
                };

                OpUpdateStudent op = new OpUpdateStudent(dtoStudentNew);
                OperationResult obj = OperationManager.Singleton.executeOperation(op);
                if (obj == null || obj.Items == null)
                    return;
                DtoStudent[] students = obj.Items.Cast<DtoStudent>().ToArray();

                FillDataGridViewStudents();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = this.dataGridViewStudents.CurrentRow;
            if (currentRow == null)
                return;
            DtoStudent dtoStudent = currentRow.Tag as DtoStudent;
            if (dtoStudent == null)
                return;

            OpDeleteStudent op = new OpDeleteStudent(dtoStudent);
            OperationResult obj = OperationManager.Singleton.executeOperation(op);
            if (obj == null || obj.Items == null)
                return;
            DtoStudent[] students = obj.Items.Cast<DtoStudent>().ToArray();
            FillDataGridViewStudents();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            AddStudentForm forma = new AddStudentForm();
            forma.Show();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FillDataGridViewStudents();
        }

        private void comboBoxPredmets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPredmet = 0;

            if (this.comboBoxPredmets.SelectedValue != null)
            {
                idPredmet = (int)this.comboBoxPredmets.SelectedValue;
            }

            OpStudentIspitSelect op = new OpStudentIspitSelect(0, idPredmet);
            OperationResult obj = OperationManager.Singleton.executeOperation(op);
            if (obj == null || obj.Items == null)
                return;
            DtoStudentIspit[] studIspiti = obj.Items.Cast<DtoStudentIspit>().ToArray();


            this.listViewStudentIspit.BeginUpdate();
            this.listViewStudentIspit.Items.Clear();
            int rb = 1;
            foreach (DtoStudentIspit item in studIspiti)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = rb.ToString();
                listViewItem.SubItems.Add(item.ImePrezime);
                listViewItem.SubItems.Add(item.IspitDatum.ToString());
                listViewItem.SubItems.Add(item.PredmetNaziv);
                listViewItem.SubItems.Add((item.Ocena == null) ? "" : item.Ocena.ToString());
                listViewItem.SubItems.Add(item.IspitDatum.ToString());
                this.listViewStudentIspit.Items.Add(listViewItem);
                listViewItem.Tag = item;
                rb++;
            }
            this.listViewStudentIspit.EndUpdate();

        }
    }
}
