using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczeniowka
{
    class Class1
    {
        public string Imie { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public Class1(string imie, string nazwa, decimal cena)
        {
            Imie = imie;
            Nazwa = nazwa;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"{Imie} - {Nazwa} - {Cena} zł";
        }
    }
}
