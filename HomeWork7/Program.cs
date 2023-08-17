
// task7_2
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

string dirName = "C:\\";
string newPath = @"D:\DirectoryC.txt";

try
{
    using (StreamWriter sw = new StreamWriter(newPath, true, System.Text.Encoding.Default))
    {
        string[] dirs = Directory.GetDirectories(dirName);
        string[] files = Directory.GetFiles(dirName);


        sw.WriteLine("Directories: ");
        foreach (string directory in dirs)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            sw.WriteLine($"Name: {dirInfo.Name}");
        }

        sw.WriteLine("Files: ");
        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            sw.WriteLine($"Name: {fileInfo.Name}, size: {fileInfo.Length}");
        }
    }

    Console.WriteLine("successfully");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

// homework

Dictionary<string,string> phoneNumbers = new Dictionary<string,string>();

try
{
    using (StreamReader reader = new StreamReader("D://phones.txt"))
    {
        for (int i = 0; i < 9; i++)
        {
            string line = reader.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                string[] split = line.Split('-');
                string name = split[0].Trim();
                string number = split[1].Trim();
                phoneNumbers[number] = name;
            }
        }

        foreach (var line in phoneNumbers)
        {
            Console.WriteLine($"Name: {line.Key}, Phone Number: {line.Value}");
        }
    }

    using (StreamWriter writer = new StreamWriter("D://onlyPhoneNumbers.txt"))
    {
        foreach (var numbers in phoneNumbers)
        {
            writer.WriteLine(numbers.Value);
        }
    }
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Only phone numbers are written in the onlyPhoneNumbers.txt file: ");
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Updated phone numbers starting with +380: ");
    using (StreamWriter newWriter = new StreamWriter("D://new.txt"))
    {
        foreach (var change in phoneNumbers)
        {
            string phoneNumber = change.Value;
            if (phoneNumber.StartsWith("80"))
            {
                phoneNumber = "+380" + phoneNumber.Substring(2);
            }

            newWriter.WriteLine(phoneNumber);
            Console.WriteLine(phoneNumber);

        }
        
    }
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Updated phone numbers are written in the new.txt file");
    Console.WriteLine("-----------------------------------------------------");
}
catch (Exception ex3)
{
    Console.WriteLine(ex3.Message);
}

point:
try
{
    Console.WriteLine("Please enter the name: ");
    string enteredName = Console.ReadLine();

    if (phoneNumbers.TryGetValue(enteredName, out string foundNumber))
    {
        Console.WriteLine($"{enteredName} has {foundNumber} phone number.");
    }
    else
    {
        throw new ApplicationException("We don't have a person with that name!");
       
    }

}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    goto point;
}
catch (ApplicationException ex2)
{
    Console.WriteLine(ex2.Message);
    Console.WriteLine("Check the correct spelling and enter again");
    goto point;
}
catch (Exception ex3)
{
    Console.WriteLine(ex3.Message);
    goto point;
}

    


















