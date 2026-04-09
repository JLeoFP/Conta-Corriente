namespace ContaCorriente.ConsoleApp;

class ContaCorriente
{
    public int numId;
    public string? titular;
    public decimal saldo;
    public decimal limiteDebito;

    public bool Sacar(decimal valorSaque)
    {
        if (valorSaque > saldo + limiteDebito)
            return false;
        
        saldo -= valorSaque;
        
        return true;
    }
    public void Depositar(decimal valorDeposito)
    {
        saldo += valorDeposito;
    }

    public bool TransfTo(ContaCorriente contaDestino, decimal valorTransferencia)
    {
        bool conseguirSacar = this.Sacar(valorTransferencia);

        if(!conseguirSacar)
            return false;

        contaDestino.Depositar(valorTransferencia);

        return true;
    }
    public decimal ShowSaldo()
    {
        return saldo;
    }  
}
