﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.Jmeno = "Zdenek";
            osoba.Prijmeni = "Jendřejčík";
            osoba.DatumNarozeni = DateTime.Parse("26.01.2003");

            Console.WriteLine(osoba.GetVek());

            Console.ReadKey();
        }
    }
}
