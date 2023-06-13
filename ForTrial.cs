using System;
namespace MySolutions
{
    public class ForTrial
    {
        public static void MyTrial()
        {
            Console.WriteLine("What is your First Name");
            string FirstName = "Emmanuel";
            Console.WriteLine("What is your Last Name");
            string Lastname = "Chimdiebube";
            Console.WriteLine("What is your Email address");
            string Email = "Chimdi@gmail.com";

            Random random = new Random();
            int userlength = random.Next(1, FirstName.Length);

            string start = Convert.ToString(DateTime.Now);
            string userbeginining = "ussn_";
            
            for (int i = 0; i <= userlength; i++)
            {
                int userstart = random.Next(1, Lastname.Length);
                userbeginining += Lastname[userstart];
            }
            userbeginining += Convert.ToString(start[0]);
            for (int j = 1; j < 9; j++)
            {
                userbeginining += start[j];
            }
            Console.WriteLine(userbeginining);
            Console.WriteLine(Email);
        }
    }
}