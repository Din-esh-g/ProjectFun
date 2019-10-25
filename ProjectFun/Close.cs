using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class Close
    {
        public static List<Transaction> transList = new List<Transaction>();
        public void closedAccount()
        {

            Account ac = new Account();

            Transaction trs = new Transaction();
            Console.Write("\nClosed Menue: \n \n"
                                     + "1. Closed Checking Account \n"
                                     + "2. Closed Business \n"
                                     + "3. Closed Loan Account \n"
                                     + "4. Closed Term Deposit Account\n"
                                     + "5. Display the transaction\n"
                                     + "6. Return to Previouse Menu\n"
                                     + "Enter selection: ");

            String input = Console.ReadLine();
            int selection;
            if (int.TryParse(input, out selection))
            {
                switch (selection)
                {
                    case 1:


                        foreach (var val in Selection1.transList)
                            if (val.Types == "Checking")
                            {
                                foreach (var vt in Selection.transList)
                                    if (vt.Amount < 0)
                                    {
                                        Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");
                                        Selection1.accountLive = false;
                                    }

                                trs.StatusTypes = false;
                                transList.Add(trs);
                                transList.RemoveAll(r => trs.StatusTypes == false);

                                //foreach (var val in transList)
                                //    Console.WriteLine("New Remain Details: Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}  Status : {4}", val.AccountNumber, val.Amount, val.DateTime, val.Types, val.StatusTypes + "\n");
                                Selection sc = new Selection();
                                sc.option3();
                            }
                            else
                            {
                                Console.WriteLine("Plese transfer your money befor you closed. ");
                                Selection sc21 = new Selection();
                                sc21.Option2();
                            }

                        break;
                    case 2:
                        foreach (var val in Selection1.transList)
                            if (val.Types == "Business")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");
                                Selection1.accountLive = false;
                            }

                        trs.StatusTypes = false;
                        transList.Add(trs);                       
                        transList.RemoveAll(r => trs.StatusTypes ==false);

                        foreach (var val in transList)
                            Console.WriteLine("New Remain Details: Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}  Status : {4}", val.AccountNumber, val.Amount, val.DateTime, val.Types, val.StatusTypes + "\n");


                        break;

                    case 3:
                        foreach (var val in Selection1.transList)
                            if (val.Types == "Loan")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");
                                Selection1.accountLive = false;
                            
                }
                        trs.StatusTypes = false;
                        transList.Add(trs);
                        transList.RemoveAll(r => trs.StatusTypes == false);

                        foreach (var val in transList)
                            Console.WriteLine("New Remain Details: Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}  Status : {4}", val.AccountNumber, val.Amount, val.DateTime, val.Types, val.StatusTypes + "\n");



                        break;
                    case 4:
                        foreach (var val in Selection1.transList)
                            if (val.Types == "Term Deposit")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");

                        }

                        trs.StatusTypes = false;
                        transList.Add(trs);
                        transList.RemoveAll(r => trs.StatusTypes == false);

                        foreach (var val in transList)
                            Console.WriteLine("New Remain Details: Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}  Status : {4}", val.AccountNumber, val.Amount, val.DateTime, val.Types, val.StatusTypes + "\n");


                        break;
                    case 5:
                        foreach (var val in Selection1.transList)
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");
                            Selection1.accountLive = false;
                        }
                        trs.StatusTypes = false;
                        transList.Add(trs);
                        transList.RemoveAll(r => trs.StatusTypes == false);

                        foreach (var val in transList)
                            Console.WriteLine("New Remain Details: Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}  Status : {4}", val.AccountNumber, val.Amount, val.DateTime, val.Types, val.StatusTypes + "\n");



                        break;
                    case 6:
                       Selection sc2 = new Selection();
                        sc2.Option2();
                        break;

                    default:
                        Selection sc3 = new Selection();
                        sc3.option3();
                        break;

                }
                

            }
        }
    }
}
