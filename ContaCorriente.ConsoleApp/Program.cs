using System.Security.Cryptography;

namespace ContaCorriente.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {   //conta 1

        ContaCorriente conta1 = new ContaCorriente();
        conta1.numId = 1;
        conta1.titular="Leonardo";
        conta1.saldo=1000;
        conta1.limiteDebito=1200;
       
       

       //conta 2
        ContaCorriente conta2 = new ContaCorriente();
        conta2.numId=2;
        conta2.titular="Roberto";
        conta2.saldo=12000;
        conta2.limiteDebito=1200;
       


        while (true)
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Conta Corriente #:{conta1.numId} de {conta1.titular}");
            Console.WriteLine("==================================");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Deposito");
            Console.WriteLine("3 - Transferencia");
            Console.WriteLine("4 - Consulta de Saldo");
            Console.WriteLine("S - Sair");
            string? optionMenu = Console.ReadLine()?.ToUpper();

            if(optionMenu == "S")
            {
                break;
            }
            if(optionMenu == "1")
            {
                conta1.Sacar();
            }
            else if (optionMenu == "2")
            {
                conta1.Depositar();
            }
            else if (optionMenu == "3")
            {
                conta1.TransfTo(conta2);
            }
            else if (optionMenu == "4")
            {
                conta1.ShowSaldo();
            }
        }
    }           
            
}
