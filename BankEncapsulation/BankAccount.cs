namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 14234;

    private double _userPassword = 92615;

    public bool UserPassword(double password)
    {
        return password == _userPassword;
    }
    
    public void DepositMoney(double m)
    {
        _balance += m;
    }

    public double GetBalance()
    {
        return _balance;
    }

    public void WithdrawMoney(double m)
    {
        _balance -= m;
    }

    public void Interface()
    {
        Console.WriteLine("\nHi Welcome to your bank account!");
        Console.WriteLine("\nTo deposit, Press 1. \nTo withdraw, Press 2. \nTo check your balance, Press 3. \nFor customer support, Press 4.\nTo exit, Press 5");
        bool exit = false;
        while (!exit)
        {
            var userInput = Console.ReadLine();
            switch (int.Parse(userInput))
            {
                case 1:
                    Console.WriteLine("How much money would you like to deposit?");
                    var deposit = double.Parse(Console.ReadLine());
                    DepositMoney(deposit);
                    Console.WriteLine($"\nYour new balance is ${GetBalance()}");
                    break;
                case 2:
                    Console.WriteLine("How much money would you like to withdraw?");
                    var withdraw = double.Parse(Console.ReadLine());
                    WithdrawMoney(withdraw);
                    Console.WriteLine($"\nYour new balance is ${GetBalance()}");
                    break;
                case 3:
                    Console.WriteLine($"Your Current balance is ${GetBalance()}");
                    break;
                case 4:
                    Console.WriteLine("The current wait time is approximately 4 hours, please hold.");
                    exit = true;
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please input a valid number.");
                    break;
            }
             if (!exit) Console.WriteLine("1: Deposit / 2: Withdraw / 3: Check Balance / 4: Customer Support / 5: Exit");
        }
    }
}