using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_application
{
    public class Medic
    {
        public string idMedicament { get; set; }
        public string nomMedicament { get; set; }
        public string familleMedicament { get; set; }
        public string quantiteMedicament { get; set; }

        public Medic()
        {
            this.idMedicament = "";
            this.nomMedicament = "";
            this.familleMedicament = "";
            this.quantiteMedicament = "";
        }
        public Medic(string id, string nom, string famille, string quantite)
        {
            this.idMedicament = id;
            this.nomMedicament = nom;
            this.familleMedicament = famille;
            this.quantiteMedicament = quantite;
        }
    }
}
