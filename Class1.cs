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
        public decimal Ocena { get; set; }

        public Class1(string imie, string nazwa, decimal ocena)
        {
            Imie = imie;
            Nazwa = nazwa;
            Ocena = ocena;
        }

        public override string ToString()
        {
            return $"{Imie} - {Nazwa} - {Ocena}";
        }
    }
}
