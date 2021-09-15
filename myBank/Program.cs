using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente TioPatinhas = new ContaCorrente("Tio Patinhas", 1111, 2222, 343179960000);
            ContaCorrente ContaDoKennedy = new ContaCorrente("Kennedy", 1234, 798, 11);
            ContaCorrente ContaDoJoao = new ContaCorrente("João", 1235, 758, 1901);
        
            Console.WriteLine("O Titular da conta é: " + ContaDoKennedy.titular + " || saldo: " + ContaDoKennedy.saldo);

            bool retorno = ContaDoKennedy.Sacar(10);
            Console.WriteLine("O saldo da conta do Kennedy é: " + ContaDoKennedy.saldo);

            Console.WriteLine("O saldo da conta do Tio Patinhas é de: " + TioPatinhas.saldo);

            TioPatinhas.Transferir(2000, ContaDoKennedy);
            Console.WriteLine("O saldo da conta do Kennedy é de: " + ContaDoKennedy.saldo);
            Console.WriteLine("O saldo da conta do Tio Patinhas é de: " + TioPatinhas.saldo);
        }
    }
}