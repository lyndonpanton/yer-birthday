using System.Diagnostics;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birthMonth = "";
            int birthDay = -1;

            bool monthPassed = false;

            while (!monthPassed)
            {
                Console.Write("Enter the month of your birthday: ");
                birthMonth = Console.ReadLine().ToLower();

                switch (birthMonth)
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
                        monthPassed = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid month entered");
                        Console.WriteLine("Please try again");
                        break;
                }

                Console.WriteLine();

            }

            bool dayPassed = false;

            while (!dayPassed)
            { 
                Console.Write("Enter the day in the month of your birthday: ");
                birthDay = int.Parse(Console.ReadLine());

                switch (birthMonth)
                {
                    // always allows leap years
                    case "february":
                        if (birthDay >= 1 && birthDay <= 29)
                        {
                            dayPassed = true;
                        } else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid day for that month entered");
                            Console.WriteLine("Day should be between 1 and 29");
                            Console.WriteLine("Please try again");
                        }
                        break;
                    // 30 day months
                    case "april":
                    case "june":
                    case "september":
                    case "november":
                        if (birthDay >= 1 && birthDay <= 30)
                        {
                            dayPassed = true;
                        } else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid day for that month entered");
                            Console.WriteLine("Day should be between 1 and 30");
                            Console.WriteLine("Please try again");
                        }
                        break;
                    // 31 day months
                    case "january":
                    case "march":
                    case "may":
                    case "july":
                    case "august":
                    case "october":
                    case "december":
                        if (birthDay >= 1 && birthDay <= 31)
                        {
                            dayPassed = true;
                        } else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid day for that month entered");
                            Console.WriteLine("Day should be between 1 and 31");
                            Console.WriteLine("Please try again");
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
            }

            switch (birthDay)
            {
                case 1:
                    Console.WriteLine("Your birthday is on the " + birthDay + "st of " + birthMonth);
                    break;
                case 2:
                    Console.WriteLine("Your birthday is on the " + birthDay + "nd of " + birthMonth);
                    break;
                case 3:
                    Console.WriteLine("Your birthday is on the " + birthDay + "rd of " + birthMonth);
                    break;
                default:
                    Console.WriteLine("Your birthday is on the " + birthDay + "th of " + birthMonth);
                    break;
            }

            Console.WriteLine();

            int reminderDay = birthDay - 1;
            string reminderMonth = "";
            int discountPercentage = 20;

            if (reminderDay == 0)
            {

                switch (birthMonth)
                {
                    case "january":
                        reminderMonth = "december";
                        reminderDay = 31;
                        break;
                    case "february":
                        reminderMonth = "january";
                        reminderDay = 31;
                        break;
                    case "march":
                        reminderMonth = "february";
                        reminderDay = 29;
                        break;
                    case "april":
                        reminderMonth = "march";
                        reminderDay = 31;
                        break;
                    case "may":
                        reminderMonth = "april";
                        reminderDay = 30;
                        break;
                    case "june":
                        reminderMonth = "may";
                        reminderDay = 31;
                        break;
                    case "july":
                        reminderMonth = "june";
                        reminderDay = 30;
                        break;
                    case "august":
                        reminderMonth = "july";
                        reminderDay = 31;
                        break;
                    case "september":
                        reminderMonth = "august";
                        reminderDay = 31;
                        break;
                    case "october":
                        reminderMonth = "september";
                        reminderDay = 30;
                        break;
                    case "november":
                        reminderMonth = "october";
                        reminderDay = 31;
                        break;
                    case "december":
                        reminderMonth = "november";
                        reminderDay = 30;
                        break;
                }
            }

            switch (reminderDay)
            {
                case 1:
                    Console.WriteLine("You will receive your " + discountPercentage
                        + "% birthday discount reminder on the " + reminderDay + "st of " + reminderMonth);
                    break;
                case 2:
                    Console.WriteLine("You will receive your " + discountPercentage
                        + "% birthday discount reminder on the " + reminderDay + "nd of " + reminderMonth);
                    break;
                case 3:
                    Console.WriteLine("You will receive your " + discountPercentage
                        + "% birthday discount reminder on the " + reminderDay + "rd of " + reminderMonth);
                    break;
                default:
                    Console.WriteLine("You will receive your " + discountPercentage
                        + "% birthday discount reminder on the " + reminderDay + "th of " + reminderMonth);
                    break;
            }

            Console.WriteLine();
        }
    }
}