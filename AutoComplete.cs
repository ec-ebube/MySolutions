using System;
namespace MySolutions
{
    public class AutoComplete
    {
        //Create anything
        public static void check()
        {
            List<string> UsedWords = new List<string>();
            Console.WriteLine("What is your First Name");
            string FirstName = Console.ReadLine()!;
            Console.WriteLine("What is your Last Name");
            string Lastname = Console.ReadLine()!;
            Console.WriteLine("What is your Email address");
            string Email = Console.ReadLine()!;

            Random random = new Random();
            int userlength = random.Next(1, FirstName.Length);


            string start = Convert.ToString(DateTime.Now);
            string userbeginining = "ussn_";

            //Adding them to a list of strings "UsedWords"
            UsedWords.Add(FirstName);
            UsedWords.Add(Lastname);
            UsedWords.Add(Email);

            Console.WriteLine($"Do you opt for auto fill? (Yes/No)");
            string Answer = Console.ReadLine()!;

            //The if code
            if (Answer == "No" || Answer == "no" || Answer == "n")
            {
                Console.WriteLine("Do you wish to make any changes (yes/no)");
                string changes = Console.ReadLine()!;
                if (changes == "No" || changes == "no" || changes == "n")
                {

                }
                else if (changes == "Yes" || changes == "yes" || changes == "y")
                {
                    Console.WriteLine("On which one? 1 = Firstname,2 = LastName,3 = Email");
                    string values2 = Console.ReadLine()!;
                    switch (values2)
                    {
                        case "Firstname":
                            Console.WriteLine("Reset your firstname");
                            string name1 = Console.ReadLine()!;
                            FirstName = name1;
                            Console.WriteLine($"Your updated firstname is {FirstName}");
                            break;

                        case "1":
                            Console.WriteLine("Reset your firstname");
                            string nameone = Console.ReadLine()!;
                            FirstName = nameone;
                            Console.WriteLine($"Your updated firstname is {FirstName}");
                            break;

                        case "Lastname":
                            Console.WriteLine("Reset your lastname");
                            string name2 = Console.ReadLine()!;
                            Lastname = name2;
                            Console.WriteLine($"Your updated lastname is {Lastname}");
                            break;

                        case "2":
                            Console.WriteLine("Reset your lastname");
                            string nametwo = Console.ReadLine()!;
                            Lastname = nametwo;
                            Console.WriteLine($"Your updated lastname is {Lastname}");
                            break;


                        case "Email":
                            Console.WriteLine("Reset your email");
                            string mail = Console.ReadLine()!;
                            Email = mail;
                            Console.WriteLine($"Your updated email is {Email}");
                            break;

                        case "3":
                            Console.WriteLine("Reset your email");
                            string mail1 = Console.ReadLine()!;
                            Email = mail1;
                            Console.WriteLine($"Your updated email is {Email}");
                            break;

                        default:
                            Console.WriteLine("Wrong spelling, error or such dosen't exist");
                            break;
                    }
                }
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
                Console.WriteLine("Now fill in the form below");
                Console.WriteLine("Note!!, You opted for auto renew, so just put in the first or to second of your info where required or leave it blank");
                Console.WriteLine("What is desired firstname for this form");
                string fname = Console.ReadLine()!;
                Console.WriteLine("What is desired lastname for this form");
                string lname = Console.ReadLine()!;
                Console.WriteLine("Your username will be generated randomly from the information that you've provided before");
                Console.WriteLine("In which feild are you certified");
                string Feild = Console.ReadLine()!;
                UsedWords.Add(Feild);

                if (fname == " ")
                {
                    Console.WriteLine("Name is invalid");
                }
                else if (fname != FirstName)
                {
                    FirstName = fname;
                }

                Console.WriteLine("Your full details");
                Console.WriteLine($"Name: {FirstName} {Lastname}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Company's Id or UserName: {userbeginining}");
                Console.WriteLine($"Feild: {Feild}");
                Console.WriteLine($"Done");
            }
            else if (Answer == "Yes" || Answer == "yes" || Answer == "y")
            {
                Console.Write("Since you opted for auto fill,");
                Console.WriteLine("You'll need to put just the first letter of each variables you've used before else ther will be an error in you registeration and migth require starting all over");
                Console.WriteLine("Do you wish to make any changes (yes/no)");
                string changes = Console.ReadLine()!;
                if (changes == "No" || changes == "no" || changes == "n")
                {

                }
                else if (changes == "Yes" || changes == "yes" || changes == "y")
                {
                    Console.WriteLine("On which one? 1 = Firstname,2 = LastName,3 = Email");
                    string values2 = Console.ReadLine()!;
                    switch (values2)
                    {
                        case "Firstname":
                            Console.WriteLine("Reset your firstname");
                            string name1 = Console.ReadLine()!;
                            FirstName = name1;
                            Console.WriteLine($"Your updated firstname is {FirstName}");
                            break;

                        case "1":
                            Console.WriteLine("Reset your firstname");
                            string nameone = Console.ReadLine()!;
                            FirstName = nameone;
                            Console.WriteLine($"Your updated firstname is {FirstName}");
                            break;

                        case "Lastname":
                            Console.WriteLine("Reset your lastname");
                            string name2 = Console.ReadLine()!;
                            Lastname = name2;
                            Console.WriteLine($"Your updated lastname is {Lastname}");
                            break;

                        case "2":
                            Console.WriteLine("Reset your lastname");
                            string nametwo = Console.ReadLine()!;
                            Lastname = nametwo;
                            Console.WriteLine($"Your updated lastname is {Lastname}");
                            break;


                        case "Email":
                            Console.WriteLine("Reset your email");
                            string mail = Console.ReadLine()!;
                            Email = mail;
                            Console.WriteLine($"Your updated email is {Email}");
                            break;

                        case "3":
                            Console.WriteLine("Reset your email");
                            string mail1 = Console.ReadLine()!;
                            Email = mail1;
                            Console.WriteLine($"Your updated email is {Email}");
                            break;

                        default:
                            Console.WriteLine("Wrong spelling, error or such dosen't exist");
                            break;
                    }
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
                }


                Console.WriteLine("Now fill in the form below");
                Console.WriteLine("Note!!, You opted for auto renew, so just put in the first or to second of your info where required or leave it blank");
                Console.WriteLine("What is desired firstname for this form");
                string fname = Console.ReadLine()!;
                if (fname == " " || fname[0] == FirstName[0] || fname == "")
                {
                    fname = FirstName;
                }
                else if (fname != FirstName)
                {
                    FirstName = fname;
                }
                Console.WriteLine("What is desired lastname for this form");
                string lname = Console.ReadLine()!;
                if (lname == " " || lname[0] == Lastname[0] || lname == "")
                {
                    lname = Lastname;
                }
                else if (lname != Lastname)
                {
                    Lastname = lname;
                }
                Console.WriteLine("Your username will be generated randomly from the information that you've provided before");
                Console.WriteLine("In which feild are you certified");
                string Feild = Console.ReadLine()!;
                UsedWords.Add(Feild);
                Console.WriteLine("Your full details");
                Console.WriteLine($"Name: {FirstName} {Lastname}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Company's Id or UserName: {userbeginining}");
                Console.WriteLine($"Feild: {Feild}");
                Console.WriteLine($"Done");
            }
        }
    }
}
