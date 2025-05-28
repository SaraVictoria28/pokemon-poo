using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemonn
{
    public class Tipo
    {
        public string Nome { get; set; }

        public Tipo(string nome)
        {
            Nome = nome;
        }

        public List<string> ObterFraqueza()
        {
            List<string> fraqueza = new List<string>();
            switch (Nome)
            {
                case "fogo":
                    fraqueza.Add("água");
                    fraqueza.Add("terra");
                    fraqueza.Add("pedra");
                    break;

                case "água":
                    fraqueza.Add("elétrico");
                    break;

                case "normal":
                    fraqueza.Add("lutador");
                    break;

                case "elétrico":
                    fraqueza.Add("terra");
                    break;

                case "voador":
                    fraqueza.Add("elétrico");
                    fraqueza.Add("pedra");
                    break;
            }
            return fraqueza;
        }
        public List<string> Resistencias()
        {
            List<string> resistencias = new List<string>();
            switch (Nome)
            {
                case "fogo":
                    resistencias.Add("grama");
                    resistencias.Add("gelo");
                    break;
                case "água":
                    resistencias.Add("fogo");
                    resistencias.Add("água");
                    resistencias.Add("gelo");
                    break;
                case "normal":
                    resistencias.Add("Sem resistencia");
                    break;
                case "elétrico":
                    resistencias.Add("elétrico");
                    resistencias.Add("voador");
                    break;
                case "voador":
                    resistencias.Add("grama");
                    resistencias.Add("lutador");
                    break;
            }
            return resistencias;
        }
        public List<string> ObterImunidades()
        {
            List<string> imunidades = new List<string>();
            switch (Nome)
            {
                case "normal":
                    imunidades.Add("fantasma");
                    break;
                case "elétrico":
                    break;
                case "voador":
                    imunidades.Add("terra");
                    break;
            }
            return imunidades;
        }
    }
}