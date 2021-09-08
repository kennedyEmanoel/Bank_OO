using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoKennedy = new ContaCorrente();

            ContaDoKennedy.titular = "Kennedy";
            ContaDoKennedy.agencia = 1234;
            ContaDoKennedy.conta = 798;
            ContaDoKennedy.saldo = 11;

            ContaCorrente ContaDoJoao = new ContaCorrente();

            ContaDoJoao.titular = "Joao";
            ContaDoJoao.agencia = 1234;
            ContaDoJoao.conta = 798;
            ContaDoJoao.saldo = 11;

            Console.WriteLine("O Titular da conta é o " + ContaDoKennedy.titular + " e o saldo da conta é " + ContaDoKennedy.saldo);
            ContaDoKennedy.saldo += 9;
            Console.WriteLine("O saldo da conta é " + ContaDoKennedy.saldo);
        }
    }
}
