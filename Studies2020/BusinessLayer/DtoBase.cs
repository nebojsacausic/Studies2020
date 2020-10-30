using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies2020.BusinessLayer
{
    public abstract class DtoBase
    {
    }

    public class DtoPredmet : DtoBase
    {
        public int IdPredmet { get; set; }
        public string PredmetNaziv { get; set; }
        public int Espb { get; set; }
    }

    public class DtoStudent : DtoBase
    {
        public int IdStudent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int IndeksBroj { get; set; }
        public int IndeksGodina { get; set; }
        public string IndeksCalc { get; set; }
    }


    public class DtoStudentIspit : DtoBase
    {
        public int IdStudent { get; set; }
        public string ImePrezime { get; set; }
        public int IdIspit { get; set; }
        public int? Ocena { get; set; }
        public DateTime DvPrijave { get; set; }
        public DateTime? IspitDatum { get; set; }
        public int IdPredmet { get; set; }
        public string PredmetNaziv { get; set; }
    }

}
