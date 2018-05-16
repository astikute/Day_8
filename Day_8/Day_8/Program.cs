using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Masiva piemers \n2. Izvada zvaigznites \n3. Piecu skaitlu ievade, izvade un summesana \n4. Izeja");
            string izvele = "";

            do
            {
                izvele = Console.ReadLine();
                switch (izvele)
                {
                    case "1":
                        MasivaPiemers();
                        break;
                    case "2":
                        JaunaZvaigznite();
                        break;
                    case "3":
                        IevadeIzvade();
                        break;
                    case "4":
                        break;
                }
            }
            while (izvele != "4");
        }

        static void IevadeIzvade()
        {
            bool parbaude = true;
            Console.WriteLine("Ievadiet 5 skaitlus!");
            string[] ievaditaisMasivs = new string[5]; // "new" mēs izmantojam, jo mēs masīvu izveidojam kā objektu!
            int[] parbMasivs = new int[5];
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write(i+1 + ") ");
                    ievaditaisMasivs[i] = Console.ReadLine();
                    parbaude = Int32.TryParse(ievaditaisMasivs[i], out parbMasivs[i]);
                    if (parbaude == false)
                    {
                        Console.WriteLine("Kluda! Ievadi velreiz!");
                    }
                }
                while (parbaude == false);
            }

            int sum = 0;
            Console.Write("Jus ievadijat sekojosus skaitlus: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(parbMasivs[j] + " ");
                sum = sum + parbMasivs[j];
            }
            Console.WriteLine("\nSkaitlu summa: {0}", sum);
        }

        static void JaunaZvaigznite()
        {
            string[] zvaigznites = new string [3];
            zvaigznites[0] = "*";
            zvaigznites[1] = "**";
            zvaigznites[2] = "***";

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine(zvaigznites[i]);
            }
        }

        static void MasivaPiemers()
        {
           int[] masivs = new int[4]; //masīviem automātiski netiek rezervēta vieta atmiņā, tāpēc jānorāda! 
           masivs[0] = 1;
           masivs[1] = 5;
           masivs[2] = 7;
           masivs[3] = 6;

           for (int i = 0; i<4; i++)
           {
               Console.WriteLine(masivs[i]);
           }
        }
    }

}
