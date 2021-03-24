using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaZoologico
{
    class Animal
    {
        private static int _quantidadeAnimaisGlobal;

        private string _nome;
        private string _especie;
        private float _peso;
        private int _altura;

        public static int QuantidadeAnimaisGlobal { get => _quantidadeAnimaisGlobal; 
            set => _quantidadeAnimaisGlobal = value; }
        public string Nome { get => _nome; private set => _nome = value; }
        public string Especie { get => _especie; private set => _especie = value; }
        public float Peso { get => _peso; set => _peso = value; }
        public int Altura { get => _altura; set => _altura = value; }

        public Animal(string nome, string especie, float peso, int altura)
        {
            Nome = nome;
            Especie = especie;
            Peso = peso;
            Altura = altura;

            QuantidadeAnimaisGlobal++;
        }
    }
}
