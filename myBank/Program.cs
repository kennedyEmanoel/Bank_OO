﻿using System;
namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioDavid = new Funcionario{
                Nome = "David Vélez",
                CPF = "220.965.478-57",
                Cargo = "Vendedor",
                Salario = 5200
            };
            
            Funcionario funcionarioRubens = new Funcionario{
                Nome = "Rubens Menin",
                CPF = "013.255.636-76",
                Cargo = "Vendedor",
                Salario = 2700
            };

            ContaCorrente TioPatinhas = new ContaCorrente("Tio Patinhas", 1111, 34317996, funcionarioRubens); /* Funcionário Rubens Menin */
            ContaCorrente Kennedy = new ContaCorrente("Kennedy", 1234, 71.74, funcionarioDavid); /* Funcionário David Vélez*/
            ContaCorrente ElonMusk = new ContaCorrente("Elon Musk", 1235, 108418728, funcionarioDavid); /* Funcionário David Vélez*/

            Console.WriteLine("*****Funcionário*****");
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
            Console.WriteLine("Transferir 12500 R$ da conta do Elon Musk para do Kennedy");        
            ElonMusk.Transferir(12500, Kennedy);
            Console.WriteLine("Saldo da conta do Elon Musk é " + ElonMusk.Saldo + " R$");
            Console.WriteLine("Saldo da conta do Kennedy " + Math.Round(Kennedy.Saldo, 2) + " R$");
            Console.WriteLine("");

            Console.WriteLine("O total de contas criadas é " + ContaCorrente.TotalDeContasCriadas); 
        }
    }
}