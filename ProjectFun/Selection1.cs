using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class Selection1
    {
        public static List<Transaction> transList = new List<Transaction>();
        

        public static int _checkingAcc = 0;
        public static int _cdAcc = 0;
        public static int _loanAcc = 0;
        public static int _businessAcc = 0;
        public static int _totalAccount = 0;
        public static int _transation = 0;
        public static int _AccountNumber;
       public static bool session = true;

        public static void Option3()
        {
            Transaction newTr = new Transaction();
            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\tc - Open Checking Account");
            Console.WriteLine("\tb - Open Business Account");
            Console.WriteLine("\tl - Loan Account");
            Console.WriteLine("\tt - Term Deposit Account");
            Console.WriteLine("\te - Exit");

            Console.Write("Your option? : ");
            string option1 = Console.ReadLine();

            while (string.IsNullOrEmpty(option1))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                option1 = Console.ReadLine();
            }


            if (option1 == "c")
            {
                if (_checkingAcc == 0)
                {
                    Account checking = new Account();

                    checking.setType("Checking");
                    newTr.Types = "Checking";
                    checking.setBalance(000);
                    Console.WriteLine("Please Enter the initial Balance for checking : ");
                    double intDeposit = Convert.ToDouble(Console.ReadLine());
                    checking.deposit(intDeposit);
                    checking.setRate(0.00);
                    Random random = new System.Random();
                    _AccountNumber = random.Next(999500, 11112500);
                    newTr.AccountNumber = _AccountNumber;
                    newTr.Amount = intDeposit;
                    Console.WriteLine("\nYour Account Number is : {0} Your Checking balance is now: ${1}  Interest Rate:{2} ", _AccountNumber, (checking.getBalance()), checking.getRate() + "%" + "\n\n");
                    var time = DateTime.Now;
                    newTr.DateTime = time;
                    _checkingAcc++;
                    _totalAccount++;
                    transList.Add(newTr);
                    foreach (var val in transList)
                    Console.WriteLine("Account Number: {0} Amount To be Deposited: {1} Date : {2} Types: {3}",  val.AccountNumber,val.Amount, val.DateTime, val.Types);
                    Console.WriteLine(time);
                    Selection sc3 = new Selection();
                    sc3.option3();
                    

                }
                else
                {
                    Console.WriteLine("You already have Checking account: ");

                }




            }
            else if (option1 == "b")
            {
                Account business = new Account();
                business.setType("Business");
                business.setBalance(000);
                business.setRate(0.00);
                Console.WriteLine("Please Enter the initial Balance : ");
                double intDeposit = Convert.ToDouble(Console.ReadLine());

                business.deposit(intDeposit);


                Random random = new System.Random();
                _AccountNumber = random.Next(999500, 11112500);
                Console.WriteLine("\nYour Account Number is : {0} Your Buiness Account balance is now: ${1}  Interest Rate:{2} ", _AccountNumber, (business.getBalance()), business.getRate() + "%" + "\n\n");


                // Console.WriteLine("\nYour Business Account balance is now: " + (business.getBalance()) + "\n");
                _businessAcc++;
                _totalAccount++;
                Selection sc3 = new Selection();
                sc3.option3();
            }
            else if (option1 == "l")
            {
                Account loan = new Account();
                loan.setType("Loan");
                loan.setBalance(000);
                loan.setRate(0.00);
                Console.WriteLine("Please Enter the initial Balance : ");
                double intDeposit = Convert.ToDouble(Console.ReadLine());

                loan.deposit(intDeposit);


                Random random = new System.Random();
                _AccountNumber = random.Next(999500, 11112500);
                Console.WriteLine("\nYour Account Number is : {0} Your Loan balance is now: ${1}  Interest Rate:{2} ", _AccountNumber, (loan.getBalance()), loan.getRate() + "%" + "\n\n");

                Console.WriteLine("\nYour Loan account balance is now: " + (loan.getBalance()) + "\n");
                _totalAccount++;
                _loanAcc++;
                Selection sc3 = new Selection();
                sc3.option3();
            }
            else if (option1 == "t")
            {
                Account termDeposit = new Account();
                termDeposit.setType("CD");
                termDeposit.setBalance(000);
                termDeposit.setRate(2.00);
                Console.WriteLine("Please Enter the initial Balance : ");
                double intDeposit = Convert.ToDouble(Console.ReadLine());
                termDeposit.deposit(intDeposit);

                Random random = new System.Random();
                _AccountNumber = random.Next(999500, 11112500);
                Console.WriteLine("\nYour Account Number is : {0} Your CD balance is now: ${1}  Interest Rate:{2} ", _AccountNumber, (termDeposit.getBalance()), termDeposit.getRate() + "%" + "\n\n");


                //Console.WriteLine("\nYour Term Account balance is now: " + (termDeposit.getBalance()) + "\n");
                _totalAccount++;
                _cdAcc++;
                Selection sc3 = new Selection();
                sc3.option3();
            }
            else if (option1 == "e")
            {
                Console.WriteLine("\n\n THANKS FOR USING OUR SERVICE ");
                session = false;
            }

            while (!(option1 == "c") || (option1 == "b") || (option1 == "l") || (option1 == "t") || (option1 == "e"))

            {
                Console.WriteLine("Please Enter the above option. ");
                option1 = Console.ReadLine();
            }


        }
    }
}
            


            




