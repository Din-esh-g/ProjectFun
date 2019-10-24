using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
 
        public class Selection
        {
            public static int _checkingAcc = 0;
            public static int _cdAcc = 0;
            public static int _loanAcc = 0;
            public static int _businessAcc = 0;
            public static int _totalAccount = 0;            
            public static int _transation = 0;
            public static int _AccountNumber;
           Transaction newTr = new Transaction();
        public static List<Transaction> transList = new List<Transaction>();

        public Selection( )
        {

        }
      
        Account checking = new Account();
        Account business = new Account();
        Account loan = new Account();
        Account termDeposit = new Account();
        bool session = true;
        bool endApp = false;
    


        public void option0()
        {

            Console.WriteLine("Please Select from following option: ");


            Console.WriteLine("\tc - Do you want to continue with Registration ");

            Console.WriteLine("\te - Exit from application. ");

            Console.WriteLine("Your option? : ");
            string optiono = Console.ReadLine();

            while (string.IsNullOrEmpty(optiono))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                optiono = Console.ReadLine();
            }
            if (optiono == "c")
            {
                
               UserRegister.userDetails();
            }
            else if (optiono == "e")
            {
                endApp = true;
            }
            while (!(optiono == "c") || (optiono == "e"))
            {

                Console.WriteLine("Please Enter from the above option.  ");
                optiono = Console.ReadLine();


            }


        }
     
        public void option1()
        {
            
            Selection1.Option3();           

        }
            public void Option2()
            {

                while (session)
                {

                    // Present the user with a menu of 7 options

                    Console.Write("\nBank Application Menu: \n \n"
                                     + "1. Deposit Money \n"
                                     + "2. Withdraw Money \n"
                                     + "3. Transfer Funds \n"
                                     + "4. Check Account Balance\n"
                                     + "5. Display the transaction\n"
                                     + "6. Retuen to Previouse Menu\n"
                                     + "7. End Session\n \n"
                                     + "Enter selection: ");

                    String input = Console.ReadLine();
                    int selection;

                    // assign the user's input to the selection variable

                    // This switch block will handle one of five selections and deal with them appropriately

                    if (int.TryParse(input, out selection))
                    {

                        switch (selection)
                        {

                            // case 1 handles the depositing of money

                            case 1:
                                Console.Write("Enter (1) for Checking or (2) for Business or (3) for Term Deposit or (4) for Loan Account : ");

                                int depAccount = int.Parse(Console.ReadLine());
                                if (depAccount == 1)
                                {
                               

                                Console.WriteLine("\nYour current Checking balance is: " + (checking.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to deposit?");
                                    double deposit = Convert.ToDouble(Console.ReadLine());

                                    checking.deposit(deposit);

                                    Console.WriteLine("\nYour Savings balance is now: " + (checking.getBalance()) + "\n");

                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = deposit ;
                                newTr.Types ="Checking" ;
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);
                            }

                                else if (depAccount == 2)
                                {

                                    Console.WriteLine("\nYour current Business Account balance is: " + (business.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to deposit?");
                                    double deposit = Convert.ToDouble(Console.ReadLine());

                                    business.deposit(deposit);

                                    Console.WriteLine("\nBusiness Account balance is now: " + (business.getBalance()) + "\n");
                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = deposit;
                                newTr.Types = "Business";
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);

                            }
                                else if (depAccount == 3)
                                {

                                    Console.WriteLine("\nYour Term Deposit balance is: " + (termDeposit.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to repay?");
                                    double deposit = Convert.ToDouble(Console.ReadLine());

                                    termDeposit.deposit(deposit);

                                    Console.WriteLine("\nTerm Account balance is now: " + (termDeposit.getBalance()) + "\n");

                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = deposit;
                                newTr.Types = "Term Deposit";
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);

                            }

                                else if (depAccount == 4)
                                {

                                    if (_loanAcc > 0)
                                    {
                                        Console.WriteLine("\nYour current Loan balance is: " + (loan.getBalance()) + "\n");

                                        Console.WriteLine("How much money would you like to deposit?");
                                        double deposit = Convert.ToDouble(Console.ReadLine());

                                        loan.deposit(deposit);

                                        Console.WriteLine("\nLoan  balance is now: " + (loan.getBalance()) + "\n");
                                    newTr.AccountNumber = Selection1._AccountNumber;
                                    newTr.Amount = deposit;
                                    newTr.Types = "Loan";
                                    newTr.DateTime = DateTime.Now;
                                    transList.Add(newTr);

                                }
                                    else
                                    {
                                        Console.WriteLine("You Must need Loan Account to repay.");
                                    }

                                }

                                break;



                            // case 2 handles the withdrawal of money	

                            case 2:

                                Console.Write("Enter (1) for Checking or (2) for Business or (3) for Term Deposit or (4) for Loan Account : ");
                                int witAccount = int.Parse(Console.ReadLine()); // Keeps track of which account to withdraw from

                                if (witAccount == 1)
                                {

                                    Console.WriteLine("\nYour current Checking balance is: " + (checking.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to withdraw?");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    checking.withdraw(withdraw);

                                    Console.WriteLine("\nYour Checking balance is now: " + (checking.getBalance()) + "\n");
                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = withdraw;
                                newTr.Types = "Checking";
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);

                            }

                                else if (witAccount == 2)
                                {

                                    Console.WriteLine("\nYour current Business Account balance is: " + (business.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to withdraw?");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    business.withdraw(withdraw);

                                    Console.WriteLine("\nYour Business Account balance is now: " + (business.getBalance()) + "\n");
                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = withdraw;
                                newTr.Types = "Business";
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);

                            }
                                else if (witAccount == 3)
                                {

                                    Console.WriteLine("\nYour current Checking balance is: " + (termDeposit.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to withdraw?");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    termDeposit.withdraw(withdraw);

                                    Console.WriteLine("\nYour Checking balance is now: " + (termDeposit.getBalance()) + "\n");
                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = withdraw;
                                newTr.Types = "Term Deposit ";
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);

                            }
                                else if (witAccount == 4)
                                {

                                    Console.WriteLine("\nYour current Checking balance is: " + (loan.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to withdraw?");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    loan.withdraw(withdraw);

                                    Console.WriteLine("\nYour Checking balance is now: " + (loan.getBalance()) + "\n");
                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = withdraw;
                                newTr.Types = "Loan ";
                                newTr.DateTime = DateTime.Now;
                                transList.Add(newTr);

                            }

                                break;

                            // case 3 handles the transfer of funds	

                            case 3:
                                //Console.Write("\nFrom which account do you wish to transfer funds from?, (1) for Savings or (2) for Checking: ");
                                Console.Write("Enter (1) for Checking or (2) for Business Account");
                                // "(3) for Term Deposit or (4) for Loan Account : ");; ;
                                int tranAccount = int.Parse(Console.ReadLine());

                                if (tranAccount == 1)
                                {

                                    Console.WriteLine("\nYour current Current Account balance is: " + (checking.getBalance()) + "\n");

                                    Console.Write("How much money do you wish to transfer from Current to Business?: ");
                                    double tranAmount = Convert.ToDouble(Console.ReadLine());

                                    checking.withdraw(tranAmount);
                                    business.deposit(tranAmount);

                                    Console.WriteLine("\nYou successfully transferred " + (tranAmount) + " from Savings to Checking");

                                    Console.WriteLine("\nChecking Balance: " + (checking.getBalance()));
                                    Console.WriteLine("Business Balance: " + (business.getBalance() + "\n"));

                                }

                                else if (tranAccount == 2)
                                {

                                    Console.WriteLine("\nYour current Checking balance is: " + (business.getBalance()) + "\n");

                                    Console.Write("How much money do you wish to transfer from business to checking?: ");
                                    double tranAmount = Convert.ToDouble(Console.ReadLine());

                                    business.withdraw(tranAmount);
                                    checking.deposit(tranAmount);

                                    Console.WriteLine("\nYou successfully transferred " + (tranAmount) + " from Checking to Savings");

                                    Console.WriteLine("\nChecking Balance: " + (checking.getBalance()));
                                    Console.WriteLine("Business Balance: " + (business.getBalance()) + "\n");

                                }

                                break;

                            // case 4 simply outputs the balances of both Checking and Savings accounts	

                            case 4:
                                UserRegister rj1 = new UserRegister();

                                Console.WriteLine(rj1._firstName + " " + rj1._lastName + "You have Following account with balance.  ");
                                Console.WriteLine("\nChecking Balance: {0}  Interest Rate: {1}", (checking.getBalance()), checking.getRate() + "%");
                                Console.WriteLine("Business Account Balance: {0}  Interest Rate: {1}", (business.getBalance()), business.getRate() + "%" + "\n");
                                Console.WriteLine("\nLoan Balance: {0}  Interest Rate: {1}", (loan.getBalance()), loan.getRate() + "%");
                                Console.WriteLine("\nTerm Deposit Account Balance: {0}  Interest Rate: {1}", (termDeposit.getBalance()), termDeposit.getRate() + "%");

                                break;

                            case 5:
                            //Display the Account Informatio\n"

                            Console.WriteLine("Following Details found for user: \n ");
                            foreach (var val in Selection1.transList)
                            Console.WriteLine("Account Number: {0} Amout To be Deposited: {1} Date : {2} Types: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");
                            // Console.WriteLine("Now We see ");

                            foreach (var val in transList)
                                Console.WriteLine("Account Number: {0} Amout To be Deposited: {1} Date : {2} Types: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types+ "\n");
                            // Console.WriteLine("Now We see ");

                            break;
                            case 6:

                                option1();

                                break;


                            // case 5 breaks out of the (while) loop when the user is finished using the ATM

                            case 7:
                                session = false;

                                break;


                        }
                    }



                    else
                    {
                        Console.WriteLine("Please Enter the Option from above list.");//print error indicating non-numeric input is unsupported or something more meaningful.
                    }
                }
            }



        
            public void option3()
            {


                Console.WriteLine("\ta - Do you want to open account? ");
                Console.WriteLine("\tt - Do you want to make a transaction ");
                Console.WriteLine("\te - Exit from application. ");
                Console.Write("Your option? : ");
                string option3 = Console.ReadLine();

                while (string.IsNullOrEmpty(option3))
                {
                    Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                    option3 = Console.ReadLine();
                }



                if (option3 == "a")
                {
                    option1();
                }
                else if (option3 == "t")
                {
                Console.WriteLine("Here you go with option Transaction");
                Option2();
                

                }
                else if (option3 == "e")
                {
                    endApp = true;
                }
               
                    while (!(option3 == "a") || (option3 == "t") || (option3 == "e"))
                    {

                        Console.WriteLine("Please Enter from the above option.  ");
                        option3 = Console.ReadLine();


                    }
                

            }

            
    }
        

}

