using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_application
{
    public class VisualiserRapport
    {
        private string _Medecin;
        private string _Visiteur;
        private int _Rapport;
        private string _FamilleMedicament;
        private string _Medicament;

        public string Medecin { get => _Medecin; set => _Medecin = value; }
        public string Visiteur { get => _Visiteur; set => _Visiteur = value; }
        public int Rapport { get => _Rapport; set => _Rapport = value; }
        public string Medicament { get => _Medicament; set => _Medicament = value; }
        public string FamilleMedicament { get => _FamilleMedicament; set => _FamilleMedicament = value; }

        public VisualiserRapport(string medecin, string visiteur, int rapport, string familleMedicament, string medicament)
        {
            this._Medecin = medecin;
            this._Visiteur = visiteur;
            this._Rapport = rapport;
            this._FamilleMedicament = familleMedicament;
            this._Medicament = medicament;
        }
    }
}
