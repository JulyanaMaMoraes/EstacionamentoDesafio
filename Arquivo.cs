using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoDesafio
{
    internal class Arquivo
    {
        readonly static string entradaFilePath = "veiculosEntrada.dat";
        readonly static string saidaFilePath = "veiculosSaida.dat";

        public static List<Veiculo> LerArqVeiculosEntrada()
        {
            List<Veiculo> veiculosEntrada = new List<Veiculo>();

            try
            {
                StreamReader reader = new StreamReader("veiculosEntrada.dat");
                string linha;

                while ((linha = reader.ReadLine()) != null)
                {
                    string[] vetorLinha = linha.Split(';');
                    string placa = vetorLinha[0];
                    string dataEntrada = vetorLinha[1];
                    string horaEntrada = vetorLinha[2];

                    DateTime.TryParse(dataEntrada, out DateTime dtEntrada);
                    DateTime.TryParse(horaEntrada, out DateTime hrEntrada);

                    Veiculo veiculo = new Veiculo(placa, dtEntrada, hrEntrada);
                    veiculosEntrada.Add(veiculo);
                }

                reader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo veiculos entrada");
            }

            return veiculosEntrada;
        }

        public static List<Veiculo> LerArqVeiculosSaida()
        {
            List<Veiculo> veiculosSaida = new List<Veiculo>();

            try
            {
                StreamReader reader = new StreamReader("veiculosSaida.dat");
                string linha;

                while ((linha = reader.ReadLine()) != null)
                {
                    string[] vetorLinha = linha.Split(';');
                    string placa = vetorLinha[0];
                    int tempoEstacionadoMinutos = int.Parse(vetorLinha[1]);
                    double valorPagar =double.Parse(vetorLinha[2]);

                    Veiculo veiculo = new Veiculo(placa, DateTime.MinValue, DateTime.MinValue);
                    veiculo.TempoEstacionado = TimeSpan.FromMinutes(tempoEstacionadoMinutos);
                    veiculo.ValorPagar = valorPagar;

                    veiculosSaida.Add(veiculo);
                }

                reader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo veiculos saída");
            }

            return veiculosSaida;
        }

        public static void GravarArqVeiculoEntrada(List<Veiculo> veiculos)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

                foreach (Veiculo veiculo in veiculos)
                {
                    string linha = $"{veiculo.Placa};{veiculo.DEntrada};{veiculo.HEntrada}";
                    escritor.WriteLine(linha);
                }

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas ao gravar arquivo veiculosEntrada.dat");
            }
        }

        public static void GravarArqVeiculoSaida(List<Veiculo> veiculos)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

                foreach (Veiculo veiculo in veiculos)
                {
                    string linha = $"{veiculo.Placa};{veiculo.TempoEstacionado.ToString()};{veiculo.ValorPagar}";
                    escritor.WriteLine(linha);
                }

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas ao gravar arquivo veiculosSaida.dat");
            }
        }

    }
}