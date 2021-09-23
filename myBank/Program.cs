using System;
namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente TioPatinhas = new ContaCorrente("Tio Patinhas", 1111, 343179960000);
            ContaCorrente ContaDoKennedy = new ContaCorrente("Kennedy", 1234, 11);
            ContaCorrente ContaDoJoao = new ContaCorrente("João", 1235, 1901);

            ContaCorrente TioPatinhas1 = new ContaCorrente("Tio Patinhas", 1111, 343179960000);
            ContaCorrente ContaDoKennedy1 = new ContaCorrente("Kennedy", 1234, 11);
            ContaCorrente ContaDoJoao1 = new ContaCorrente("João", 1235, 1901);

            Console.WriteLine("O Saldo do Do Tio Patinhas é de: " + TioPatinhas.Saldo);

            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotalDeContasCriadas);
        }
    }
}