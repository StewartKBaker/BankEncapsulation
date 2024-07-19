using System.Reflection.Metadata;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myBankAccount = new BankAccount();
            
            Console.WriteLine("(Password is 92615)\nHello and welcome to Bank of America!\nUsername: ILoveMoney22\nPassword: ");
            bool exit = false;
            while (!exit)
            {
                var userPass = (Console.ReadLine());
                if (!int.TryParse(userPass, out int input))
                {
                    Console.WriteLine("Please input a valid number.");
                }
                else if (myBankAccount.UserPassword(input))
                {
                    myBankAccount.Interface();
                    exit = true;
                }
                else if (!myBankAccount.UserPassword(input))
                {
                    Console.WriteLine("Invalid Password");
                }
            }
        }
    }
}
