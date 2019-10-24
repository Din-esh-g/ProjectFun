using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFun
{
    public class UserRegister
    {


        public int _userId { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _emailAddress { get; set; }
        public int _numberOfUser { get; set; }
        //public int _accountnumber;

        public UserRegister(int _userId, string _firstName, string _lastName, string _emailAddress)

        {

            this._userId = _userId;
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._emailAddress = _emailAddress;
            //this._accountnumber = _accountnumber;


        }

        public UserRegister()
        {
        }

        public  static List<UserRegister> userList = new List<UserRegister>();

        public static void userDetails()
        {
            UserRegister ur = new UserRegister();
            Console.WriteLine("Please Enter Your First Name: ");
            ur._firstName = Console.ReadLine();


            while (string.IsNullOrEmpty(ur._firstName))
            {
                Console.WriteLine("Name can't be empty! Input your  First name once more");
                ur._firstName = Console.ReadLine();

            }


            Console.WriteLine("Please Enter Your Last Name: ");
            ur._lastName = Console.ReadLine();

            while (string.IsNullOrEmpty(ur._lastName))
            {
                Console.WriteLine(" Last Name can't be empty! Input your Last name once more");
                ur._lastName = Console.ReadLine();
            }


            Console.WriteLine("Please Enter Your Email Address");
            ur._emailAddress = Console.ReadLine();

            while (string.IsNullOrEmpty(ur._emailAddress))
            {
                Console.WriteLine("Email Field can't be empty! Input your email address once more");


                bool ValidateEmail = ValidaterEmail(ur._emailAddress);

                if (ValidateEmail)
                {
                    ur._emailAddress = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Please Enter your Valid Email");


                }
            }

                       
            Random random = new System.Random();
            ur._userId = random.Next(500, 2500);



            userList.Add(ur);
            Console.WriteLine("\n\nThank you for Registration !!! \n\n");

           // Console.WriteLine("Your Registration Detais\n Full Name : {0} Email i: {1}  UserId:  {2} ", ur._firstName + " " + ur._lastName, ur._emailAddress, ur._userId);

            foreach (var el in userList)
            Console.WriteLine("\n\n Congratulation:\t\t\tYour Registration Details:\n First Name: {0} Last Name: {1} Email Id: {2} UserId : {3}  \n\n", el._firstName, el._lastName, el._emailAddress, el._userId);

      
         


        }


        public static bool ValidaterEmail(string email)
        {
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(email);
            return emailMatch.Success;
        }


    } 
}
