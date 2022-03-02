using System;
using GFT.src.Entities;

namespace GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizzard");

            Console.WriteLine(arus);
            Console.WriteLine(wizard);

        }
    }
}
