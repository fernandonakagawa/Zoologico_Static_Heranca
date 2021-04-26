using System;
using System.Collections.Generic;

namespace SistemaZoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zoologico> zoologicos = new List<Zoologico>();
            Zoologico z1 = new Zoologico("Londrina Zoo", 4);
            Zoologico z2 = new Zoologico("Cambé Zoo", 3);
            zoologicos.Add(z1);
            zoologicos.Add(z2);
            int i = zoologicos.LastIndexOf(z2);
            Gorila g1 = new Gorila("Vemmonstro", "Gorila", 300, 140, "Preta");
            z1.InserirAnimal(g1);
            ConsoleZoologico.Zoologicos = zoologicos;

            //ConsoleZoologico.MostrarMenu();

            List<int> inteiros = new List<int>();
            List<string> textos;
            List<Gorila> gorilas;
            List<MicoLeao> micos;

            MicoLeao m1 = new MicoLeao("Mickey", "Mico Leão", 2, 30, "Dourado");
            Console.WriteLine(g1.FazerBarulho());
            Console.WriteLine(m1.FazerBarulho());


        }
    }
}
