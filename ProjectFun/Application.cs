using System;

namespace ProjectFun
{
   
    public class Application

    {
        
        public static void Main(String[] args)
        {

            bool session = true;
            while (session)
            {
                Selection newsc = new Selection();
                newsc.option0();
              
            }

           Console.WriteLine("\nThank you for banking with us!\n");

            session = false;




        }
    }
}

