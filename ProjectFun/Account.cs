using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class Account
    {

        //  Here we declare some variables that a typical bank account will have


        String type;
        double balance;
        double rate;
        int accountNumber;
        string status;
        double period;
        DateTime Opendate;

        // The following methods are a combination of getter/setter methods as well
        // as two special deposit() and withdraw() methods


        public void setType(String accType)
        {

            type = accType;
        }
        public String getType()
        {

            return type;
        }


        public void setBalance(double accBal)
        {

            balance = accBal;
        }
        public double getBalance()
        {

            return balance;
        }

        public void setRate(double accRate)
        {

            rate = accRate;
        }

        public double getRate()
        {

            return rate;
        }
        public void deposit(double dep)
        {

            balance += dep; // Take the Account object's balance and add to it the current deposit
        }

        public void withdraw(double wit)
        {

            balance -= wit; // Take the Account object's balance and subtract from it the current withdrawal
        }





          
        public void setAccountnumber(int acc)
        {
            accountNumber = acc;
        }
        public int getAccountnumber()
        {

            return accountNumber;
        }

        public string AccountStatus
        {
            get
            {
                return status;
            }
            set
            {
                this.status = value;
            }
        }

        public void setPeriod(double pt)
        {

            period = pt;
        }
        public double getPeriod()
        {

            return period;
        }




        public void seOpenDate(DateTime dt)
        {

            Opendate = dt;
        }
        public DateTime getOpenDate()
        {

            return Opendate;
        }



    }
}
