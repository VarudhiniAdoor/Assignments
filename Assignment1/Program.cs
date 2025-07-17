using System;
namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            int choice;
            
                Console.WriteLine("1. Display Hello Message");
                Console.WriteLine("2. Basic Arithmetic (Direct)");
                Console.WriteLine("3. Basic Arithmetic (Using if-else/switch)");
                Console.WriteLine("4. Display Your Name 10 Times");
                Console.WriteLine("5. Display Even Numbers using all loops");
                Console.WriteLine("6. Display Odd Numbers using all loops");
                Console.WriteLine("7. Multiplication Table using all loops");
                Console.WriteLine("8. Display numbers from 100 to 5 with gap of 3");
                Console.WriteLine("9. Print Variables in One Line");
                Console.WriteLine("10. Print Variables in Separate Lines");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello, Welcome to the C# Assignment!");
                        break;

                    case 2:
                        BasicArithmetic();
                        break;

                    case 3:
                        ArithmeticWithChoice();
                        break;

                    case 4:
                        for (int i = 0; i < 10; i++)
                            Console.WriteLine("YourName");
                        break;

                    case 5:
                        EvenNumbers();
                        break;

                    case 6:
                        OddNumbers();
                        break;

                    case 7:
                        MultiplicationTable();
                        break;

                    case 8:
                        for (int i = 100; i >= 5; i -= 3)
                            Console.Write(i + " ");
                        break;

                    case 9:
                        int x = 10, y = 20, z = 30;
                        Console.WriteLine($"{x} {y} {z}");
                        break;

                    case 10:
                        Console.WriteLine("10\n20\n30");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } 
        

        static void BasicArithmetic()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Quotient: {(b != 0 ? (a / b).ToString() : "Undefined (division by zero)")}");
        }

        static void ArithmeticWithChoice()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Choose Operation: 1.Add 2.Subtract 3.Multiply 4.Divide");
            int op = Convert.ToInt16(Console.ReadLine());

            switch (op)
            {
                case 1: Console.WriteLine($"Addition: {a + b}"); break;
                case 2: Console.WriteLine($"Subtraction: {a - b}"); break;
                case 3: Console.WriteLine($"Multiplication: {a * b}"); break;
                case 4:
                    if (b != 0)
                        Console.WriteLine($"Quotient: {a / b}");
                    else
                        Console.WriteLine("Division by zero not allowed.");
                    break;
                default: Console.WriteLine("Invalid operation."); break;
            }
        }

        static void EvenNumbers()
        {
            Console.WriteLine("Using for loop:");
            for (int i1 = 2; i1 <= 20; i1 += 2) Console.Write(i1 + " ");

            Console.WriteLine("\nUsing while loop:");
            int i2 = 2;
            while (i2 <= 20)
            {
                Console.Write(i2 + " ");
                i2 += 2;
            }

            Console.WriteLine("\nUsing do-while loop:");
            int i3 = 2;
            do
            {
                Console.Write(i3 + " ");
                i3 += 2;
            } while (i3 <= 20);
        }


        static void OddNumbers()
        {
            Console.WriteLine("Using for loop:");
            for (int i1 = 1; i1 <= 19; i1 += 2) Console.Write(i1 + " ");

            Console.WriteLine("\nUsing while loop:");
            int i2 = 1;
            while (i2 <= 19)
            {
                Console.Write(i2 + " ");
                i2 += 2;
            }

            Console.WriteLine("\nUsing do-while loop:");
            int i3 = 1;
            do
            {
                Console.Write(i3 + " ");
                i3 += 2;
            } while (i3 <= 19);
        }


        static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Using for loop:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");

            Console.WriteLine("Using while loop:");
            int i2 = 1;
            while (i2 <= 10)
            {
                Console.WriteLine($"{n} x {i2} = {n * i2}");
                i2++;
            }

            Console.WriteLine("Using do-while loop:");
            int i3 = 1;
            do
            {
                Console.WriteLine($"{n} x {i3} = {n * i3}");
                i3++;
            } while (i3 <= 10);
        }
    }
}
