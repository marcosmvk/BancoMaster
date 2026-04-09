

namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        //Campo
        private double taxa;

        //Propriedade
        public double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = value; }
        }

        //Construtores
        public ContaPoupanca(int numeroConta, string titularConta, double taxaJuros) : base(numeroConta, titularConta)
        {
            TaxaDeJuros = taxaJuros;
        }

        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta, double taxaJuros) : base(numeroConta, titularConta, saldoConta)
        {
            TaxaDeJuros = taxaJuros;
        }

        //Métodos 
        public void AtualizacaoDeSaldo()
        {
            SaldoConta = SaldoConta + (SaldoConta * TaxaDeJuros);
        }
        public override void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

    }
}
