namespace ContaCorriente.ConsoleApp;

class Display
{  
    public string? ShowMenu(ContaCorriente contaAcessada)
    {
        Console.WriteLine("==================================");
        Console.WriteLine($"Conta Corriente #:{contaAcessada.numId} de {contaAcessada.titular}");
        Console.WriteLine("==================================");
        Console.WriteLine("1 - Saque");
        Console.WriteLine("2 - Deposito");
        Console.WriteLine("3 - Transferencia");
        Console.WriteLine("4 - Consulta de Saldo");
        Console.WriteLine("S - Sair");
        string? optionMenu = Console.ReadLine()?.ToUpper();

        return optionMenu;
    }

     public void ShowOpeSaque(ContaCorriente contaAcessada)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja sacar (R$): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        bool conseguiuSacar = contaAcessada.Sacar(valorSaque);

        if (!conseguiuSacar)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("O valor do limite de débito foi ultrapassado!");
        }
        else
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("O valor foi sacado com sucesso!");
        }

        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
    public void ShowDeposito(ContaCorriente contaAcessada)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja depositar (R$): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        contaAcessada.Depositar(valorDeposito);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor foi depositado com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
    public void ShowTransfTo(ContaCorriente contaAcessada, ContaCorriente contaDestino)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja transferir (R$): ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        bool conseguiuTransferir = contaAcessada.TransfTo(contaDestino, valorTransferencia);

        if (!conseguiuTransferir)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Não foi possível transferir o valor de R${valorTransferencia}!");
        }
        else
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"O valor de R${valorTransferencia} foi tranferido com sucesso!");
        }

        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void ShowOpeSaldo(ContaCorriente contaAcessada)
    {
        decimal saldo = contaAcessada.ShowSaldo();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor do saldo da conta é de (R$): " + saldo);
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}
