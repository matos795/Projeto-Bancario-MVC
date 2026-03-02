namespace SistemaBancario.Models
{
    public class ContaCorrente :Conta
    {
        public ContaCorrente(string nome, decimal saldoInicial) : base(nome, "Corrente", saldoInicial)
        {
        }

        public override bool ValidarAbertura()
        {
            return true;
        }
    }
}
