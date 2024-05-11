//Programmer: Brian Lee
//Date: 05/10/2024

//Title: CSI 120 Midterm
using System.Security.Cryptography;

namespace CSI_120_Midterm
{
    internal class Program
    {
        delegate void MenuAction();
        static void Main(string[] args)
        {
            Console.WriteLine("Brian Lee - 05/10/2024");
            Console.WriteLine("Programming 120 - Midterm");
            Console.WriteLine();
            try
            {
                MenuAction[] MainMenu = { BasicCalc, FinanceCalc, GeometryCalc, CartPlane };
                Console.WriteLine("Select the number of the Program to execute:");
                Console.WriteLine("1. Basic Calculator");
                Console.WriteLine("2. Finance Calculator");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Cartesian Plane Quadrant");
                Console.WriteLine("5. Exit");
                
                int userInput;
                while(!int.TryParse(Console.ReadLine(), out userInput)|| userInput < 1||userInput>5)
                    Console.WriteLine("Invalid Input. Try Again.");
                if (userInput != 5)
                    MainMenu[userInput - 1]();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Main: {ex.Message}");
            }

        }//end of main
        public static void BasicCalc()
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter two integers");
                int userInput1, userInput2;

                while (!int.TryParse(Console.ReadLine(), out userInput1) || !int.TryParse(Console.ReadLine(), out userInput2))
                    Console.WriteLine("Invalid Input. Try Again.");


                Console.WriteLine("Select the Operation to execute:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int userOp;
                while (!int.TryParse(Console.ReadLine(), out userOp) || userOp < 1 || userOp > 4)
                    Console.WriteLine("Invalid Input. Try Again.");

                Console.WriteLine();
                switch (userOp)
                {
                    case 1:
                        Console.WriteLine($"{userInput1} + {userInput2} = {userInput1+userInput2}");
                        break;
                    case 2:
                        Console.WriteLine($"{userInput1} - {userInput2} = {userInput1 - userInput2}");
                        break;
                    case 3:
                        Console.WriteLine($"{userInput1} x {userInput2} = {userInput1 * userInput2}");
                        break;
                    case 4:
                        Console.WriteLine($"{userInput1} / {userInput2} = {userInput1 / userInput2}");
                        break;
                    default:
                        Console.WriteLine("Error has occured");
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Basic Calculator: {ex.Message}");
            }
            Console.WriteLine();
        }//end of BasicCalc
        public static void FinanceCalc()
        {
            Console.WriteLine("Finance Calculator");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Select the Operation to execute:");
                Console.WriteLine("1. Net Income");
                Console.WriteLine("2. Rule 72");
                Console.WriteLine("3. Net Worth");

                int userOp;
                while (!int.TryParse(Console.ReadLine(), out userOp) || userOp < 1 || userOp > 3)
                    Console.WriteLine("Invalid Input. Try Again.");
                Console.WriteLine();

                switch (userOp)
                {
                    case 1:
                        decimal userIncome1, userIncome2;
                        Console.WriteLine("Please Enter your Net Revenue");
                        while(!decimal.TryParse(Console.ReadLine(), out userIncome1))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine("Please Enter your Total Cost");
                        while (!decimal.TryParse(Console.ReadLine(), out userIncome2))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine($"Your Net Income is {(userIncome1-userIncome2).ToString("C")}");
                        break;
                    case 2:
                        Console.WriteLine("Please Enter the interest rate");
                        decimal rate;
                        while(!decimal.TryParse(Console.ReadLine(), out rate))
                            Console.WriteLine("Invalid Input. Try Again");
                        if (rate > 1)
                            rate = rate / 100;
                        Console.WriteLine($"It takes {Math.Round(72/rate,2)} years.");
                        break;
                    case 3:
                        decimal userAsset, userLiability;
                        Console.WriteLine("Please Enter your Asset");
                        while (!decimal.TryParse(Console.ReadLine(), out userAsset))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine("Please Enter your Liability");
                        while (!decimal.TryParse(Console.ReadLine(), out userLiability))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine($"Your Net Income is {(userAsset - userLiability).ToString("C")}");
                        break;
                    default:
                        Console.WriteLine("Error has occured");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Finance Calculator: {ex.Message}");
            }
            Console.WriteLine();
        }//end of FiananceCalc
        public static void GeometryCalc()
        {
            Console.WriteLine("Geometry Calculator");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Select the Operation to execute:");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Right Circular Cone");

                int userOp;
                while (!int.TryParse(Console.ReadLine(), out userOp) || userOp < 1 || userOp > 4)
                    Console.WriteLine("Invalid Input. Try Again.");

                switch (userOp)
                {
                    case 1:
                        double sqSide;
                        Console.WriteLine("Please input the length of the side of the square");
                        while(!double.TryParse(Console.ReadLine(), out sqSide))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine($"The Perimieter of the Square is {sqSide * 4}");
                        Console.WriteLine($"The Area of Square is {Math.Pow(sqSide,2)}");
                        break;
                    case 2:
                        double rtSide, rtHeight;
                        Console.WriteLine("Please input the length of the side of the rectangle");
                        while (!double.TryParse(Console.ReadLine(), out rtSide))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine("Please input the length of the height of the rectangle");
                        while (!double.TryParse(Console.ReadLine(), out rtHeight))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine($"The Perimieter of the Rectangle is {rtSide * 2 + rtHeight *2}");
                        Console.WriteLine($"The Area of the Rectangle is {rtSide * rtHeight}");
                        break;
                    case 3:
                        double crRadius;
                        Console.WriteLine("Please input the length of the radius of the circle");
                        while (!double.TryParse(Console.ReadLine(), out crRadius))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine($"The Circumference of the circle is {Math.PI*2*crRadius}");
                        Console.WriteLine($"The Area of the circle is {Math.PI*Math.Pow(crRadius,2)}");
                        break;
                    case 4:
                        double ccRadius, ccHeight;
                        Console.WriteLine("Please input the length of the radius of the cone");
                        while (!double.TryParse(Console.ReadLine(), out ccRadius))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine("Please input the length of the height of the cone");
                        while (!double.TryParse(Console.ReadLine(), out ccHeight))
                            Console.WriteLine("Invalid Input. Try Again");
                        Console.WriteLine($"The Circumference of the circle is {Math.PI * Math.Pow(ccRadius,2)* ccHeight / 3}");
                        break;
                    default:
                        Console.WriteLine("Error has occured");
                        break;
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Geometry Calculator: {ex.Message}");
            }
            Console.WriteLine();
        }//end of GeometryCalc

        public static void CartPlane()
        {
            Console.WriteLine("Cartesian Plane Quadrant");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter two xy coordinate");
                int userInput1, userInput2;

                while (!int.TryParse(Console.ReadLine(), out userInput1) || !int.TryParse(Console.ReadLine(), out userInput2))
                    Console.WriteLine("Invalid Input. Try Again.");
                if(userInput1 == 0 && userInput2 ==0)
                    Console.WriteLine("Your coordinate is on the origin");
                else if(userInput1 == 0)
                    Console.WriteLine("Your coordinate is on the y axis");
                else if(userInput2 == 0)
                    Console.WriteLine("Your coordinate is on the x axis");
                else if(userInput1 > 0 && userInput2> 0)
                    Console.WriteLine("Your coordinate is on the first quadrant");
                else if (userInput1 > 0 && userInput2 < 0)
                    Console.WriteLine("Your coordinate is on the second quadrant");
                else if (userInput1 < 0 && userInput2 < 0)
                    Console.WriteLine("Your coordinate is on the third quadrant");
                else if (userInput1 < 0 && userInput2 > 0)
                    Console.WriteLine("Your coordinate is on the fourth quadrant");
                else
                    Console.WriteLine("Error has occured");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured in Cartesian Plane Quadrant: {ex.Message}");
            }
        }//end of CartPlane
    }//end of class
}//end of namespace
