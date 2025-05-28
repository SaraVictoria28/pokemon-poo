// See https://aka.ms/new-console-template for more information
using System;
using pokemonn;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Pokemon charmander = new Pokemon("Charmander", 8.5, 0.6);

            Tipo fogo = new Tipo("Fogo");
            Tipo voador = new Tipo("Voador");
            Tipo meele = new Tipo("Meele");
            
            charmander.Tipo.Add(fogo);
            charmander.Tipo.Add(voador);

            var ataque1 = new Ataque("Explosão de Fogo", fogo, 110, 0.85, 0, "Especial");
            var ataque2 = new Ataque("FirePunch", meele, 0, 1.0, 0, "Status");
            var ataque3 = new Ataque("Lança chama", fogo, 60, 0.95, 0, "Especial"); 

            charmander.AprenderAtaque(ataque1);
            charmander.AprenderAtaque(ataque2);
            charmander.AprenderAtaque(ataque3);
            
            charmander.Apresentar();
        }
    }
}
