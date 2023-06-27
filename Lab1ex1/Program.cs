using System;

namespace Lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 1.Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
             paralelipiped dreptunghic, va afisa volumul lui*/

            int lungime;
            int latime;
            int inaltime;

            Console.WriteLine("ACEST PROGRAM VA CALCULA VOLUMUL UNUI PARALIPIPED DREPTUNGHIC");

            Console.WriteLine("Introduceti lungimea: ");
            lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea: ");
            latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea: ");
            inaltime = int.Parse(Console.ReadLine());

            int volumParalipiped = lungime * latime * inaltime;

            Console.WriteLine("Volumul paralipipedului dreptunghic este: " + volumParalipiped);
        }
    }
}