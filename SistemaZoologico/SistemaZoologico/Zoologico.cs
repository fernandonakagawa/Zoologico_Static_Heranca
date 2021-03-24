using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaZoologico
{
    class Zoologico
    {
        private string _nome;
        private List<Animal> _animais;
        private int _capacidade;

        public string Nome { get => _nome; private set => _nome = value; }
        public int Capacidade { get => _capacidade; private set => _capacidade = value; }
        public List<Animal> Animais { get => _animais; private set => _animais = value; }

        public Zoologico(string nome, int capacidade)
        {
            Nome = nome;
            Capacidade = capacidade;
            Animais = new List<Animal>();
        }

        public bool InserirAnimal(Animal a)
        {
            if (Animais.Count >= Capacidade) return false;
            Animais.Add(a);
            return true;
        }
        public bool RemoverAnimal(Animal a)
        {
            return Animais.Remove(a);
        }
        public Animal BuscarAnimal(string nome)
        {
            foreach(Animal a in this.Animais)
            {
                if (a.Nome.Equals(nome)) return a;
            }
            return null;
        }
    }
}
