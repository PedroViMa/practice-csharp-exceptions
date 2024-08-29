using System;

namespace Exercise3
{
    internal static class ConsoleScanner
    {
        public static int ScanBetweenRangeOfIntegers(int left, int right)
        {
            string opt;
            int optInt;
            do
            {
                Console.WriteLine($"Enter an option between {left} and {right}:");
                opt = Console.ReadLine();

                optInt = VerifyInteger(opt, right);
            }
            while ( optInt < left && optInt > right);
            return optInt;
        }

        private static int VerifyInteger(string opt, int right)
        {
            try
            {
                int optInt = Int32.Parse(opt);
                return optInt;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Please enter a number.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Invalid option.");
            }

            return right + 1;
        }
    }
}
