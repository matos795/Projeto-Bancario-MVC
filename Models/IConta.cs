namespace SistemaBancario.Models
{
    public interface IConta
    {
        bool ValidarAbertura();

        string ExibirResumo();
    }
}
