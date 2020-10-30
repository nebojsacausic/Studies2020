using Studies2020.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies2020.BusinessLayer
{
    public abstract class OpStudentBase : Operation
    {
        public override OperationResult execute()
        {
            StudijeEntities entities = new StudijeEntities();
            IEnumerable<DtoStudent> ieStudenti =
                from student in entities.Students
                select new DtoStudent
                {
                    IdStudent = student.idStudent,
                    Ime = student.ime,
                    Prezime = student.prezime,
                    IndeksBroj = student.indeksBroj,
                    IndeksGodina = student.indeksGodina,
                    IndeksCalc = student.indeksCalc
                };

            OperationResult obj = new OperationResult();
            obj.Items = ieStudenti.ToArray();
            return obj;
        }
    }

    public class OpStudentSelect : OpStudentBase { }

    public abstract class OpStudentEdit : OpStudentBase
    {
        protected DtoStudent dto { get; set; }
        protected StudijeEntities entities;
        public OpStudentEdit(DtoStudent dto)
        {
            this.dto = dto;
        }
        protected abstract void Editovanje();
        public override OperationResult execute()
        {
            entities = new StudijeEntities();
            Editovanje();
            entities.SaveChanges();
            return base.execute();
        }
    }

    public class OpUpdateStudent : OpStudentEdit
    {
        public OpUpdateStudent(DtoStudent dto) : base(dto) { }
        protected override void Editovanje()
        {
            Student student = new Student
            {
                idStudent = this.dto.IdStudent,
                ime = this.dto.Ime,
                prezime = this.dto.Prezime,
                indeksBroj = this.dto.IndeksBroj,
                indeksGodina = this.dto.IndeksGodina,
                indeksCalc = this.dto.IndeksCalc
            };

            this.entities.Students.Attach(student);
            var entry = this.entities.Entry(student);
            entry.Property(x => x.ime).IsModified = true;
            entry.Property(x => x.prezime).IsModified = true;
        }
    }

    public class OpDeleteStudent : OpStudentEdit
    {
        public OpDeleteStudent(DtoStudent dto) : base(dto) { }
        protected override void Editovanje()
        {
            Student student = this.entities.Students.Where(x => x.idStudent == this.dto.IdStudent).FirstOrDefault();
            if (student == null)
                return;
            this.entities.Students.Remove(student);
        }
    }


    public class OpAddStudent : OpStudentEdit
    {
        public OpAddStudent(DtoStudent dto) : base(dto) { }

        protected override void Editovanje()
        {
            Student studentNew = new Student
            {
                idStudent = this.dto.IdStudent,
                ime = this.dto.Ime,
                prezime = this.dto.Prezime,
                indeksBroj = this.dto.IndeksBroj,
                indeksGodina = this.dto.IndeksGodina,
                indeksCalc = this.dto.IndeksCalc
            };
            this.entities.Students.Add(studentNew);
        }
    }



}
