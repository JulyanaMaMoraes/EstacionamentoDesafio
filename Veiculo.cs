using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoDesafio
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        public DateTime DEntrada { get; set; }
        public DateTime HEntrada { get; set; }
        public TimeSpan TempoEstacionado { get; set; }
        public double ValorPagar { get; set; }

        public Veiculo(string placa, DateTime hEntrada, DateTime dEntrada)
        {
            Placa = placa;
            HEntrada = hEntrada;
            DEntrada = dEntrada;
        }
    }
}
