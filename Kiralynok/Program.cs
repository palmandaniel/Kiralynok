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
        public void Elhelyez()
        {

        }

        public void FajlbaIr()
        {

        }

        public void Megjelenit()
        {

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
            Console.ReadKey();
        }
    }
}
