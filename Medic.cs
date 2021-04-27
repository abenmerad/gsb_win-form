using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_application
{
    public class Medic
    {
        private string _idMedicament;
        private string _nomMedicament;
        private string _familleMedicament;
        private int _quantiteMedicament;

        public string IdMedicament { get => _idMedicament; }
        public string NomMedicament { get => _nomMedicament; }
        public string FamilleMedicament { get => _familleMedicament; }
        public int QuantiteMedicament { get => _quantiteMedicament; set => _quantiteMedicament = value; }


        public Medic()
        {
            this._idMedicament = "";
            this._nomMedicament = "";
            this._familleMedicament = "";
            this._quantiteMedicament = 0;
        }
        public Medic(string id, string nom, string famille, int quantite)
        {
            this._idMedicament = id;
            this._nomMedicament = nom;
            this._familleMedicament = famille;
            this._quantiteMedicament = quantite;
        }
    }
}
