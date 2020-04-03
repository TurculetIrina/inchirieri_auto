using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Masini
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public string NumarDeInmatriculare { get; set; }
        public int AnFabricatie { get; set; }
        public int CapacitateMotor { get; set; }
        public bool Inchiriata {get; set;}

        public Masini()
        {
            Marca = Model = NumarDeInmatriculare = string.Empty;
            AnFabricatie = CapacitateMotor = 0;
            Inchiriata = false;
        }

        public Masini(string _marca, string _model, string _numar, 
            int _an_fabricatie, int _capacitate_motor, bool _inchiriata)
        {
            Marca = _marca;
            Model = _model;
            NumarDeInmatriculare = _numar;
            AnFabricatie = _an_fabricatie;
            CapacitateMotor = _capacitate_motor;
            Inchiriata = _inchiriata;
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",
                Marca, Model, NumarDeInmatriculare, AnFabricatie, CapacitateMotor);
        }

        public bool Compare(Masini masina)
        {
            if (NumarDeInmatriculare == masina.NumarDeInmatriculare)
                return true;
            return false;
        }
    }
}
