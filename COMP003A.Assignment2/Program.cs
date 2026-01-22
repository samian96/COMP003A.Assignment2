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

            // using double to store number and double.Parse to convert numeric inputs from string

            double numb1 = double.Parse(inputNumber);
            double numb2 = double.Parse(inputNumber2);

            // doubles to execute basic arithmetic for the user input values

            double sum = numb1 + numb2;

            double average = (numb1 + numb2) / 2.0;

            double difference = numb1 - numb2;

            double product = numb1 * numb2;

            double quotient = numb1 / numb2;


        }
    }
}
