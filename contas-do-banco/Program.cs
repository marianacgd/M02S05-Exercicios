

using contas_do_banco.Service;

IClienteService clienteService = new ClienteService();

string opcao;

do{
    Console.WriteLine("\n\nBem Vindo ao banco Fullstack, Escolha uma opção para continuar: ");
    Console.WriteLine("1 - Abrir Conta");
    Console.WriteLine("2 - Consultar Conta");
    Console.WriteLine("3 - Listar Todas as contas");
    Console.WriteLine("4 - Sair\n");
    opcao = Console.ReadLine();
    SelecaoMenu(opcao);
    
}while(opcao != "4");


void SelecaoMenu(string opcao){
  switch(opcao){
    case "1": 
      clienteService.CriarConta();
      break;
    case"2": 
      Console.Write("Digite o Numero da conta:");
      int numeroConta = int.Parse(Console.ReadLine());
      var cliente = clienteService.BuscarClientePorNumeroDeConta(numeroConta);
      if (cliente == null){
        Console.WriteLine("Conta não Cadastrada");
      }
      else{
        Console.WriteLine(cliente.ResumoCliente());
      }
      break;
    case"3":
      clienteService.ExibirClientes();
      break;
    case "4":
      break;
    default: 
      Console.WriteLine("Opção Inválida");
      break;
  }
}