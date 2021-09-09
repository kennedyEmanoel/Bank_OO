using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoKennedy = new ContaCorrente("Kennedy", 1234, 798, 11);

            ContaCorrente ContaDoJoao = new ContaCorrente("João", 1235, 758, 11);
        
            Console.WriteLine("O Titular da conta é: " + ContaDoKennedy.titular + " || saldo: " + ContaDoKennedy.saldo);
            Console.WriteLine("O saldo da conta é: " + ContaDoKennedy.saldo + " || saldo: " + ContaDoJoao.saldo);
        }
    }
}
