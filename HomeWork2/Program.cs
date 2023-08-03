using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted }
    enum HTTPError { Bad_Request=400, Unauthorized, Payment_Required, Forbidden, Not_Found, Method_Not_Allowed }

    struct RGB { 
        public byte red;
        public byte green;
        public byte blue;

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", red, green, blue);
        }

    }

    struct Dog
    {
        public string name;
        public int age;
        public string mark;

        public Dog (string name, int age, string mark)
        {
            this.name = name;
            this.age = age;
            this.mark = mark;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", name, age, mark);
        }
    }
    static void Main()
    {
        Console.WriteLine("Hello, please check a number of task: ");
        Console.WriteLine(" 1. Task2 (1) \n 2. Task2 (2) \n 3. Task2 (3) \n 4. Task3 (4) \n 5. Task3(5)" +
            " \n 6. Homework2 (1) \n 7. Homework2 (2) \n 8. Homework2 (3) \n 9. Homework2(4) \n type exit if you want to exit the program.");

        while (true)
        {
            string numberOfTask = Console.ReadLine();

            switch (numberOfTask)
            {
                case "1":
                    Console.Write("Enter the first number: ");
                    int number1 = System.Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is this number a day?  ");
                    Console.WriteLine(number1 >= 1 && number1 <= 31 ? "true" : "false");

                    Console.Write("Enter the second number: ");
                    int number2 = System.Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is this number a month?");
                    Console.WriteLine(number2 >= 1 && number2 <= 12 ? "true" : "false");
                    break;

                case "2":
                    Console.Write("Enter the double number: ");
                    double number = System.Convert.ToDouble(Console.ReadLine());
                    int sum = (int)((number * 100) % 10) + (int)(((number * 100) / 10) % 10);
                    Console.WriteLine(sum);
                    break;

                case "3":
                    Console.Write("Enter the hour: ");
                    int hour = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((hour >= 5 && hour < 12) ? "Good morning!" : (hour >= 12 && hour < 17) ? "Good afternoon!"
                        : (hour >= 17 && hour <= 21) ? "Good evening!" : (hour > 21 && hour <= 24) ? "Good night!" : "It isn't a hour!");
                    break;

                case "4":
                    TestCaseStatus test1CaseStatus = TestCaseStatus.Pass;
                    int test1CaseStatusNumber = (int)test1CaseStatus;
                    Console.WriteLine($"Result is {test1CaseStatus}, number of status is {test1CaseStatusNumber}");
                    break;

                case "5":
                    RGB color;
                    color.red = 255;
                    color.green = 255;
                    color.blue = 255;
                    Console.WriteLine("White " + color);
                    color.red = 0;
                    color.green = 0;
                    color.blue = 0;
                    Console.WriteLine("Black " + color);
                    break;

                 case "6":
                    Console.Write("Enter 3 numbers: ");
                    float numb1 = System.Convert.ToSingle(Console.ReadLine());
                    float numb2 = System.Convert.ToSingle(Console.ReadLine());
                    float numb3 = System.Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine((numb1 < -5 || numb1 > 5) ? "number1 is not included" :
                        (numb2 < -5 || numb2 > 5) ? "number2 is not included" :
                        (numb3 < -5 || numb3 > 5) ? "number3 is not included" : "All numbers are in the range");
                    break;

                 case "7":
                    Console.WriteLine("Enter 3 numbers: ");
                    int n1 = System.Convert.ToInt32(Console.ReadLine());
                    int n2 = System.Convert.ToInt32(Console.ReadLine());
                    int n3 = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(((n1 > n2) && (n1 > n3) && (n2 > n3))? "number 1 is max, number 3 is min" :
                        ((n1 > n2) && (n1 > n3) && (n2 < n3))? "number 1 is max, number 2 is min" :
                        ((n1 < n2) && (n1 < n3) && (n2 > n3)) ? "number 2 is max, number 1 is min" :
                        ((n1 < n2) && (n1 < n3) && (n2 < n3)) ? "number 3 is max, number 1 is min" :
                        ((n1 == n2) || (n1 == n3) || (n2 == n3))? "two of the numbers are equal" :
                         "the numbers are equal");
                    break;

                  case "8":
                    HTTPError httpError1 = HTTPError.Bad_Request;
                    int httpError1Numb1 = (int)httpError1;
                    HTTPError httpError2 = HTTPError.Unauthorized;
                    int httpError1Numb2 = (int)httpError2;
                    HTTPError httpError3 = HTTPError.Payment_Required;
                    int httpError1Numb3 = (int)httpError3;
                    HTTPError httpError4 = HTTPError.Forbidden;
                    int httpError1Numb4 = (int)httpError4;
                    HTTPError httpError5 = HTTPError.Not_Found;
                    int httpError1Numb5 = (int)httpError5;
                    Console.WriteLine($"The name of HTTP Error: \n {httpError1} - {httpError1Numb1} \n " +
                        $"{httpError2} - {httpError1Numb2} \n {httpError3} - {httpError1Numb3} \n " +
                        $"{httpError4} - {httpError1Numb4} \n {httpError5} - {httpError1Numb5} \n");
                    break;

                case "9":
                    Dog myDog = new Dog("Sirko", 5, "pug");
                    Console.WriteLine("Information about dog: " + myDog);
                    break;
            }
        }
    }
}




