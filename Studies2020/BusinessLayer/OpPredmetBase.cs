using Studies2020.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies2020.BusinessLayer
{
    public class OpPredmetBase : Operation
    {
        public override OperationResult execute()
        {
            StudijeEntities entities = new StudijeEntities();
            IEnumerable<DtoPredmet> iePredmeti =
                from predmet in entities.Predmets
                select new DtoPredmet
                {
                    IdPredmet = predmet.idPredmet,
                    PredmetNaziv = predmet.predmetNaziv,
                    Espb = predmet.espb
                };

            OperationResult obj = new OperationResult();
            obj.Items = iePredmeti.ToArray();
            return obj;
        }
    }

    public class OpPredmetSelect : OpPredmetBase { }
}
