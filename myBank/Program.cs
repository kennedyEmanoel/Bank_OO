using System;
namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteCarlinhos = new Gerente
            {
                Nome = "Carlinhos",
                CPF = "987.987.987-98",
                Salario = 7620
            };

            Vendedor funcionarioDavid = new Vendedor
            {
                Nome = "David Vélez",
                CPF = "220.965.478-57",
                Salario = 5200
            };

            Vendedor funcionarioRubens = new Vendedor
            {
                Nome = "Rubens Menin",
                CPF = "013.255.636-76",
                Salario = 2700
            };

            Vendedor funcionarioSteve = new Vendedor
            {
                Nome = "Steve",
                CPF = "012.550.821-24",
                Salario = 2011
            };

            ContaCorrente TioPatinhas = new ContaCorrente("Tio Patinhas", 1111, 34317996, funcionarioRubens); /* Funcionário Rubens Menin */
            ContaCorrente Kennedy = new ContaCorrente("Kennedy Emanoel da Silveira Barbosa", 1234, 106, funcionarioDavid); /* Funcionário David Vélez*/
            ContaCorrente ElonMusk = new ContaCorrente("Elon Musk", 1235, 108418728, funcionarioSteve); /* Funcionário Steve*/

            Console.WriteLine("*****Funcionário*****");
            Console.WriteLine("Nome: " + funcionarioDavid.Nome);
            Console.WriteLine("Nome: " + funcionarioRubens.Nome);
            Console.WriteLine("Nome: " + funcionarioSteve.Nome);
            Console.WriteLine("Nome: " + gerenteCarlinhos.Nome);  
            Console.WriteLine("");

            Console.WriteLine("O Vendedor " + funcionarioDavid.Nome + " abriu uma conta corrente para o cliente: " + Kennedy.Titular); 
            Console.WriteLine("O Vendedor " + funcionarioRubens.Nome + " abriu uma conta corrente para o cliente: " + TioPatinhas.Titular); 
            Console.WriteLine("O Vendedor " + funcionarioSteve.Nome + " abriu uma conta corrente para o cliente: " + ElonMusk.Titular);
            Console.WriteLine("");

            Console.WriteLine("A bonificação anual do funcionário " + funcionarioDavid.Nome + " é de: R$ " + funcionarioDavid.RemuneracaoTotal(funcionarioDavid.Bonificacao));
            Console.WriteLine("A remuneração anual do funcionário " + funcionarioDavid.Nome + " é de : R$ " + funcionarioDavid.RemuneracaoTotal(funcionarioDavid.Salario));
            Console.WriteLine("A quantia de férias que o funcionário terá é de: " + funcionarioDavid.CalcularFerias() + " dias");
            Console.WriteLine("");

            Console.WriteLine("A bonificação anual do funcionário " + funcionarioRubens.Nome + " é de: R$ " + funcionarioRubens.RemuneracaoTotal(funcionarioRubens.Bonificacao));
            Console.WriteLine("A remuneração anual do funcionário " + funcionarioRubens.Nome + " é de : R$ " + funcionarioRubens.RemuneracaoTotal(funcionarioRubens.Salario));
            Console.WriteLine("A quantia de férias que o funcionário terá é de: " + funcionarioRubens.CalcularFerias() + " dias");
            Console.WriteLine("");

            Console.WriteLine("A bonificação anual do funcionário " + funcionarioSteve.Nome + " é de: R$ " + funcionarioSteve.RemuneracaoTotal(funcionarioSteve.Bonificacao));
            Console.WriteLine("A remuneração anual do funcionário " + funcionarioSteve.Nome + " é de : R$ " + funcionarioSteve.RemuneracaoTotal(funcionarioSteve.Salario));
            Console.WriteLine("A quantia de férias que o funcionário terá é de: " + funcionarioSteve.CalcularFerias() + " dias");
            Console.WriteLine("");

            Console.WriteLine("A bonificação anual do funcionário " + gerenteCarlinhos.Nome + " é de: R$ " + gerenteCarlinhos.RemuneracaoTotal(gerenteCarlinhos.Bonificacao));
            Console.WriteLine("A remuneração anual do funcionário " + gerenteCarlinhos.Nome + " é de : R$ " + gerenteCarlinhos.RemuneracaoTotal(gerenteCarlinhos.Salario));
            Console.WriteLine("A quantia de férias que o funcionário terá é de: " + gerenteCarlinhos.CalcularFerias() + " dias");
            Console.WriteLine("");
            Console.WriteLine("O total de contas criadas é " + ContaCorrente.TotalDeContasCriadas);


        }
    }
}





















/* Console.WriteLine("*****Funcionário*****");
            Console.WriteLine("Nome: " + funcionarioDavid.Nome);
            Console.WriteLine("CPF: " + funcionarioDavid.CPF);
            Console.WriteLine("Cargo: " + funcionarioDavid.Cargo);
            Console.WriteLine("Salário: R$ " + funcionarioDavid.Salario);
            Console.WriteLine("");

            Console.WriteLine("*****Funcionário*****");
            Console.WriteLine("Nome: " + funcionarioRubens.Nome);
            Console.WriteLine("CPF: " + funcionarioRubens.CPF);
            Console.WriteLine("Cargo: " + funcionarioRubens.Cargo);
            Console.WriteLine("Salário: R$ " + funcionarioRubens.Salario);
            Console.WriteLine("");

            Console.WriteLine("******Clientes******");
            Console.WriteLine("Titular: " + TioPatinhas.Titular + " | Saldo : " + TioPatinhas.Saldo);
            Console.WriteLine("Titular: " + Kennedy.Titular + "      | Saldo : " + Kennedy.Saldo);
            Console.WriteLine("Titular: " + ElonMusk.Titular + "    | Saldo : " + ElonMusk.Saldo);
            Console.WriteLine("");

            Console.WriteLine("A comissão do vendedor David é " + Math.Round(funcionarioDavid.Comissao, 2) + " R$");
            Console.WriteLine("A comissão do vendedor Rubens é " + Math.Round(funcionarioRubens.Comissao, 2) + " R$");

            Console.WriteLine("");
            Console.WriteLine("*******Sacar*******");
            Console.WriteLine("Saldo da conta do Tio Patinnhas é " + TioPatinhas.Saldo + " R$");
            Console.WriteLine("Sacar 4500 R$");
            TioPatinhas.Sacar(4500);
            Console.WriteLine("Saldo da conta do Tio Patinnhas é " + TioPatinhas.Saldo + " R$");
            Console.WriteLine("");

            Console.WriteLine("*****Depositar*****");
            Console.WriteLine("Saldo da conta do Kennedy é " + Kennedy.Saldo);
            Console.WriteLine("Depositar 4500 R$");
            Kennedy.Depositar(4500);
            Console.WriteLine("Saldo da conta do Kennedy é " + Kennedy.Saldo);
            Console.WriteLine("");

            Console.WriteLine("****Transferir****");
            Console.WriteLine("Saldo da conta do Elon Musk é " + ElonMusk.Saldo + " R$");
            Console.WriteLine("Saldo da conta do Kennedy " + Kennedy.Saldo + " R$");
            Console.WriteLine("Transferir 12500 R$ da conta do Elon Musk para conta do Kennedy");
            ElonMusk.Transferir(12500, Kennedy);
            Console.WriteLine("Saldo da conta do Elon Musk é " + ElonMusk.Saldo + " R$");
            Console.WriteLine("Saldo da conta do Kennedy " + Math.Round(Kennedy.Saldo, 2) + " R$");
            Console.WriteLine("");

            Console.WriteLine("O total de contas criadas é " + ContaCorrente.TotalDeContasCriadas); */