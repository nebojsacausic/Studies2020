using Studies2020.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies2020.BusinessLayer
{
    public abstract class OpStudentIspitBase : Operation
    {
        public int idPredmet { get; set; }
        public int idStudent { get; set; }

        public OpStudentIspitBase(int idStudent = 0, int idPredmet = 0)
        {
            this.idStudent = idStudent;
            this.idPredmet = idPredmet;
        }
        public override OperationResult execute()
        {
            StudijeEntities entities = new StudijeEntities();
            IEnumerable<DtoStudentIspit> ieStudIspit =
                from student in entities.Students
                join studIspit in entities.StudentIspits
                on student.idStudent equals studIspit.idStudent
                join ispit in entities.Ispits
                on studIspit.idIspit equals ispit.idIspit
                where ((idStudent == 0) ? true : (studIspit.idStudent == idStudent)) &&
                      ((idPredmet == 0) ? true : (ispit.idPredmet == idPredmet))
                select new DtoStudentIspit
                {
                    IdStudent = student.idStudent,
                    ImePrezime = student.imePrezime,
                    IdIspit = ispit.idIspit,
                    Ocena = studIspit.ocena,
                    PredmetNaziv = ispit.Predmet.predmetNaziv,
                    IdPredmet = ispit.idPredmet,
                    DvPrijave = studIspit.dvPrijave,
                    IspitDatum = ispit.ispitDatum
                };

            OperationResult obj = new OperationResult();
            obj.Items = ieStudIspit.ToArray();
            return obj;
        }
    }


    public class OpStudentIspitSelect : OpStudentIspitBase 
    {
        private OpStudentIspitSelect() { }
        public OpStudentIspitSelect(int idStudent, int idPredmet): base(idStudent, idPredmet) { }
    }
}
