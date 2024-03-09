using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSharpTutorials
{
    class Program
    {
        public static void Main(string[] args){
        while(true)
        {
            Console.WriteLine("*********************************************************************");			
			Console.WriteLine("Name: Amith M Shetty");
			Console.WriteLine("*********************************************************************");
			Console.WriteLine("USN: 4MH21CS002");
			Console.WriteLine("*********************************************************************");
			Console.WriteLine("Faculty Name: Victor Ikechukwu Agughasi & Syeda Amira Hussaini");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->               Select the Program from 1 to 12               <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 1  : Arithmetic Operations                         <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 2  : Armstrong Numbers                             <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 3  : Substring of Strings                          <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 4  : Divide By Zero Exception                      <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 5  : Pascal of a Triangle(Print Pattern)           <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 6  : Floyd,s Triangle                              <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 7  : Read and Copy a Text File                     <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 8  : Implementation of Stack Operations            <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 9  : Complex Numbers                               <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 10 : Polymorphism Concepts                         <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 11 : Abstract Class for Calculating the Perimeter  <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->  Program 12 : Interface for Resizable                       <---");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("--->                        0 For  E X I T                       <---");
            Console.WriteLine("*********************************************************************");


            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Program 1  : Arithmetic Operation");
                        pro11.pro1();

                        break;
                    case 2:
                        Console.WriteLine("Program 2  : Armstrong Numbers");
                        pro12.pro2();
                        break;
                    case 3:
                        Console.WriteLine("Program 3  : Substring of Strings");
                        pro13.pro3();
                        break;
                    case 4:
                        Console.WriteLine("Program 4  : Divide By Zero Exception");
                        pro14.pro4();
                        break;
                    case 5:
                        Console.WriteLine("Program 5  : Pascal of a Triangle(Print Pattern)");

                        pro15.pro5();
                        break;
                    case 6:
                        Console.WriteLine("Program 6  : Floyd,s Triangle");
                        pro16.pro6();
                        break;
                    case 7:
                        Console.WriteLine("Program 7  : Read and Copy a Text File");
                        pro17.pro7();
                        break;
                    case 8:
                        Console.WriteLine("Program 8  : Implementation of Stack Operations");
                        pro18.pro8();
                        break;
                    case 9:
                        Console.WriteLine("Program 9  : Complex Numbers");
                        pro19.pro9();
                        break;
                    case 10:
                        Console.WriteLine("Program 10 : Polymorphism Concepts");
                        pro110.Program10.pro10();
                        break;
                    case 11:
                        Console.WriteLine("Program 11 : Abstract Class for Calculating the Perimeter");
                        pro111.ShapeClient.pro11();
                        break;
                    case 12:
                        Console.WriteLine("Program 12 : Interface for Resizable");
                        pro112.Program12.pro12();
                        break;
                    case 0:
                        Environment.Exit(1);
                        break;



                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
    public class pro11
{
    public static void pro1()
    {
        System.Console.WriteLine("Enter a First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter a Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Addition      :{0} + {1} = {2}", num1, num2, num1 + num2);
        System.Console.WriteLine("Subtraction   :{0} - {1} = {2}", num1, num2, num1 - num2);
        System.Console.WriteLine("Multipication :{0} x {1} = {2}", num1, num2, num1 * num2);
	if(num2==0){
	System.Console.WriteLine("Division by 0 not possible");
	}
	else{
        System.Console.WriteLine("Real Divison       :{0} / {1} = {2}", num1, num2, num1 / num2);
	}        
	System.Console.WriteLine("Mod           :{0} mod {1} = {2}", num1, num2, num1 % num2);

        System.Console.WriteLine("Enter a Base Number: ");
        float num11 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Enter an Exponent: ");
        float num22 = Convert.ToSingle(Console.ReadLine());


        double result = Math.Pow(num11, num22);
        System.Console.WriteLine("{0} ^ {1} = {2}", num11, num22, result);

        // Square root
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number to perform square root: ");
        double number = Convert.ToDouble(Console.ReadLine());

        // Check if the entered number is non-negative
        if (number >= 0)
        {
            // Calculate the square root
            double squareRoot = Math.Sqrt(number);

            // Display the result
            Console.WriteLine("The square root of {0} is: {1}", number, squareRoot);
        }
        else
        {
            Console.WriteLine("Cannot calculate the square root of a negative number.");
        }
    }




}
public class pro12
{
    public static void pro2()
    {
        Console.WriteLine("Enter the starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Armstrong numbers between {0} and {1}:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (IsArmstrongNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    // Function to check if a number is an Armstrong number
    static bool IsArmstrongNumber(int number)
    {
        int originalNumber, remainder, result = 0, n = 0;

        originalNumber = number;

        // Count the number of digits
        for (originalNumber = number; originalNumber != 0; originalNumber /= 10, ++n) ;

        originalNumber = number;

        // Calculate the sum of nth power of each digit
        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += (int)Math.Pow(remainder, n);
            originalNumber /= 10;
        }

        // Check if the number is an Armstrong number
        return result == number;

    }
}
public class pro13
{
    // Function to check if a string contains numeric characters
    public static bool ContainsNumeric(string str)
    {
        return str.Any(char.IsDigit);
    }

    public static void find_substrings(string input_string)
    {
        // Check if the input string contains numeric characters
        if (ContainsNumeric(input_string))
        {
            Console.WriteLine("Invalid input. The input string should not contain numeric characters.");
            return;
        }

        // Iterate through all possible substrings
        for (int i = 1; i <= input_string.Length; i++)
        {
            for (int j = 0; j <= input_string.Length - i; j++)
            {
                string substring = input_string.Substring(j, i);

                // Print the substring
                Console.WriteLine(substring);
            }
        }
    }

    public static void pro3()
    {
        string input_string;
        Console.WriteLine("Enter a String:");
        input_string = Console.ReadLine();
        find_substrings(input_string);
    }
}

public class pro14
{
    public static void pro4()
    {
        try
        {
            int result = 15 / int.Parse("0");
            System.Console.WriteLine(result);
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.ReadLine();
        }
        System.Console.ReadLine();
        Program.Main(null);
    }
}

public class pro15
{


    public static void pro5()
    {


        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = int.Parse(Console.ReadLine());

        Console.Write("Pascal's Triangle:\n");

        for (int i = 0; i < numRows; i++)
        {
            // Print leading spaces
            for (int j = 0; j < numRows - i - 1; j++)
            {
                Console.Write("  ");
            }

            // Print asterisks representing the numbers in Pascal's Triangle
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*   ");
            }

            Console.WriteLine();  // Move to the next line for the next row
        }
        System.Console.ReadLine();
        Program.Main(null);

    }
}
public class pro16
{

    public static void pro6()
    {

        int row, i, j, num = 1; Console.Write("Enter the number of rows: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        for (i = 1; i <= row; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine("");
        }
        Console.ReadKey();
        System.Console.ReadLine();
        Program.Main(null);

    }
}
public class pro17
{
    public static void pro7()
    {
string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

        // Input file path (assuming the input file is named "input.txt")
        string inputFilePath = Path.Combine(directoryPath, "input.txt");

        // Output file path (assuming the output file is named "output.txt")
        string outputFilePath = Path.Combine(directoryPath, "output.txt");

        try
        {
            // Read the contents of the input file
            string fileContents = File.ReadAllText(inputFilePath);
            Console.WriteLine("Reading File Contents...");

            // Write the contents to the output file
            File.WriteAllText(outputFilePath, fileContents);

            Console.WriteLine("File contents copied successfully...");
            Console.WriteLine("Check output.txt");
	    Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
	    Console.ReadLine();
        }
    }
}

public class pro18
{

    public static void pro8()
    {


        StackImplementation stack = new StackImplementation();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nStack MENU(size -- 10)");
            Console.WriteLine("1. Add an element");
            Console.WriteLine("2. See the Top element.");
            Console.WriteLine("3. Remove top element.");
            Console.WriteLine("4. Display stack elements.");
            Console.WriteLine("5. Exit");
            Console.Write("Select your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        stack.Push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Top element is: {0}", stack.Peek());
                        break;
                    case 3:
                        Console.WriteLine("Element removed: {0}", stack.Pop());
                        break;
                    case 4:
                        stack.Display();
                        break;
                    case 5:

                        Program.Main(null);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.ReadKey();
        }



    }


    public interface IStackADT
    {
        bool isEmpty();
        void Push(object element);
        object Pop();
        object Peek();
        void Display();
    }

    public class StackImplementation : IStackADT
    {
        private const int StackSize = 10;
        private int top;
        private readonly object[] items;

        public StackImplementation()
        {
            items = new object[StackSize];
            top = -1;
        }

        public bool isEmpty()
        {
            return top == -1;
        }

        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                items[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }

        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return items[top--];
            }
        }

        public object Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return items[top];
            }
        }

        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), items[i]);
            }
        }
    }
}


    public class pro19
    {
        public class Complex
        {
            private double real;
            private double imaginary;

            // Constructor to initialize the complex numbers
            public Complex(double real, double imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }

            // Method to overload the binary operator '+'
            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
            }

            // Method to display the complex number
            public override string ToString()
            {
                return real + " + " + imaginary + "i";
            }
        }

        public static void pro9()
        {
            Console.WriteLine("Enter the real and imaginary parts of the first complex number:");
            double real1 = double.Parse(Console.ReadLine());
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the real and imaginary parts of the second complex number:");
            double real2 = double.Parse(Console.ReadLine());
            double imaginary2 = double.Parse(Console.ReadLine());

            Complex c1 = new Complex(real1, imaginary1);
            Complex c2 = new Complex(real2, imaginary2);

            Complex result = c1 + c2;

            Console.WriteLine("Sum of the complex numbers: " + result);
            Console.ReadLine();
        }
    }


public class pro110
{

    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing Shape");
        }
        public virtual void erase()
        {
            Console.WriteLine("Erasing Shape");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
        public override void erase()
        {
            Console.WriteLine("Erasing Circle");
        }
    }
    public class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
        public override void erase()
        {
            Console.WriteLine("Erasing Triangle");
        }
    }
    public class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Square");
        }
        public override void erase()
        {
            Console.WriteLine("Erasing Square");
        }
    }
    public class Program10
    {
        public static void pro10()
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Triangle();
            shapes[2] = new Square();
            foreach (Shape shape in shapes)
            {
                shape.draw(); shape.erase();
            }
            System.Console.ReadLine();
            Program.Main(null);

        }
    }

}
public class pro111
{




    public abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
        private double radius;
        private readonly double pi = Math.PI; public Circle()
        {
            this.radius = 1;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * Math.Pow(radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * pi * radius;
        }
    }
    public class Triangle : Shape
    {
        private double width, height; public Triangle()
        {
            this.width = 1;
            this.height = 1;
        }
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return width + height + Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }
    }
    public class ShapeClient
    {
        public static void pro11()
        {
            double width = 13, length = 9;
            Shape triangle = new Triangle(width, length);
            Console.WriteLine("The width of the triangle is: " + width
            + "\nThe height of the triangle is: " + length
            + "\nThe area of the triangle is: " + triangle.GetArea()
            + "\nThe perimeter of the triangle is: " + triangle.GetPerimeter() + "."); double radius = 3;
            Shape circle = new Circle(radius);
            Console.WriteLine("\nThe radius of the circle is: " + radius
            + "\nThe area of the circle is: " + circle.GetArea()
            + "\nThe perimeter of the circle is: " + circle.GetPerimeter() + ".");
            System.Console.ReadLine();
            Program.Main(null);
        }
    }

}

public class pro112
{



    public interface IResizable
    {
        void ResizeWidth(int width);
        void ResizeHeight(int height);
    }
    public class Rectangle : IResizable
    {
        private int width;
        private int height; public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void ResizeWidth(int width)
        {
            this.width = width;
        }
        public void ResizeHeight(int height)
        {
            this.height = height;
        }
        public void PrintSize()
        {
            Console.WriteLine("Width: " + width + ", Height: " + height);
        }
    }
    public class Program12
    {
        public static void pro12()
        {
            Rectangle rectangle = new Rectangle(100, 150);
            rectangle.PrintSize();
            rectangle.ResizeWidth(150);
            rectangle.ResizeHeight(200);
            rectangle.PrintSize();
            System.Console.ReadLine();
            Program.Main(null);

        }
    }

}
}


