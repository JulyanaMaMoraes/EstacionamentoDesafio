using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoDesafio
{
    internal class Garagem
    {
    
    private List<Veiculo> veiculosEntrada;
    private List<Veiculo> veiculosSaida;
    
    public Garagem() 
        
        
        { 
        veiculosEntrada=Arquivo.LerArqVeiculosEntrada();
        veiculosSaida= Arquivo.LerArqVeiculosSaida();
        
        }
   
    public void RegistroEntrada(string Placa, DateTime DEntrada, DateTime HEntrada) 
        {
            Veiculo veiculo = new Veiculo (Placa, DEntrada, HEntrada);
            veiculosEntrada.Add(veiculo);
            Arquivo.GravarArqVeiculoEntrada(veiculosEntrada);
        
        
        }

        public void RegistroSaida(string Placa, int tempoEstacionadoMinutos, double valorPagar) 
        {
            Veiculo veiculoSaida = veiculosEntrada.FirstOrDefault(v => v.Placa == Placa);
          
            if (veiculoSaida != null)
            {
                veiculosEntrada.Remove(veiculoSaida);
                Veiculo veiculo = new Veiculo(Placa, veiculoSaida.HEntrada, veiculoSaida.DEntrada);
                veiculo.TempoEstacionado = TimeSpan.FromMinutes(tempoEstacionadoMinutos);
                veiculo.ValorPagar = valorPagar;
                
                veiculosSaida.Add(veiculo);
                Arquivo.GravarArqVeiculoEntrada(veiculosEntrada);
                Arquivo.GravarArqVeiculoSaida(veiculosSaida);
            }



     
        }

        public List<Veiculo> ObterVeiculosEntrada()
        {
            return veiculosEntrada;
        }

        public List<Veiculo> ObterVeiculosSaida()
        {
            return veiculosSaida;
        }


    }
}
