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
        bool session = false;
           Transaction newTr = new Transaction();
        public static List<Transaction> transList = new List<Transaction>();

        public Selection( )
        {

        }
      
        Account checking = new Account();
        Account business = new Account();
        Account loan = new Account();
        Account termDeposit = new Account();
  

        public void option0()
        {
            while (!session)
            {

                Console.WriteLine("Please Select from following option: ");


                Console.WriteLine("\tc - Do you want to continue with Registration ");

                Console.WriteLine("\te - Exit from application. ");

                Console.WriteLine("Your option? : ");
                string optiono = Console.ReadLine();

                while (string.IsNullOrEmpty(optiono) && (!(optiono == "c") || !(optiono == "e")))
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
                    session = false;
                    Environment.Exit(0);
                }

            }
        }

     

        public void option1()
        {
            
            Selection1.Option3();           

        }
            public void Option2()
            {

                   // Present the user with a menu of 7 options

                    Console.Write("\nBank Application Menu: \n \n"
                                     + "1. Deposit Money \n"
                                     + "2. Withdraw Money \n"
                                     + "3. Transfer Funds \n"
                                     + "4. Check Account Balance\n"
                                     + "5. Display the transaction\n"
                                     + "6. Return to Previouse Menu\n"
                                     + "7. End Session\n \n"
                                     + "Enter selection: ");

                    String input = Console.ReadLine();
                    int selection;
            while (string.IsNullOrEmpty(input) && (( (input =="1") || (input == "2") || (input == "3") || (input == "4") || (input == "5") || (input == "6") || (input == "7"))))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                input = Console.ReadLine();
            }

            // assign the user's input to the selection variable

            // This switch block will handle one of seven selections and deal with them appropriately

            if (int.TryParse(input, out selection))
                    {

                switch (selection)
                {

                    // case 1 handles the depositing of money

                    case 1:
                        Console.WriteLine("Enter (1) for Checking or (2) for Business or (3) for Term Deposit or (4) for Loan Account : ");

                        int depAccount = int.Parse(Console.ReadLine());
                        if (depAccount == 1)
                        {
                            if (Selection._checkingAcc > 0)
                            {
                                while (Selection1.accountLive)
                                {



                                    Console.WriteLine("\nYour current Checking balance is: " + (checking.getBalance()) + checking.getAccountnumber() + "\n");

                                    Console.WriteLine("How much money would you like to deposit?");
                                    double deposit = Convert.ToDouble(Console.ReadLine());

                                    checking.deposit(deposit);

                                    Console.WriteLine("\nYour Current balance is now: " + (checking.getBalance()) + "\n");

                                    newTr.AccountNumber = Selection1._AccountNumber;
                                    newTr.Amount = deposit;
                                    newTr.Types = "Checking";
                                    newTr.DateTime = DateTime.Now;
                                    newTr.TransactionType = "Deposit";
                                    transList.Add(newTr);
                                    option3();


                                }
                                Console.WriteLine("The Account Has been Closed.or Inactive");

                            }
                            else
                            {
                                Console.WriteLine("You Must Need account First");
                                option3();
                            }
                        }

                        else if (depAccount == 2)
                        {
                            if (Selection1._businessAcc > 0)
                            {
                                // while (Selection1.accountLive)                            {

                                Console.WriteLine("\nYour current Business Account balance is: " + (business.getBalance()) + business.getAccountnumber() + "\n");

                                Console.WriteLine("How much money would you like to deposit?");
                                double deposit = Convert.ToDouble(Console.ReadLine());

                                business.deposit(deposit);

                                Console.WriteLine("\nBusiness Account balance is now: " + (business.getBalance()) + "\n");
                                newTr.AccountNumber = Selection1._AccountNumber;
                                newTr.Amount = deposit;
                                newTr.Types = "Business";
                                newTr.DateTime = DateTime.Now;
                                newTr.TransactionType = "Deposit";
                                transList.Add(newTr);
                                option3();
                                //}
                            }
                            else
                            {
                                Console.WriteLine("You Must Need account First");
                                option3();

                            }

                        }
                        else if (depAccount == 3)
                        {
                            if (Selection1._businessAcc > 0)
                            {
                                while (Selection1.accountLive)
                                {

                                    Console.WriteLine("\nYour Term Deposit balance is: " + (termDeposit.getBalance()) + termDeposit.getAccountnumber() + "\n");

                                    Console.WriteLine("How much money would you like to deposit in your CD?");

                                    double deposit = Convert.ToDouble(Console.ReadLine());

                                    termDeposit.deposit(deposit);

                                    Console.WriteLine("\nTerm Account balance is now: " + (termDeposit.getBalance()) + "  Your Period: " + termDeposit.getPeriod() + "Interest Rate: " + termDeposit.getRate() + "\n"); ;

                                    newTr.AccountNumber = Selection1._AccountNumber;
                                    newTr.Amount = deposit;
                                    newTr.Types = "Term Deposit";
                                    newTr.TransactionType = "Deposit";
                                    newTr.DateTime = DateTime.Now;
                                    transList.Add(newTr);
                                    option3();
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Must Need account First");
                                option3();

                            }

                        }

                        else if (depAccount == 4)
                        {


                            if (Selection1.accountLive)
                            {

                                if (Selection1._loanAcc > 0)
                                {
                                    Console.WriteLine("\nYour current Loan balance is: " + (loan.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to deposit?");
                                    double deposit = Convert.ToDouble(Console.ReadLine());

                                    loan.withdraw(deposit);

                                    Console.WriteLine("\nLoan  balance is now: " + (loan.getBalance()) + "\n");
                                    newTr.AccountNumber = Selection1._AccountNumber;
                                    newTr.Amount = deposit;
                                    newTr.Types = "Loan";
                                    newTr.TransactionType = "Deposit";
                                    newTr.DateTime = DateTime.Now;
                                    transList.Add(newTr);
                                    option3();

                                }
                                else
                                {
                                    Console.WriteLine("\nYou Must need Loan Account to repay.\n ");
                                    option3();
                                }
                            }
                        }

                        break;



                    // case 2 handles the withdrawal of money	

                    case 2:

                        Console.Write("Enter (1) for Checking or (2) for Business or (3) for Term Deposit or (4) for Loan Account : ");
                        int witAccount = int.Parse(Console.ReadLine());


                        if (witAccount == 1)
                        {
                            if (Selection1._checkingAcc > 0)
                            {
                                while (Selection1.accountLive)
                                {

                                    Console.WriteLine("\nYour current Checking balance is: " + (checking.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to withdraw?");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    if (withdraw <= (checking.getBalance()))
                                    {

                                        checking.withdraw(withdraw);

                                        Console.WriteLine("\nYour Checking balance is now: " + (checking.getBalance()) + checking.getAccountnumber() + "\n"); ;
                                        newTr.AccountNumber = Selection1._AccountNumber;
                                        newTr.Amount = withdraw;
                                        newTr.Types = "Checking";
                                        newTr.TransactionType = "Withdraw";
                                        newTr.DateTime = DateTime.Now;
                                        transList.Add(newTr);
                                        option3();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Selected Amount is greater than actual balance. ");
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("You Must Nedd 2 Account to process. ");
                            }

                        }
                        else if (witAccount == 2)
                        {
                            if (Selection1._businessAcc > 0)
                            {
                                Console.WriteLine("\nYour current Business Account balance is: " + (business.getBalance()) + "\n");

                                Console.WriteLine("How much money would you like to withdraw?");
                                double withdraw = Convert.ToDouble(Console.ReadLine());
                                while (Selection1.accountLive)
                                {
                                    if (withdraw <= business.getBalance())
                                    {

                                        business.withdraw(withdraw);

                                        Console.WriteLine("\nYour Business Account balance is now: " + (business.getBalance()) + "\n");
                                        newTr.AccountNumber = Selection1._AccountNumber;
                                        newTr.Amount = withdraw;
                                        newTr.Types = "Business";
                                        newTr.TransactionType = "Withdraw";
                                        newTr.DateTime = DateTime.Now;
                                        transList.Add(newTr);
                                        option3();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Selected Amount is greater than actual balance. ");
                                        option3();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Must need two account to process this transaction. ");
                                option3();
                            }

                        }
                        else if (witAccount == 3)
                        {
                            while (Selection1.accountLive)
                            {
                                if (Selection1._cdAcc > 0)
                                {
                                    // Selection1 sc44 = new Selection1();
                                    Console.WriteLine("\nYour current CD balance is: " + (termDeposit.getBalance()) + "Duration: " + termDeposit.getPeriod() + "\n");
                                    var diff = Convert.ToDouble(DateTime.Now - termDeposit.getOpenDate());

                                    if (diff >= termDeposit.getPeriod())
                                    {


                                        Console.WriteLine("How much money would you like to withdraw?");
                                        double withdraw = Convert.ToDouble(Console.ReadLine());

                                        if (withdraw <= termDeposit.getBalance())
                                        {

                                            termDeposit.withdraw(withdraw);

                                            Console.WriteLine("\nYour Checking balance is now: " + (termDeposit.getBalance()) + "\n");
                                            newTr.AccountNumber = Selection1._AccountNumber;
                                            newTr.Amount = withdraw;
                                            newTr.Types = "Term Deposit ";
                                            newTr.TransactionType = "Withdraw";
                                            newTr.DateTime = DateTime.Now;
                                            transList.Add(newTr);
                                            option3();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your Selected Amount is greater than actual balance. ");
                                            option3();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("It's Not Mature");
                                        option3();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You Must nedd Account first. ");
                                    option3();
                                }
                            }




                        }
                        else if (witAccount == 4)
                        {
                            if (Selection1._loanAcc > 0)
                            {
                                while (Selection1.accountLive)
                                {
                                    Console.WriteLine("\nYour current Loan balance is: " + (loan.getBalance()) + "\n");

                                    Console.WriteLine("How much money would you like to withdraw?");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());
                                    if (withdraw <= business.getBalance())
                                    {

                                        loan.deposit(withdraw);//Loan account 

                                        Console.WriteLine("\nYour Loan balance is now: " + (loan.getBalance()) + "\n");
                                        newTr.AccountNumber = Selection1._AccountNumber;
                                        newTr.Amount = withdraw;
                                        newTr.Types = "Loan ";
                                        newTr.TransactionType = "Withdraw";
                                        newTr.DateTime = DateTime.Now;
                                        transList.Add(newTr);
                                        option3();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Selected Amount is greater than actual balance. ");
                                        option3();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Must need Account First. ");
                                option3();
                            }

                        }

                        break;

                    // case 3 handles the transfer of funds	

                    case 3:

                        

                            Console.WriteLine("Enter (1) for Checking or (2) for Business Account");

                            int tranAccount = int.Parse(Console.ReadLine());

                            if (tranAccount == 1)
                            {
                            if (Selection1._businessAcc > 0 && Selection1._checkingAcc > 0)
                            {
                                while (Selection1.accountLive)
                                {
                                    Console.WriteLine("\nYour Current Account balance is: " + (checking.getBalance()) + "\n");

                                    Console.Write("How much money do you wish to transfer from Current to Business?: ");
                                    double tranAmount = Convert.ToDouble(Console.ReadLine());
                                    if (tranAccount <= checking.getBalance())
                                    {

                                        checking.withdraw(tranAmount);
                                        business.deposit(tranAmount);

                                        Console.WriteLine("\nYou successfully transferred " + (tranAmount) + " from Checking to Checking");

                                        Console.WriteLine("\nChecking Balance: " + (checking.getBalance()));
                                        Console.WriteLine("Business Balance: " + (business.getBalance() + "\n"));
                                        newTr.AccountNumber = Selection1._AccountNumber;
                                        newTr.Amount = tranAmount;
                                        newTr.Types = "Transfer ";
                                        newTr.TransactionType = "Transfer";
                                        newTr.DateTime = DateTime.Now;
                                        transList.Add(newTr);
                                        option3();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Account Balance is not enough for this transaction. ");
                                        option3();
                                    }
                                }


                            }else
                            {
                                Console.WriteLine("Yoy Must need Account first. ");
                                option3();
                            }

                        }
                        





                        else if (tranAccount == 2)
                        {
                            if (Selection1._businessAcc > 0 && Selection1._checkingAcc > 0)
                            {
                                while (Selection1.accountLive)
                                {
                                    Console.WriteLine("\nYour current Checking balance is: " + (business.getBalance()) + "\n");

                                    Console.Write("How much money do you wish to transfer from business to checking?: ");
                                    double tranAmount = Convert.ToDouble(Console.ReadLine());
                                    if (tranAmount <= business.getBalance())
                                    {

                                        business.withdraw(tranAmount);
                                        checking.deposit(tranAmount);

                                        Console.WriteLine("\nYou successfully transferred " + (tranAmount) + " from Business to Checking");

                                        Console.WriteLine("\nChecking Balance: " + (checking.getBalance()));
                                        Console.WriteLine("Business Balance: " + (business.getBalance()) + "\n");
                                        newTr.AccountNumber = Selection1._AccountNumber;
                                        newTr.Amount = tranAmount;
                                        newTr.Types = "Transfer ";
                                        newTr.TransactionType = "Transfer";
                                        newTr.DateTime = DateTime.Now;
                                        transList.Add(newTr);
                                        option3();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Account Balance is not enough for this transaction.");
                                        option3();
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("You Must need both account. \n ");
                                option3();
                            }
                        }

                                break;

                            // case 4 simply outputs the balances of both Checking and Savings accounts	

                            case 4:
                        Console.WriteLine("You are in option 4");
                                UserRegister rj1 = new UserRegister();

                                Console.WriteLine(rj1._firstName + " " + rj1._lastName + "You have Following account with balance.  ");
                                Console.WriteLine("\nChecking Balance: {0}  Interest Rate: {1}", (checking.getBalance()), checking.getRate() + "%");
                                Console.WriteLine("Business Account Balance: {0}  Interest Rate: {1}", (business.getBalance()), business.getRate() + "%" + "\n");
                                Console.WriteLine("\nLoan Balance: {0}  Interest Rate: {1}", (loan.getBalance()), loan.getRate() + "%");
                                Console.WriteLine("\nTerm Deposit Account Balance: {0}  Interest Rate: {1}", (termDeposit.getBalance()), termDeposit.getRate() + "%");
                        option3();
                        break;

                            case 5:
                            //Display the Account Informatio\n"

                            Console.WriteLine("Following Details found for user: \n ");
                            foreach (var val in Selection1.transList)
                            Console.WriteLine("Account Number: {0} || Amount: {1}  || Date : {2} || Account: {3} || Period: {4} || ", val.AccountNumber, val.Amount, val.DateTime, val.Types, val.Period + "\n");
                            // Console.WriteLine("Now We see ");

                            foreach (var val in transList)
                                Console.WriteLine("Account Number: {0} || Amount : {1}  || Date : {2} || Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types+ "\n");
                        // Console.WriteLine("Now We see ");
                        option3();

                        break;

                            case 6:

                                option1();

                                break;


                            // case 5 breaks out of the (while) loop when the user is finished using the ATM

                            case 7:

                                session = false;
                        Environment.Exit(0);

                        break;


                    default:
                        
                        option3();
                 

                        break;


                }
                    }


               
                
            }



        
            public void option3()
            {
            Console.WriteLine("\n \n Please Select From Below Menu: ");

             Console.WriteLine("\ta - Do you want to open account? ");
             Console.WriteLine("\tt - Do you want to make a transaction ");
             Console.WriteLine("\tc - Do you want to Close Account.");
             Console.WriteLine("\te - Exit from application. ");
             Console.Write("Your option? : ");
             string option3 = Console.ReadLine();

            while (string.IsNullOrEmpty(option3) || (!((option3 == "a") || (option3 == "t") || (option3 == "c") || (option3 == "e")))) 
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
                else if (option3 == "c"){
                Close cs = new Close();
                cs.closedAccount();


            }
                else if (option3 == "e")
                {
                    session = false;
                }
               
                                 

            }

            
    }
        

}

