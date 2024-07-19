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
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("\nTo deposit, Press 1. \nTo withdraw, Press 2. \nTo check your balance, Press 3. \nFor customer support, Press 4.\nTo exit, Press 5");
        while (true)
        {
            var userInput = Console.ReadLine();
            switch (int.Parse(userInput))
            {
                case 1:
                    Console.WriteLine("\nHow much money would you like to deposit?");
                    var deposit = double.Parse(Console.ReadLine());
                    DepositMoney(deposit);
                    Console.WriteLine("Deposit Successful");
                    Console.WriteLine($"\nYour new balance is ${GetBalance()}");
                    break;
                
                case 2:
                    Console.WriteLine("\nHow much money would you like to withdraw?");
                    var withdraw = double.Parse(Console.ReadLine());
                    if (withdraw > _balance)
                    {
                        Console.WriteLine("\nCannot Withdraw, Insufficient Funds.");
                        break;
                    }
                    WithdrawMoney(withdraw);
                    Console.WriteLine("Withdraw Successful");
                    Console.WriteLine($"\nYour new balance is ${GetBalance()}");
                    break;
                
                case 3:
                    Console.WriteLine($"\nYour Current balance is ${GetBalance()}");
                    break;
                
                case 4:
                    Console.WriteLine("\nThe current wait time is approximately 4 hours, please hold.");
                    return;
                
                case 5:
                    return;
                
                default:
                    Console.WriteLine("Please input a valid number.");
                    break;
                
            }
             if (true) Console.WriteLine("1: Deposit / 2: Withdraw / 3: Check Balance / 4: Customer Support / 5: Exit");
        }
    }
}