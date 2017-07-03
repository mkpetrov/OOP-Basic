using System;
using System.Collections.Generic;

namespace DefineBankAccountClass
{
    class DefineBankAccountClass
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var accounts = new Dictionary<int, BankAccount>();

            while (input!="End")
            {
                var cmdArgs = input.Split();
                var cmdType = cmdArgs[0];
                switch (cmdType)
                {
                    case "Create":
                        Create(cmdArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(cmdArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(cmdArgs, accounts);
                        break;
                    case "Print":
                        Print(cmdArgs, accounts);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine($"Account ID{id}, balance {accounts[id].Balance:f2}");
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                if (int.Parse(cmdArgs[2]) > accounts[id].Balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(int.Parse(cmdArgs[2]));
                }
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(int.Parse(cmdArgs[2]));
            }
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
    }
}
