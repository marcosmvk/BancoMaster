

namespace BancoMaster
{
    internal class Conta
    {
		//Campo
		private int numero;
		private string titular;
		private double saldo;

        //Propriedades
        public int NumeroConta
		{
			get { return numero; }
			set { numero = value; }
		}
		public string TitularConta
		{
			get { return titular; }
			set { titular = value; }
		}
		public double SaldoConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		//Construtores
        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }

        public Conta(int numeroConta, string titularConta):this(numeroConta, titularConta, 0) 
        {
            SaldoConta = 0;
        }

		//Métodos
		public virtual void Saque(double quantia)
		{
			SaldoConta -= quantia + 5.00;
		}

		public void Deposito(double quantia)
		{
			SaldoConta += quantia;
		}
        public virtual void Dados()
		{
			Console.WriteLine($"Dados da conta: \n " + 
				$"\tConta: {this.NumeroConta}\n" +
				$"\tTitular: { this.TitularConta}\n" +
				$"\tSaldo: {this.SaldoConta:C}");   
		}
            
    }
}
