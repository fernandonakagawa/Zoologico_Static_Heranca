using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaZoologico
{
    class ConsoleZoologico
    {
        private static List<Zoologico> _zoologicos;
        public static List<Zoologico> Zoologicos { get => _zoologicos; set => _zoologicos = value; }

        private static Zoologico zoologicoSelecionado;
        public static void ListarAnimais(Zoologico z)
        {
            if (z != null)
            {
                Console.WriteLine($"======Animais do Zoológico {z.Nome}========");
                foreach (Animal a in z.Animais)
                {
                    
                    Console.Write($"{a.Especie} {a.Nome} {a.Peso} {a.Altura}");
                    if (a is Primata) Console.Write($" {((Primata)a).CorPelo }");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Selecione um zoológico primeiro!");
            }
        }
        public static void MostrarMenu()
        {
            int comando = 9;
            do {
                Console.WriteLine("Bem-vindo ao sistema de gestão Zoo-logic! Digite o comando desejado:\n" +
                "0 - Escolher Zoológico\n" +
                "1 - Listar Animais\n" +
                "2 - Inserir Animal\n" +
                "3 - Remover Animal\n" +
                "9 - Sair");
                comando = int.Parse(Console.ReadLine());
                switch (comando)
                {
                    case 0:
                        ListarZoologicos();
                        SelecionarZoologico();
                        break;
                    case 1:
                        ListarAnimais(zoologicoSelecionado);
                        break;
                    case 2:
                        InserirAnimal();
                        break;
                    case 3:
                        RemoverAnimal();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Comando inválido!");
                        break;
                }
            }
            while (comando != 9);
        }

        private static void SelecionarZoologico()
        {
            int zooIndex = -1;
            do
            {
                Console.WriteLine($"Digite o número do zoológico a ser selecionado:");
                zooIndex = int.Parse(Console.ReadLine());
                if(zooIndex < 0 || zooIndex > Zoologicos.Count-1)
                {
                    Console.WriteLine("Zoológico inexistente");
                }
                else
                {
                    zoologicoSelecionado = Zoologicos[zooIndex];
                    Console.WriteLine($"Zoológico selecionado:\n" +
                        $"{zooIndex} - {zoologicoSelecionado.Nome} " +
                        $"Qtd. Animais:{zoologicoSelecionado.Animais.Count} " +
                        $"Capacidade:{zoologicoSelecionado.Capacidade}");
                }
            } while (zooIndex < 0 && zooIndex >= Zoologicos.Count);

        }

        private static void ListarZoologicos()
        {
            Console.WriteLine($"======Todos os Zoológicos========");
            foreach (Zoologico z in Zoologicos)
            {
                Console.WriteLine($"{Zoologicos.IndexOf(z)} - {z.Nome} " +
                    $"Qtd. Animais:{z.Animais.Count} Capacidade:{z.Capacidade}");
            }
            if (zoologicoSelecionado != null)
            {
                Console.WriteLine($".....Zoológico selecionado: {zoologicoSelecionado.Nome}");
            }
            else
            {
                Console.WriteLine($".....Zoológico selecionado: NENHUM");
            }
            Console.WriteLine();
        }

        public static void InserirAnimal()
        {
            if(zoologicoSelecionado != null)
            {
                Console.WriteLine("Digite o nome do animal:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a espécie do animal:");
                string especie = Console.ReadLine();
                Console.WriteLine("Digite o peso do animal:");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do animal:");
                int altura = int.Parse(Console.ReadLine());
                Animal a = new Animal(nome, especie, peso, altura);
                if (zoologicoSelecionado.InserirAnimal(a))
                {
                    Console.WriteLine($"Animal {a.Nome} inserido com sucesso em " +
                        $"{zoologicoSelecionado.Nome}");
                    Console.WriteLine($"Número de animais cadastrados: {Animal.QuantidadeAnimaisGlobal}");
                }
                else
                {
                    Console.WriteLine($"O zoológico {zoologicoSelecionado.Nome} está lotado!");
                }
            }
            else
            {
                Console.WriteLine("Selecione um zoológico primeiro!");
            }
        }
        public static void RemoverAnimal()
        {
            if (zoologicoSelecionado != null)
            {
                Console.WriteLine("Digite o nome do animal:");
                string nome = Console.ReadLine();
                Animal a = zoologicoSelecionado.BuscarAnimal(nome);
                if (zoologicoSelecionado.RemoverAnimal(a))
                {
                    Console.WriteLine($"Animal {a.Nome} removido com sucesso de " +
                        $"{zoologicoSelecionado.Nome}");
                }
                else
                {
                    Console.WriteLine($"Animal não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Selecione um zoológico primeiro!");
            }
        }
    }
}
