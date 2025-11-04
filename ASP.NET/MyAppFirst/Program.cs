
//WEEK 1 
//==============================================Project 1: Simple Calculator Application ==============================================
//using System;
//using System.Collections.Generic;
//class Calculator
//{
//    static int number1, number2, result;

//    static void DisplayMenu()
//    {
//        Console.WriteLine("\n=== Calculator Menu ===");
//        Console.WriteLine("1. Addition (+)");
//        Console.WriteLine("2. Subtraction (-)");
//        Console.WriteLine("3. Multiplication (*)");
//        Console.WriteLine("4. Division (/)");
//        Console.WriteLine("5. Exit");
//        Console.WriteLine("====================");
//        Console.Write("Choose an operation (1-5): ");
//    }

//    static void Main(string[] args)
//    {
//        bool isExit = false;

//        while (!isExit)
//        {
//            DisplayMenu();
//            string choice = Console.ReadLine();
//            char op;

//            switch (choice)
//            {
//                case "1":
//                    op = '+';
//                    break;
//                case "2":
//                    op = '-';
//                    break;
//                case "3":
//                    op = '*';
//                    break;
//                case "4":
//                    op = '/';
//                    break;
//                case "5":
//                    Console.WriteLine("Calculator closing...");
//                    return;
//                default:
//                    Console.WriteLine("Invalid choice! Please select 1-5.");
//                    continue;
//            }

//            Console.Write("Enter first number: ");
//            if (!int.TryParse(Console.ReadLine(), out number1))
//            {
//                Console.WriteLine("Invalid number! Please try again.");
//                continue;
//            }

//            Console.Write("Enter second number: ");
//            if (!int.TryParse(Console.ReadLine(), out number2))
//            {
//                Console.WriteLine("Invalid number! Please try again.");
//                continue;
//            }

//            switch (op)
//            {
//                case '+':
//                    result = number1 + number2;
//                    Console.WriteLine($"Result: {number1} + {number2} = {result}");
//                    break;
//                case '-':
//                    result = number1 - number2;
//                    Console.WriteLine($"Result: {number1} - {number2} = {result}");
//                    break;
//                case '*':
//                    if (number2 != 0)
//                    {
//                        result = number1 * number2;
//                        Console.WriteLine($"Result: {number1} * {number2} = {result}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Multiplication by zero is not allowed.");
//                    }
//                    break;
//                case '/':
//                    if (number2 != 0)
//                    {
//                        result = number1 / number2;
//                        Console.WriteLine($"Result: {number1} / {number2} = {result}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Division by zero is not allowed.");
//                    }
//                    break;
//            }
//        }
//    }
//}


//==============================================Project 2: Number Guess Game ==============================================


//using System;
//class Program
//{
//    static int number;
//    static void Main(string[] args)
//    {
//        Random random = new Random();

//        int randomNumber = random.Next(0, 15);  // Generates a random integer between 0 and 14
//        Console.WriteLine(randomNumber);

//        Console.WriteLine("Welcome to the Number Guessing Game!");
//        Console.WriteLine("Enter the number between 0 and 14: ");
//        number = Convert.ToInt32(Console.ReadLine());


//        if (number < 0 || number > 14)
//        {
//            Console.WriteLine("Please enter a valid number between 0 and 14.");
//        }
//        else if (number == randomNumber)
//        {
//            Console.WriteLine("Congratulations! You guessed the correct number.");
//        }
//        else if (Math.Abs(number - randomNumber) == 1)
//        {
//            Console.WriteLine($"Your guess is very close. The correct number was {randomNumber}. ");
//        }
//        else if (number < randomNumber)
//        {
//            Console.WriteLine($"Sorry,Your guess is too low. The correct number was {randomNumber}. Better luck next time!");
//        }
//        else if (number > randomNumber)
//        {
//            Console.WriteLine($"Sorry,Your guess is too high. The correct number was {randomNumber}. Better luck next time!");
//        }
//    }
//}


//==============================================Project 3: Student List (CRUD) Application ==============================================


//using System;
//using System.Collections.Generic;
//class Student
//{   
//   static public void DisplayMenu()
//    {
//        Console.WriteLine("\n=== Student List Menu ===");
//        Console.WriteLine("1. Add Student");
//        Console.WriteLine("2. View Students");
//        Console.WriteLine("3. Remove Student");
//        Console.WriteLine("4. Update Student");
//        Console.WriteLine("5. Exit");
//        Console.WriteLine("=========================");
//        Console.Write("Choose an option (1-5): ");
//    }


//    static void Main(string[] args)
//    {
//        List<string> students = new List<string>();
//        bool exit = false;

//        while (!exit) 
//        {
//            DisplayMenu();
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.WriteLine("Enter name to add in a list:");
//                    string nameToAdd = Console.ReadLine();
//                    students.Add(nameToAdd);
//                    Console.WriteLine($"Student '{nameToAdd}' added.");
//                break;

//                case "2":
//                    Console.WriteLine("Student List:");
//                    if (students.Count == 0)
//                    {
//                        Console.WriteLine("No students in the list.");
//                    }
//                    else
//                    {
//                        foreach (var student in students)
//                        {
//                            Console.WriteLine(student);
//                        }
//                    }
//                break;

//                case "3":
//                    Console.WriteLine("Enter student's name to remove :");
//                    string nameToRemove = Console.ReadLine();
//                    if (students.Count == 0)
//                    {
//                        Console.WriteLine("No students in the list.");
//                    }
//                    else
//                    {
//                        students.Remove(nameToRemove);
//                        Console.WriteLine($"Student '{nameToRemove}' removed.");
//                        foreach (var student in students)
//                        {
//                            Console.WriteLine(student);
//                        }
//                    }
//                break;
//                case "4":
//                    Console.WriteLine("Enter student you want to edit: ");
//                    string nameToEdit = Console.ReadLine();
//                    int index = students.IndexOf(nameToEdit);


//                    if(index != -1)
//                    {
//                        Console.WriteLine($"Enter name you want to replace with '{nameToEdit}' ");
//                        string newUpdatedName = Console.ReadLine();
//                        students[index] = newUpdatedName;

//                        Console.WriteLine($"Student '{nameToEdit}' has been updated to '{newUpdatedName}'.");

//                    }
//                    else 
//                    {
//                        Console.WriteLine($"Student '{nameToEdit}' not found in the list.");

//                    }
//                    break;
//                case "5":
//                    exit = true;
//                    Console.WriteLine("Appication is Closing....");
//                break;

//                default:
//                    Console.WriteLine("Please Choose from Student List Menu Options");
//                break;
//            }
//        }
//    }
//}


//==============================================Project 4: To-Do List Application (CLI) ============================================================

// object ko string ma convert karna ka tarika hai ToString() method ka use karna.
// Ye method har object ke liye available hota hai kyunki ye System.Object class se inherit hota hai.
// Jab aap ToString() method ko call karte hain, to wo object ki string representation return karta hai.


//using System.Runtime.CompilerServices;

//public class TaskItem
//{ 
//       public int Id { get; set; }
//       public string Description { get; set; }
//       public bool IsCompleted { get; set; }


//    public TaskItem(int id, string description)
//    {
//        Id = id;
//        Description = description;
//        IsCompleted = false;
//    }


//    public void MarkAsCompleted()
//    {
//         IsCompleted = true;
//    }
//}

using System;
public class  StudentDetails
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    //public StudentDetails(int id, string name, int age)
    //{
    //    Id = id;
    //    Name = name;
    //    Age = age;
    //}

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}";
    }


    static void Main(string[] args)
    {
        StudentDetails student = new StudentDetails();
        student.Id = 1;
        student.Name = "John Doe";
        student.Age = 20;


       string displayDeatils =  student.ToString();
       Console.WriteLine(displayDeatils);
    }
}