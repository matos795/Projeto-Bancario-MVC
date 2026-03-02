namespace SistemaBancario.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string nome, decimal saldoInicial) : base(nome, "Poupança", saldoInicial)
        {
        }

        public override bool ValidarAbertura()
        {
            return Saldo >= 100.00m;
        }
    }
}
