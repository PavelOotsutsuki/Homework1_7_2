using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Homework1_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prisoner> prisoners = new List<Prisoner>()
            {
                new Prisoner("Борисов Андрей Андреевич", "Антиправительственное"),
                new Prisoner("Васюков Игорь Степанович", "Насильственное"),
                new Prisoner("Гулагин Федор Игоревич", "Антиправительственное"),
                new Prisoner("Дидаш Юлия Андреевна", "Превышение полномочий"),
                new Prisoner("Егоров Егор Егорович", "Сбыт наркотиков"),
                new Prisoner("Иванов Петр Павлович", "Антимонопольное"),
                new Prisoner("Смирнов Андрей Андреевич", "Антиправительственное"),
                new Prisoner("Смирнов Петр Иванович", "Шантаж"),
            };

            Console.WriteLine("\nДо амнистии:\n");
            ShowListPrisoners(prisoners);

            prisoners = prisoners.Where(prisoner => prisoner.CrimeType != "Антиправительственное").ToList();

            Console.WriteLine("\nПосле амнистии:\n");
            ShowListPrisoners(prisoners);

        }

        static void ShowListPrisoners(List<Prisoner> list)
        {
            foreach (var prisoner in list)
            {
                Console.WriteLine(prisoner.FullName);
            }
        }
    }

    class Prisoner
    {
        public Prisoner(string fullName, string crimeType)
        {
            FullName = fullName;
            CrimeType = crimeType;
        }

        public string FullName { get; private set; }
        public string CrimeType { get; private set; }
    }
}