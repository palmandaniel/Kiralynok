using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Tabla
    {
        char[,] T;
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

 
        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }
        public void Elhelyez(int N)
        {
            //1. véletlen helyiérték létrehozása
            //  -Random osztály értékek halmaza[0,7]
            //  -véletlen sor és oszlop
            //elhelyezzük a 'K'-t, csak akkor, ha üres (-> '#')
            Random vel = new Random();

            for (int i = 0; i < N; i++)
            {
                int sor = vel.Next(0, 8);
                int oszlop = vel.Next(0, 8);
                while (T[sor, oszlop] == 'k')
                {
                    sor = vel.Next(0, 8);
                    oszlop = vel.Next(0, 8);
                }
                T[sor, oszlop] = 'K';
                
            }
          

            
        }

        public void FajlbaIr()
        {

        }

        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(T[i,j]+ " "); //"${T[i,j]} "
                }
                Console.WriteLine();
            }
        }


        public int UresOszlop()
        {
            return 0;
        }

        public int UresSor()
        {
            return 0;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");
            Tabla t = new Tabla('#'); //példányosítás
            Console.WriteLine("***************");
            
            Console.WriteLine("Üres tábla:");
            t.Megjelenit();
            Console.WriteLine();
            Console.WriteLine("***************");
            t.Elhelyez(63);
            t.Megjelenit();

            Console.ReadKey();
        }
    }
}
