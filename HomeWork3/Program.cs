using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {

        Console.WriteLine("Hello, please check a number of task: ");
        Console.WriteLine(" 1. Task3 (1) \n 2. Task3 (2) \n 3. Task3 (3) \n 4. Task3 (4) \n 5. Task3(5)" +
          " \n 6. Task3(6) \n 7. Task3(7) \n 8. HomeWork3(1) \n 9. Homework3(2) \n 10. Homework3(3) \n type exit if you want to exit the program.");

        while (true)
        {
            string numberOfTask = Console.ReadLine();

            switch (numberOfTask)
            {
                case "1":

                    Console.Write("Enter a: ");
                    int a = System.Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter b: ");
                    int b = System.Convert.ToInt32(Console.ReadLine());
                    int result = 0;
                    for (int i = a; i <= b; i++)
                    {
                        if (i % 3 == 0)
                        {
                            result++;
                        }
                    }
                    Console.WriteLine($"{result} numbers are divided by 3. ");
                    break;

                case "2":
                    Console.Write("Write some string text: ");
                    string text = Console.ReadLine();
                    text = text.Replace(" ", string.Empty);
                    Console.WriteLine($"Sentences without spaces: {text}");
                    for (int i = 0; i < text.Length; i += 2)
                    {
                        if (text[i] != ' ')
                        {
                            Console.Write(text[i]);
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter the name of the drink( coffee, tea, juice or water): ");
                    string drink = Console.ReadLine().ToLower();
                    int price = 0;
                    switch (drink)
                    {
                        case "coffee":
                             price += 20;
                            Console.WriteLine($"Name of the drink (coffe), price: {price} $");
                            break;
                        case "tea":
                             price += 10;
                            Console.WriteLine($"Name of the drink (tea), price: {price} $");
                            break;
                        case "juice":
                             price += 15;
                            Console.WriteLine($"Name of the drink (juice), price: {price} $");
                            break;
                        case "water":
                            price += 5;
                            Console.WriteLine($"Name of the drink (water), price: {price} $");
                            break;
                    }
                    break;
                case "4": 
                    Console.WriteLine("sequence of positive integers: ");
                    int[] array = new int[10];
                    int count = 0;
                    int sum = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"Number {i}: ");
                        array[i] = System.Convert.ToInt32(Console.ReadLine());
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        if (array[i] < 0)
                        {
                            break;
                        }
                       else
                        {
                            sum += array[i];
                            count++;
                        }
                    }
                    if (count == 10)
                    {
                        Console.WriteLine("All numbers are positive");
                    }
                    else
                    if (count > 0)
                    {

                       double avarage = (double)sum / count;
                        Console.WriteLine($"the arithmetic average of the entered positive numbers: {avarage}");
                    }
                    else
                    {
                        Console.WriteLine("No positive numbers");
                    }
                    break;

                case "5":
                    Console.WriteLine("Enter the year: ");
                    int year = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(DateTime.IsLeapYear(year));
                    break;

                case "6":
                    Console.WriteLine("Enter the number: ");
                    int total = 0;
                    int number = System.Convert.ToInt32(Console.ReadLine());
                    while (number > 0)
                    {
                        total += number % 10;
                        number /= 10;
                    }
                    Console.WriteLine(total);
                    break;
                case "7":
                    Console.WriteLine("Enter the number");
                    int n = System.Convert.ToInt32(Console.ReadLine());     
                    int digit = n % 10;
                    if (digit % 2 != 0)
                    {
                        Console.WriteLine("number contains only odd digits");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                    n /= 10;
                    break;
                case "8":
                    Console.WriteLine("Enter the text: ");
                    string str = Console.ReadLine();
                    int chA = 0, chO = 0, chI = 0, chE = 0; 
                    foreach (char ch in str)
                    {
                        switch (char.ToLower(ch))
                        {
                            case 'a':
                               chA++;
                                break;
                            case 'o':
                                chO++;
                                break;
                            case 'i':
                                chI++;
                                break;
                            case 'e':
                                chE++;
                                break;
                            default:
                                
                                break;
                        }
                    }
                    Console.WriteLine($"Count of a: {chA}");
                    Console.WriteLine($"Count of o: {chO}");
                    Console.WriteLine($"Count of i: {chI}");
                    Console.WriteLine($"Count of e: {chE}");
                    break;
                case "9":
                    Console.WriteLine("Enter the year: ");
                    int year1 = System.Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Enter the month: ");
                    int month = System.Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine(DateTime.DaysInMonth(year1,month));
                    break;
                case "10":
                    Console.WriteLine("enter 10 integer numbers: ");
                    int[] arr = new int[10];
                    int suma = 0;
                    int product = 1;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"Number {i}: ");
                        arr[i] = System.Convert.ToInt32( Console.ReadLine() );
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        if (arr[i] > 0)
                        {                 
                             suma += arr[i];              
                        }
                        else
                        {
                            for (int j = 5; j < 10; j++)
                            {
                                product *= arr[j];
                            }
                            
                        }
                    }

                    if (product == 1)
                    {
                        Console.WriteLine($"The sum offirst 5 elements: {suma}");
                    }
                    else
                    {
                        Console.WriteLine($"Product of last 5 element: {product} ");
                    }
                    
                    break;
            }
        }
    }
}




