using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contas_do_banco.Model;

namespace contas_do_banco.Service
{
    public class ClienteService : IClienteService
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public Cliente? BuscarClientePorNumeroDeConta(int numeroConta)
        {
            return clientes.Find(w => w.NumeroConta == numeroConta);
        }

        public void CriarConta()
        {
            Console.WriteLine("Qual o tipo de conta que deseja Criar? ");
            Console.WriteLine("1 - Pessoa Física ");
            Console.WriteLine("2 - Pessoa Jurídica ");
            
            var opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 1 ){
                CriarContaPessoaFisica();
            }
            else if (opcao == 2){
                CriarContaPessoaJuridica();
            }
            else {
                Console.WriteLine("Opção inválida");
            }
        }

        public void ExibirClientes()
        {
            foreach (var cliente in clientes){
                Console.WriteLine(cliente.ResumoCliente());
            }        }

        private static void CriarContaPessoaFisica(){
            var clientePF = new PessoaFisica();
            
            Console.WriteLine("Digite a Data de Nascimento");

            clientePF.DataNascimento = DateTime.Parse(Console.ReadLine());
            
            if(!clientePF.EhMaior()){
                Console.WriteLine("não é possivel criar conta para menor de idade");
                return;
            }

            Console.WriteLine("Digite o CPF");
            clientePF.CPF = Console.ReadLine();
            Console.WriteLine("Digite o Nome");
            clientePF.Nome = Console.ReadLine();
            
            clientePF =  (PessoaFisica)PreencheClientePai(clientePF);

            clientes.Add(clientePF);
        }

        private static void CriarContaPessoaJuridica(){
            var clientePj = new PessoaJuridica();
            Console.WriteLine("Digite o CNPJ");
            clientePj.CNPJ = Console.ReadLine();
            Console.WriteLine("Digite o Razão Social");
            clientePj.RazaoSocial = Console.ReadLine();
            
            clientePj = (PessoaJuridica)PreencheClientePai(clientePj);
            clientes.Add(clientePj);
        }

        private static Cliente PreencheClientePai(Cliente cliente){
            
            Console.WriteLine("Digite o Numero da conta ");
            cliente.NumeroConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Endereco");
            cliente.Endereco = Console.ReadLine();
            
            Console.WriteLine("Digite o Saldo");
            cliente.Saldo = Decimal.Parse(Console.ReadLine());
            return cliente;
        }
    }
}