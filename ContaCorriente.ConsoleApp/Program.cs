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

        Display interFace = new Display();
        ContaCorriente contaAcessada = conta1;

        while (true)
        {
            string? optionMenu = interFace.ShowMenu(contaAcessada);

            if(optionMenu == "S")
            {
                break;
            }
            
            if(optionMenu == "1")
            {   
                interFace.ShowOpeSaque(contaAcessada);
            }
            else if(optionMenu == "2")
            {
                interFace.ShowDeposito(contaAcessada);
            }
            else if(optionMenu == "3")
            {  
               interFace.ShowTransfTo(contaAcessada,contaDestino:conta2);
            }
            else if(optionMenu == "4")
            {
                interFace.ShowOpeSaldo(contaAcessada);
            }
        }
    }           
            
}
