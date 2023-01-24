﻿namespace RegexProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Regular Expression Program");
            //UC_1
            ValidFirstNameUC_1 validFirstName = new ValidFirstNameUC_1();
            Console.WriteLine("please Enter The First Name");

            string validfirstname = Console.ReadLine();

            bool value = validFirstName.validateValidfirstName(validfirstname);
            if (value)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
            //UC_2

            ValidLastNameUC_2 validLastName2 = new ValidLastNameUC_2();
            Console.WriteLine("Please Enter The Last Name");

            string validlastname = Console.ReadLine();

            bool value1 = validLastName2.validateValidLastName(validlastname);
            if (value)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
            //UC_3

            ValidEmailUC_3 validEmail3 = new ValidEmailUC_3();
            Console.WriteLine("please enter the EmailId");

            string validemail = Console.ReadLine();

            bool value2 = validEmail3.validateValidEmail(validemail);
            if (value2)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
            //UC_4

            MobileFormatUC_4 mobileFormat = new MobileFormatUC_4();
            Console.WriteLine("please enter the phonenumber");

            string phonenumber = Console.ReadLine();

            bool value3 = mobileFormat.validatePhoneNumber(phonenumber);
            if (value3)
            {
                Console.WriteLine("PhoneNumber is matched");
            }
            else
            {
                Console.WriteLine("PhoneNumber is not matched");
            }
        }
    }
}