using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Tratamento_de_excesoes.Entities.Exceptions;
using Exercicio_Tratamento_de_excesoes.Entities;
using System.Globalization;

namespace Exercicio_Tratamento_de_excesoes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double lWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, lWithdraw);

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine("New balance $ "+account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }

            catch (DomainException e)

            {
                Console.WriteLine("Error withdraw: "+e.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
