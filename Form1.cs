using System.Data;

namespace EstacionamentoDesafio
{
    public partial class Form1 : Form
    {
        private Garagem garagem;

        public Form1()
        {
            InitializeComponent();
            garagem = new Garagem();
            garagem.ObterVeiculosEntrada();

            garagem.ObterVeiculosSaida();
            AtualizarListasVeiculos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Controle dos veículos no Estacionamento";


            Entrada.Items.Add("AAA-0000");
            Entrada.Items.Add("BBB-1111");
            Entrada.Items.Add("CCC-2222");
        }



        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;

            DateTime horaAtual = DateTime.Now;
            TimeSpan horaInicio = new TimeSpan(7, 0, 0);
            TimeSpan horaFim = new TimeSpan(20, 0, 0);

            DateTime horarioInicio = horaAtual.Date + horaInicio;
            DateTime horarioFim = horaAtual.Date + horaFim;

            if (horaAtual < horarioInicio || horaAtual > horarioFim)
            {
                MessageBox.Show("O horario de funcionamento do Estacionamento é das 7hrs ás 20hrs.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            bool veiculoCadastrado = garagem.ObterVeiculosEntrada().Any(v => v.Placa == placa);
            if (veiculoCadastrado)
            {
                MessageBox.Show("O veículo já está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int VagasEstacionadas = garagem.ObterVeiculosEntrada().Count;
            if (VagasEstacionadas >= 50)
            {
                MessageBox.Show("O estacionamento atingiu o limite máximo de vagas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DateTime dEntrada = DateTime.Now;
            DateTime hEntrada = DateTime.Now;

            garagem.RegistroEntrada(placa, dEntrada, hEntrada);
            AtualizarListasVeiculos();


        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            Veiculo veiculoEntrada = garagem.ObterVeiculosEntrada().FirstOrDefault(v => v.Placa == placa);

            if (veiculoEntrada != null)
            {
                DateTime horaSaida = DateTime.Now;
                TimeSpan tempoEstacionado = horaSaida - veiculoEntrada.DEntrada;

                int tempoEstacionadoMinutos = (int)tempoEstacionado.TotalMinutes;
                int valorPagar = CalcularValorCobrado(tempoEstacionadoMinutos);

                garagem.RegistroSaida(placa, tempoEstacionadoMinutos, valorPagar);
                AtualizarListasVeiculos();
                LimparCampos();

                MessageBox.Show($"Valor a pagar é: R$ {valorPagar}", "Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veículo não foi encontrado na lista de entrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalcularValorCobrado(int tempoEstacionadoMinutos)
        {
            const int valorHora = 5;
            int valorPagar = (tempoEstacionadoMinutos <= 0) ? 0 : ((tempoEstacionadoMinutos / 60) + 1) * valorHora;
            return valorPagar;
        }

        private void AtualizarListasVeiculos()
        {
            Entrada.Items.Clear();
            Saída.Items.Clear();

            List<Veiculo> veiculosEntradaLista = garagem.ObterVeiculosEntrada();
            List<Veiculo> veiculosSaidaLista = garagem.ObterVeiculosSaida();

            foreach (Veiculo veiculo in veiculosEntradaLista)
            {
                Entrada.Items.Add($"{veiculo.Placa} - {veiculo.DEntrada} - {veiculo.HEntrada}");
            }

            foreach (Veiculo veiculo in veiculosSaidaLista)
            {
                Saída.Items.Add($"{veiculo.Placa} - {veiculo.TempoEstacionado} - {veiculo.ValorPagar}");
            }
        }

        private void LimparCampos()
        {
            txtPlaca.Text = string.Empty;
            txtPlaca.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans", 20);
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}