namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool passed = false;

            while (!passed)
            {
                Console.Write("Enter the month of your birthday: ");
                string birthday = Console.ReadLine().ToLower();

                switch (birthday)
                {
                    case "january":
                    case "february":
                    case "march":
                    case "april":
                    case "may":
                    case "june":
                    case "july":
                    case "august":
                    case "september":
                    case "october":
                    case "november":
                    case "december":
                        passed = true;
                        break;
                    default:
                        Console.WriteLine("Invalid month entered");
                        Console.WriteLine("Please try again");
                        Console.WriteLine();
                        break;
                }

            }
        }
    }
}