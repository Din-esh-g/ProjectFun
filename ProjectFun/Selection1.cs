using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class Selection1
    {
        public static List<Transaction> transList = new List<Transaction>();
        public static List<Account> accList = new List<Account>();


        public static int _checkingAcc = 0;
        public static int _cdAcc = 0;
        public static int _loanAcc = 0;
        public static int _businessAcc = 0;
        public static int _totalAccount = 0;
        public static int _transation = 0;
        public static int _AccountNumber;
       public static bool session = true;
        public static bool accountLive = true;
        public static DateTime opendate;


        public static void Option3()
        {
            Transaction newTr = new Transaction();
            Account newAcc = new Account();
            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\tc - Open Checking Account");
            Console.WriteLine("\tb - Open Business Account");
            Console.WriteLine("\tl - Loan Account");
            Console.WriteLine("\tt - Term Deposit Account");
            Console.WriteLine("\te - Exit");

            Console.Write("Your option? : ");
            string option1 = Console.ReadLine();

            while (string.IsNullOrEmpty(option1) && ((option1 == "c")||(option1 == "b")|| (option1 == "l")|| (option1 == "t")|| (option1 == "e")))
            {
                Console.WriteLine("\n\nYour Selection can't be empty! Input your selection once more");
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
                    checking.setRate(0.00);
                    Random random = new System.Random();
                    _AccountNumber = random.Next(999500, 11112500);
                    checking.setAccountnumber ( _AccountNumber);
                    newTr.AccountNumber = _AccountNumber;
                    newTr.Amount = checking.getBalance();  
                    newTr.DateTime = DateTime.Now;

                    _checkingAcc++;
                    _totalAccount++;

                    accountLive = true;

                    transList.Add(newTr);
                    foreach (var val in transList)
                    Console.WriteLine("\n\n\t\t Congratulation:  \n\n Account Number: {0} || Balance: $ {1} || Date : {2} || Types: {3} \n\n",  val.AccountNumber,val.Amount, val.DateTime, val.Types);
                   
                    Selection sc3 = new Selection();
                    sc3.option3();
                    
                }
                else
                {
                    Console.WriteLine("\n\nYou already have Checking account: ");

                }




            }
            else if (option1 == "b")
            {
                Account business = new Account();
                business.setType("Business");
                business.setBalance(000.00);
                business.setRate(1.00);
               Random random = new System.Random();
                _AccountNumber = random.Next(999500, 11112500);
                business.setAccountnumber(_AccountNumber);
                Console.WriteLine("\n\n\t\t\tCongratulation:  \n\n Your Account Number is : {0} || Your Buiness Account balance is now: ${1}  || Interest Rate:{2} ", business.getAccountnumber(), (business.getBalance()), business.getRate() + "%" + "\n\n");


                newTr.AccountNumber = _AccountNumber;
                newTr.Amount = business.getBalance();
                newTr.DateTime = DateTime.Now;
                newTr.Types = "Business";
                transList.Add(newTr);

                              
                _businessAcc++;
                _totalAccount++;
                Selection sc3 = new Selection();
                sc3.option3();

            



            }
            else if (option1 == "l")
            {
                Account loan = new Account();
                loan.setType("Loan");
                loan.setBalance(000.00);
                loan.setRate(9.0);
              Random random = new System.Random();
                _AccountNumber = random.Next(999500, 11112500);
                loan.setAccountnumber(_AccountNumber);
                Console.WriteLine("\n\n\t\t\tCongratulation:  \n\n Your Account Number is : {0} || Your Loan balance is now: $ {1}  || Interest Rate: {2} ", _AccountNumber, (loan.getBalance()), loan.getRate() + "%" + "\n\n");

               

                newTr.AccountNumber = _AccountNumber;
                newTr.Amount = loan.getBalance();
                newTr.DateTime = DateTime.Now;
                newTr.Types = "Loan";
                transList.Add(newTr);

                _totalAccount++;
                _loanAcc++;
                Selection sc3 = new Selection();
                sc3.option3();
            }
            else if (option1 == "t")
            {
                if (_transation == 0)
                {
                    Account termDeposit = new Account();
                    termDeposit.setType("Term Deposit");
                    termDeposit.setBalance(000);
                    termDeposit.setRate(2.90);
                    Console.WriteLine("Please Enter Period for your CD in years ");
                    double rate = Convert.ToDouble(Console.ReadLine());
                    termDeposit.setPeriod(rate);
                    termDeposit.seOpenDate(DateTime.Now);
                    Random random = new System.Random();
                    termDeposit.setAccountnumber(random.Next(999500, 11112500));
                    // _AccountNumber = 
                    Console.WriteLine("\n\n\t\t\tCongratulation:  \n\n Account Number : {0} || Your CD balance: ${1} ||  Interest Rate:{2} Duration: {3} Years", termDeposit.getAccountnumber(), (termDeposit.getBalance()), termDeposit.getRate() + "%", termDeposit.getPeriod() + "\n\n");

                    newTr.AccountNumber = termDeposit.getAccountnumber();
                    newTr.Amount = termDeposit.getBalance();
                    newTr.DateTime = DateTime.Now;
                    newTr.Types = "Term Deposit";
                    newTr.Period = termDeposit.getPeriod();
                    newTr.StatusTypes = true;

                    transList.Add(newTr);




                    _totalAccount++;
                    _cdAcc++;
                    _transation++;
                    Selection sc3 = new Selection();
                    sc3.option3();
                }
                else
                {
                    Console.WriteLine("You Already Deposited. \n \n ");
                    Selection sc3 = new Selection();
                    sc3.option3();
                }
            }
            else if (option1 == "e")
            {
                Console.WriteLine("\n\n THANKS FOR USING OUR SERVICE ");
                session = false;
            }

         
        }
    }
}
            


            




