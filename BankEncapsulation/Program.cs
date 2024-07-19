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
                var userPass = int.Parse(Console.ReadLine());
                if (myBankAccount.UserPassword(userPass))
                {
                    myBankAccount.Interface();
                    exit = true;
                }
                else if (!myBankAccount.UserPassword(userPass))
                {
                    Console.WriteLine("Invalid Password");
                }
            }
        }
    }
}
