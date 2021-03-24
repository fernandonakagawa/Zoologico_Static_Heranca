using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaZoologico
{
    class Primata:Animal
    {
        private string _corPelo;
        public string CorPelo { get => _corPelo; set => _corPelo = value; }

        public Primata(string nome, string especie, float peso, int altura, string corPelo)
            :base(nome,especie, peso, altura)
        {
            CorPelo = corPelo;
        }
    }
}
