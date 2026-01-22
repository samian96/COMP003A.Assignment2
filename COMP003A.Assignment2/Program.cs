namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // writeline to display message asking for first name while the string with readline is waiting for user input

            Console.WriteLine("Please enter your first name");
            string inputName = Console.ReadLine();

            Console.WriteLine("Please enter last name");
            string inputName2 = Console.ReadLine();

            Console.WriteLine("Please enter number");
            string inputNumber = Console.ReadLine();

            Console.WriteLine("Please enter another number");
            string inputNumber2 = Console.ReadLine();

            Console.WriteLine("Name Formats\n ------------");
 
            // examples of concatenation and interpolation to achieve the same outcome

            Console.WriteLine("Concatenation:" + " " + inputName + " " + inputName2);
            Console.WriteLine($"Interpolation: {inputName} {inputName2}");

            // using double to store number and double.Parse to convert string to number with decimals

            double numb1 = double.Parse(inputNumber);
            double numb2 = double.Parse(inputNumber2);


        }
    }
}
