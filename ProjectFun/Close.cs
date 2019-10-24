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
                                Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");
                               
                            }
                    
                        break;
                    case 2:
                        if (val.Types == "Checking")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");

                        }
                        break;
                    case 3:
                        if (val.Types == "Checking")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");

                        }
                        break;
                    case 4:
                        if (val.Types == "Checking")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");

                        }
                        break;
                    case 5:
                        if (val.Types == "Checking")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");

                        }
                        break;
                    case 6:
                        if (val.Types == "Checking")
                        {
                            Console.WriteLine("Account Number: {0} Amount: {1} Date of Last Transation : {2} Account: {3}", val.AccountNumber, val.Amount, val.DateTime, val.Types + "\n");

                        }
                        break;
                        
                    


                }
            }
        }
    }
}
