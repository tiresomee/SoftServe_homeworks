
Console.WriteLine("Hello, please check a number of task: ");
Console.WriteLine(" 1. Task1 (2) \n 2. Task1 (3) \n 3. Task1 (4)" +
    " \n 4. Homework1 (1) \n 5. Homework1 (2) \n 6. Homework1 (3) \n type exit if you want to exit the program.");
while ( true )
{
    string numberOfTask = Console.ReadLine();

    switch ( numberOfTask )
    {
        case "1":

            // 2
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
            Console.WriteLine();
            break;

        case "2":
            // 3
            Console.Write("Enter the first char: ");
            char firstChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter the second char: ");
            char secondChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter the third char: ");
            char thirdChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"You enter {firstChar}, {secondChar}, {thirdChar}");
            Console.WriteLine();
            break;

        case "3":

            // 4
            Console.Write("Enter the first number: ");
            int number1 = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the second number: ");
            int number2 = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            bool isPositive = number1 > 0 && number2 > 0;

            if ( isPositive )
            {
                Console.WriteLine("Both numbers are positive!");
            }
            else
            {
                Console.WriteLine("One or both of the numbers are negative or null");
            }
            Console.WriteLine();
            break;

        case "4":
            Console.Write("Enter the length of the side of the square: ");
            int lenght = System.Convert.ToInt32(Console.ReadLine());
            if ( lenght <= 0 )
            {
                Console.WriteLine("The side of a square cannot be negative or null. ");
            }
            else
            {
                Console.WriteLine($" Perimeter of a square: {lenght * 4} \n Area of a square: {Math.Pow(lenght, 2)}");

            }
            Console.WriteLine();
            break;

        case "5":
            Console.WriteLine(" What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine( $" How old are you, {name}? ");
            int age = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Your name is {name}, and you are {age} years old.");
            Console.WriteLine();
            break;

        case "6":
            Console.Write("Enter the radius of a circle: ");
            double radius = System.Convert.ToDouble(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("The radius of a circle cannot be negative or null. ");
            }
            else
            {
                Console.WriteLine($" The lenght of a circle: {2 * Math.PI * radius :F3} " +
                    $"\n Area of a circle: {Math.PI * Math.Pow(radius,2) :F3} " +
                    $"\n Volume of a circle: { (4/3) * Math.PI * Math.Pow(radius, 3) :F3}");
            }
            Console.WriteLine();
            break;

        case "exit":
            Console.WriteLine("goodbye!");
        return; 

        default:
            Console.WriteLine(" Unknown answer option! ");
            break;
    }
}








