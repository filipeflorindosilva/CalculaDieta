using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculaDieta
{
    class dadospessoa
    {
        public string nome;
        public double peso, altura, idade;

        public dadospessoa(string no, double pe, double alt, double ida)
        {
            this.nome = no;
            this.peso = pe;
            this.altura = alt;
            this.idade = ida;
        }

        public double ResultadoHomenSedentario (double pe, double alt, double ida)
        {
            return ((66.5 + 13.5 * pe + 5 * alt - 6.8 * ida) * 1.2);
        }

        public double ResultadoHomenLeveAtivo(double pe, double alt, double ida)
        {
            return ((66.5 + 13.5 * pe + 5 * alt - 6.8 * ida) * 1.45);
        }

        public double ResultadoHomenModeradoAtivo(double pe, double alt, double ida)
        {
            return ((66.5 + 13.5 * pe + 5 * alt - 6.8 * ida) * 1.72);
        }

        public double ResultadoHomenAltaAtividade(double pe, double alt, double ida)
        {
            return ((66.5 + 13.5 * pe + 5 * alt - 6.8 * ida) * 1.82);
        }

        public double ResultadoHomenExtremaAtividade(double pe, double alt, double ida)
        {
            return ((66.5 + 13.5 * pe + 5 * alt - 6.8 * ida) * 2.1);
        }

        public double ResultadoMulherSedentaria (double pe, double alt, double ida)
        {
            return ((655 + 9.6 * pe + 1.8 * alt - 4.7 * ida) * 1.2);
        }

        public double ResultadoMulherLeveativa(double pe, double alt, double ida)
        {
            return ((655 + 9.6 * pe + 1.8 * alt - 4.7 * ida) * 1.375);
        }

        public double ResultadoMulherModeradaAtiva(double pe, double alt, double ida)
        {
            return ((655 + 9.6 * pe + 1.8 * alt - 4.7 * ida) * 1.64);
        }

        public double ResultadoMulherAltaAtividade(double pe, double alt, double ida)
        {
            return ((655 + 9.6 * pe + 1.8 * alt - 4.7 * ida) * 1.72);
        }

        public double ResultadoMulherExtremaAtividade(double pe, double alt, double ida)
        {
            return ((655 + 9.6 * pe + 1.8 * alt - 4.7 * ida) * 1.9);
        }
    }
}
