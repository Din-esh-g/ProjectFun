using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class UserRegister
    {


        public int _userId;
        public string _firstName;
        public string _lastName;
        public string _emailAddress;
        public int _numberOfUser = 0;

        public UserRegister(int _userId, string _firstName, string _lastName, string _emailAddress)

        {

            this._userId = _userId;
            this._firstName = _firstName;
            this._firstName = _lastName;
            this._emailAddress = _emailAddress;


        }

        public UserRegister()
        {

        }

        public List<UserRegister> userList = new List<UserRegister>();

        public void userDetails()
        {

            Console.WriteLine("Please Enter Your Firstname: ");
            _firstName = Console.ReadLine();

            while (string.IsNullOrEmpty(_firstName))
            {
                Console.WriteLine("Name can't be empty! Input your  First name once more");
                _firstName = Console.ReadLine();
            }


            Console.WriteLine("Please Enter Your Last name: ");
            _lastName = Console.ReadLine();

            while (string.IsNullOrEmpty(_lastName))
            {
                Console.WriteLine(" Last Name can't be empty! Input your Last name once more");
                _lastName = Console.ReadLine();
            }


            Console.WriteLine("Please Enter Your Email Address");
            _emailAddress = Console.ReadLine();

            while (string.IsNullOrEmpty(_emailAddress))
            {
                Console.WriteLine("Email Field can't be empty! Input your email address once more");


                bool ValidateEmail = ValidaterEmail(_emailAddress);

                if (ValidateEmail)
                {
                    _emailAddress = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Please Enter your Valid Email");


                }
            }




            Random random = new System.Random();
            _userId = random.Next(500, 2500);

            List<UserRegister> userList = new List<UserRegister>() {
                new UserRegister(){ _userId=this._userId, _firstName= this._firstName, _lastName= this._lastName,_emailAddress= _emailAddress} };



            Console.WriteLine("Thank you for Registration !!! \n\n");

            Console.WriteLine("Your Registration Detais\n Full Name : {0} Email i: {1}  UserId:  {2} ", _firstName + " " + _lastName, _emailAddress, _userId);
            Console.WriteLine("\n\n");
            Selection.option1();


        }


        public bool ValidaterEmail(string email)
        {
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(email);
            return emailMatch.Success;
        }


    }
}
