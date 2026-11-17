ContaBancaria cb;
cb = CriarConta();
ContaBancaria CriarConta()
{

    Console.WriteLine("Insira seu nome: ");
    string titular = Console.ReadLine();
    Console.WriteLine("Insira Saldo inicial");
    double saldo = double.Parse(Console.ReadLine());

    ContaBancaria cb = new(titular, saldo);

    return cb;
}

Console.WriteLine("Saldo Incial: ");
Console.WriteLine(cb.ExibirSaldo()); 
Console.ReadKey();

Console.WriteLine("Depósito de 50");
cb.Depositar(50.0);
Console.WriteLine(cb.ExibirSaldo());
Console.ReadKey();


Console.WriteLine("Saque de 10,25");
cb.Sacar(10.25);
Console.WriteLine(cb.ExibirSaldo());
Console.ReadKey();
Console.WriteLine(cb.ToString());
