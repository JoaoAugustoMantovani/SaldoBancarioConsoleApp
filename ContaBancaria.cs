public class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public bool Depositar(double valor)
    { 
        
        if (valor > 0)
        {
            Saldo += valor;
            return true;
        }
        else
            return false;

    }
    public bool Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        else
            return false;
    }

    public double ExibirSaldo()
    {
        return Saldo;
    }
}

