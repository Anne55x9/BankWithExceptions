using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new bank account with 25 % interest rate
            // (is that legal...?)

            try
            {
                BankAccount theAccount = new BankAccount(19.0);
 
            try
            {
                theAccount.Deposit(2000);
            }
            catch (NegativeAmountException)
            {
                Console.WriteLine("You tried to Deposit a negative amount");
            }


            // Should this be legal...?
            try
            {
                theAccount.Deposit(-1000);
            }
            catch  (NegativeAmountException)
            {
                Console.WriteLine("You tried to Deposit a negative amount");
            }


                // Try to withdraw...
             try
            {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
            }

           

            Console.WriteLine("Balance is now : " + theAccount.GetBalance());

            }
            catch (IllegalInterestRateException)
            {
                Console.WriteLine("Illegal interest rate");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
