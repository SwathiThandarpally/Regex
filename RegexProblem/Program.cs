namespace RegexProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Regular Expression Program");
            //UC_1
            ValidFirstNameUC_1 validFirstName = new ValidFirstNameUC_1();
            Console.WriteLine("please enter the name");

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
        }
    }
}