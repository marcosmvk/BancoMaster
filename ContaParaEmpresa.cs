

namespace BancoMaster
{
    internal class ContaParaEmpresa : Conta
    {
        //Campo
        private double  limite;

        //Propriedade
        public double  LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Consrutores
        public ContaParaEmpresa(int numeroConta, string titularConta, double limiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public ContaParaEmpresa(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        //Método
        public void Emprestimo(double quantia)
        {
            LimiteEmprestimo -= quantia;
            SaldoConta += quantia;

        }
     
    }
}
