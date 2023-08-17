using System.Security.Cryptography;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Enter an integer number that will be start: ");
                int start = System.Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an integer number that will be end: ");
                int end = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter 10 numbers such that a1 > a2 > a3 > a4... > a10: ");


                if (end < start + 11)
                {
                    throw new ApplicationException("The 'end' value must be at least 10 greater than the 'start' value.");
                } 
                else if (start < 0 || end < 0) 
                {
                    throw new ApplicationException("numbers should be greater than 0");
                }
                else if (end <= start)                  
                {
                    throw new ApplicationException("end musn't be less than or equal to the start");
                }

                int[] numbers = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Enter number {i + 1} ({start} < a{i + 1} < {end}): ");
                    numbers[i] = ReadNumbers(start, end);

                    if (i >0 && numbers[i] <= numbers[i - 1])
                    {
                        throw new ApplicationException("this number must be greater than the previous one");
                    }
                   
                }
       
            }

            catch (FormatException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (ApplicationException b)
            {
                Console.WriteLine(b.Message);
            }

        }

    }

    static int ReadNumbers(int start, int end)
    {
        while (true)
        {
            try
            {
                int numbers = System.Convert.ToInt32(Console.ReadLine());
                if (numbers < start || numbers > end)
                {
                    throw new ApplicationException($"Number must be in the range [{start}...{end}].");
                }
                return numbers;
            }
            catch (ApplicationException c) 
            {
                Console.WriteLine(c.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}