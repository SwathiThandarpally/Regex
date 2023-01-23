namespace RegexProblem
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
        }
    }
}