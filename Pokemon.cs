using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemonn
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public List<Ataque> Ataque { get; set; } = new List<Ataque>();
        public List<Tipo> Tipo { get; set; } = new List<Tipo>();

        public Pokemon(string nome, double peso, double altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            Tipo = new List<Tipo>();
            Ataque = new List<Ataque>();
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, sou {Nome}!");
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Altura: {Altura} m ");
            Console.WriteLine("Ataque: ");
            foreach (var ataque in Ataque)
            {
                Console.WriteLine($"    -{ataque.Nome}");
            }
            Console.WriteLine("Tipo: ");
            foreach (var tipo in Tipo)
            {
                Console.WriteLine($"    -{tipo.Nome}");
            }
        }

        public void AprenderAtaque(Ataque novoAtaque)
        {
            if (Ataque.Count < 4)
            {
                Ataque.Add(novoAtaque);
            }
            else
            {
                Console.WriteLine($"{Nome} já conhece o máximo de 4 ataques.");
            }
        }
        public void RemoverAtaque(string nomeAtaque)
        {
            foreach (var ataque in Ataque)
            {
                if (ataque.Nome == nomeAtaque)
                {
                    Ataque.Remove(ataque);
                    break;
                }
            }
        }
    }
}