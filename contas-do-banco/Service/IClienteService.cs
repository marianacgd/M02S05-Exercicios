using contas_do_banco.Model;

namespace contas_do_banco.Service
{
    public interface IClienteService
    {
        void CriarConta();
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void ExibirClientes();
    }
}