using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaZoologico
{
    class Gorila : Primata
    {
        public Gorila(string nome, string especie, float peso, int altura, string corPelo)
            : base(nome, especie, peso, altura, corPelo)
        {

        }

        public override string FazerBarulho()
        {
            string s = base.FazerBarulho();
            return s + "URRU URRU!";
        }
    }
}
