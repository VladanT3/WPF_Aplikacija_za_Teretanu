﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana
{
    public class pomStavkaRacuna
    {
        public string ID { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public int Kolicina { get; set; }

        public pomStavkaRacuna(string id, string naziv, double cena, int kolicina)
        {
            ID = id;
            Naziv = naziv;
            Cena = cena;
            Kolicina = kolicina;
        }
    }
}