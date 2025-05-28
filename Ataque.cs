using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemonn
{
    public class Ataque
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public double Poder { get; set; }
        public double Precisao { get; set; }
        public int Prioridade{get; set; }
        public string Categoria { get; set; }


        public Ataque(string nome,Tipo tipo, double poder, double precisao, int prioridade, string categoria)
        {
            Nome = nome;
            Tipo = tipo;
            Poder = poder;
            Precisao = precisao;
            Precisao = prioridade;
            Categoria = categoria;
        }
        public bool VerificarSeAtaqueEspecial()
        {
            return Categoria == "Especial";
         }
        public bool VerificarSeAtaqueFisico()
        {
            return Categoria == "Físico";
        }
        public bool VerificarSeAtaqueDeStatus()
        {
            return Categoria == "Status";
        }
    }
}