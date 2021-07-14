using System;

namespace UnitTesting
{
    public class Program
    {

        //Balance stored here so other things can access it
        public static decimal Balance = 1000;

        public static void ResetBalance()
        {
            Balance = 1000;
        }

        //Basically only calls the user input
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your digital wallet!");
            UserInterface();
        }

        public static void UserInterface()
        {
            //Set up while loop to have the user inputs continue until stopped
            bool running = true;
            while (running)
            {

                //User prompt and read in response
                Console.WriteLine("\nWhat action would you like to perform?");
                Console.WriteLine("1) View Balance \n2) Make a Withdrawal\n3) Make a Deposit\n4) No More Transactions");
                int choice = Convert.ToInt32(Console.ReadLine());

                //Switch case to choose operation
                switch (choice)
                {
                    case 1:
                        string balanceOut = Convert.ToString(Balance);
                        Console.WriteLine($"Your balance currently is: {balanceOut}");
                        string responseView = Convert.ToString(ViewBalance());
                        break;

                    case 2:
                        Console.WriteLine("How much would you like to withdraw?");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        string responseWithdraw = Convert.ToString(Withdraw(withdrawAmount));
                        balanceOut = Convert.ToString(Balance);
                        Console.WriteLine($"You have withdrawn {withdrawAmount} from your account\nYou now have {balanceOut} in your account");
                        break;

                    case 3:
                        Console.WriteLine("How much would you like to deposit?");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        string responseDeposit = Convert.ToString(Deposit(depositAmount));
                        balanceOut = Convert.ToString(Balance);
                        Console.WriteLine($"You have deposited {depositAmount} from your account\nYou now have {balanceOut} in your account");
                        break;

                    case 4:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid selection");
                        break;
                }


            }
            
        }

        //ViewBalance to console write out stored value
        public static decimal ViewBalance()
        {
            //Test to ensure the balance properly displays the amount after each transaction.
            return Balance;
        }

        //Withdraw to take money from account
        public static decimal Withdraw(decimal value)
        {
            //can't withdraw a negative number
            //can't withdraw more than is in the account
            if(value < 0 || value > Balance)
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
            else
            {
                Balance = Balance - value;
            }

            return Balance;
        }

        //Deposit to add money to account
        public static decimal Deposit(decimal value)
        {
            //can't deposit a negative number

            if (value < 0)
            {
                Console.WriteLine("Invalid deposit amount");
            }
            else
            {
                Balance = Balance + value;
            }

            return Balance;
        }

    }
}
