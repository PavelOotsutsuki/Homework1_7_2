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
            string crimeAntiGovernment = "Антиправительственное";
            string crimeViolent = "Насильственное";
            string crimeAbuseOfAuthority = "Превышение полномочий";
            string crimeSellingDrugs = "Сбыт наркотиков";
            string crimeAntitrust = "Антимонопольное";
            string crimeBlackmail = "Шантаж";

            List<Prisoner> prisoners = new List<Prisoner>()
            {
                new Prisoner("Борисов Андрей Андреевич", crimeAntiGovernment),
                new Prisoner("Васюков Игорь Степанович", crimeViolent),
                new Prisoner("Гулагин Федор Игоревич", crimeAntiGovernment),
                new Prisoner("Дидаш Юлия Андреевна", crimeAbuseOfAuthority),
                new Prisoner("Егоров Егор Егорович", crimeSellingDrugs),
                new Prisoner("Иванов Петр Павлович", crimeAntitrust),
                new Prisoner("Смирнов Андрей Андреевич", crimeAntiGovernment),
                new Prisoner("Смирнов Петр Иванович", crimeBlackmail),
            };

            Console.WriteLine("\nДо амнистии:\n");
            ShowListPrisoners(prisoners);

            prisoners = prisoners.Where(prisoner => prisoner.CrimeType != crimeAntiGovernment).ToList();

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