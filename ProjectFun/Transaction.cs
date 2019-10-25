using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class Transaction
    {
        DateTime _dateTime;
        double _amount;
        string _types;
        int _accountNumber;
        string _tranType;
        bool _status;
        double _period;
        


        public Transaction(DateTime dateTime, double amount, string types, int _accountNumber, string tranType, bool sts, double pt )
        {
            this._dateTime = dateTime;
            this._amount = amount;
            this._types = types;
            this._accountNumber = _accountNumber;
            this._tranType =tranType;
            this._status = sts;
            this._period = pt;

        }
        public Transaction()
        {

        }



        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
            set
            {
                this._dateTime = value;
            }

        }
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                this._amount = value;
            }
        }
        public String Types
        {
            get
            {
                return _types;
            }
            set
            {
                this._types = value;
            }

        }
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                this._accountNumber = value;
            }
        }
        public string TransactionType
        {
            get
            {
                return _tranType;
            }
            set
            {
                this._tranType = value;
            }
        }
        public bool StatusTypes
        {
            get
            {
                return _status;
            }
            set
            {
                this._status = value;
            }
        }

        public double Period
        {
            get
            {
                return _period;
            }
            set
            {
                this._period = value;
            }

        }


    }
}

