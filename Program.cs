using System;
using System.Threading;

namespace COMP100.A4
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-7) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        #endregion

        /// <summary>
        /// Write code to produce a table of numbers from 10 to 1, with their squares and cubes. 
        /// You must use a loop and your table must look professional.
        /// </summary>
        private static void Question1()
        {
            int count = 10;

            while (count!=0)
            {
                //DC -1 numbers should be right justified
                Console.WriteLine($"{count,-10}square: {count*count,-10}cube: {count*count*count,-10}");
                --count;
            }
        }

        /// <summary>
        /// Write code that displays a conversion table from Fahrenheit to Celsius. It must request
        /// the starting Fahrenheit value, the ending Fahrenheit value, and the increment. 
        /// Thus, instead of the condition checking for a fixed count, the condition checks for 
        /// the ending Fahrenheit value. 
        /// You must use a loop and your table must look professional.
        /// </summary>
        private static void Question2()
        {
            float fahrenheitValue = 0.0f;
            float endFahrenheit = 0.0f;
            float toCelsius = 0.0f;
            float incrementValue = 0.0f;
            string separator = " ";
            /// double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.Write("Enter Initial Fahrenheit Value: ");
            fahrenheitValue = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter End Fahrenheit Value: ");
            endFahrenheit = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Increment Value: ");
            incrementValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Fahrenheit{separator,5}Celsius{separator,-8}");
            for (int i = (int)fahrenheitValue; fahrenheitValue <= endFahrenheit; i++)
            {
                toCelsius = (fahrenheitValue - 32) * 5 / 9;
                //DC -1 fahrenheit digits are not lined up
                Console.WriteLine($"{fahrenheitValue,-10:f2}{toCelsius,12:f2}");
                fahrenheitValue += incrementValue;
            }


        }

        /// <summary>
        /// Write code that calculates and displays the amount of money available in a 
        /// bank account that initially has $1,000 deposited in it and that earns 8 percent 
        /// interest a year. It should display the amount available at the end of each year 
        /// for a period of ten years. Use the relationship that the money available at the
        /// end of each year equals the amount of money in the account at the start of the
        /// year plus .08 times the amount available at the start of the year.
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// Year Balance
        ///  1   $1,080.00
        ///  2   $1,166.40
        ///  3   $1,259.71
        ///  4   $1,360.49
        ///  5   $1,469.33
        ///  6   $1,586.87
        ///  7   $1,713.82
        ///  8   $1,850.93
        ///  9   $1,999.00
        /// 10   $2,158.92
        /// 
        /// </summary>
        private static void Question3()
        {
            string empty = "";
            Console.WriteLine($"Year{empty,6}Balance:");
            const float interestPerYear = 0.08f;
            float initialValue = 1000.00f;
            float yearValue = 1000.00f;

            for (int i=1; i<=10; i++)
            {
                initialValue += initialValue * interestPerYear;
                yearValue = initialValue;
                Console.WriteLine($"{i,-3} {yearValue,14:C2}");
                
            }
        }

        /// <summary>
        /// Write code that continuously requests a grade. If the grade is less than 0 or 
        /// greater than 100, your program should print an appropriate message informing the 
        /// user that an invalid grade has been entered,
        /// 
        /// else the grade should be added to a 
        /// total. If the grade is 999, the program should exit the loop and display the sum, 
        /// number of valid grades and the average of the valid grades entered. (You must NOT 
        /// display an invalid message) 
        /// P.S. The value 999 is use to terminate the cycle and should not be used in any of 
        /// the calculation. You must not display an “Invalid grade”
        /// </summary>
        private static void Question4()
        {
            int grade = 0;
            int gradeCount = 0;
            int totalGrade = 0;
            float averageGrade = 0.0f;

            do
            {
                Console.Write("Enter Grade (999 to end): ");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade == 999)
                    break;
                else if (grade < 0 || grade > 100)
                    Console.WriteLine("Enter Valid Grade from 1 - 100. \n");
                else
                {
                    totalGrade += grade;
                    gradeCount++;
                }

            } while (grade != 999);
            averageGrade = (float) totalGrade / gradeCount;

            Console.WriteLine($"\nTotal Sum: {totalGrade}\nNumber of Valid Grade: {gradeCount}\nAverage Grade: {averageGrade:f2}\n");
        }

        /// <summary>
        /// 1.) Print the decimal, octal, and hexadecimal values of all characters between the 
        /// start and stop characters entered by a user.
        /// 
        /// 2.) For example, if the user enters an 
        /// a and a z, the program should print all the characters between a and z and their 
        /// respective numerical values.
        /// 
        /// 3.) Make sure that the second character entered by the 
        /// user occurs later in the alphabet than the first character.
        /// 
        /// 4.) If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
        /// Your output should be formatted as shown below:
        /// 
        /// Letter   Decimal   Octal   Hex
        ///      a	      97     141	61
        ///      b	      98     142    62
        ///      c        99     143	63
        ///      d       100     144	64
        ///      e	     101     145	65
        ///
        /// </summary>
        private static void Question5()
        {
            char firstCharacter = ' ';
            char secondCharacter = ' ';
            string octal, hex, space;
            space = " ";

            //DC -1 bad indentation
                    Console.Write("Enter 1st Character of the alphabet: ");
                    firstCharacter = Convert.ToChar(Console.ReadLine());
                    while (secondCharacter  < firstCharacter || secondCharacter == firstCharacter)
                    {
                        Console.Write("Enter 2nd Character of the alphabet: ");
                        secondCharacter = Convert.ToChar(Console.ReadLine());
                        if (secondCharacter < firstCharacter)
                            Console.WriteLine("Character should be greater to previous input\n");
                            else if (firstCharacter == secondCharacter)
                                Console.WriteLine("Same Character. Enter greater than previous input.\n");
                    }
                    int pointA = (int)firstCharacter;
                    int pointB = (int)secondCharacter;

                    Console.WriteLine(" ");
                    if(pointA<pointB){
                        int count = pointB - pointA;

                        Console.WriteLine($"Letter{space,5}Decimal{space,5}Octal{space,5}Hex{space,5}");
                        for (int i = 0; i <= count; i++)
                        {
                            octal = Convert.ToString(pointA, 8);
                            hex = Convert.ToString(pointA, 16);
                            Console.WriteLine($"{(char)pointA,5} {pointA,12} {octal,9} {hex,7}");
                            pointA++;
                        }
                        Console.WriteLine("");
                    }

                    
        }

        /// <summary>
        /// Write code to compute the (x, y) pairs for the equation below for x in the 
        /// range 1 to 5 in 0.5 increments.
        /// 
        /// Equation: y = 2x² - x - 6 
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// x	  2x²   -x	   -6    y
        /// 1.0	  2.0	-1.0   -6   -5.0
        /// 1.5	  4.5	-1.5   -6	-3.0
        /// 2.0	  8.0	-2.0   -6	 0.0
        /// 2.5	 12.5	-2.5   -6	 4.0
        ///
        /// </summary>
        private static void Question6()
        {
            float valueOfX = 1.0f;
            string empty = "";
            float valueOfTwoXSquared = 0.00f;
            float valueOfNegativeX = 0.00f;
            float negativeValue = 0.00f;
            float valueOfY = 0.00f;

            /// Equation: y = 2x² - x - 6
            Console.WriteLine($"x{empty,6}2x²{empty,5}-x{empty,5}-6{empty,5} y");
            for(int i =1; i<=4; i++)
            {
                valueOfTwoXSquared = valueOfX * valueOfX*2;
                valueOfNegativeX = -(valueOfX);
                negativeValue = -6;
                valueOfY = valueOfTwoXSquared + valueOfNegativeX + negativeValue;

                Console.WriteLine($"{valueOfX,2:f1}{valueOfTwoXSquared,7:f1}{valueOfNegativeX,7:f1}{negativeValue,7}{valueOfY,7:f1}");
                valueOfX += 0.5f;
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Write code to reverse the digits of a positive integer number. For example, if 
        /// the number 8735 is entered, the number displayed should be 5378. (Hint: Use a do 
        /// statement and continuously strip off and display the units digit of the number. 
        /// If the variable num initially contains the number entered, the units digit is 
        /// obtained as (num % 10). After a units digit is displayed, dividing the number 
        /// by 10 sets up the number for the next iteration. Thus, (8735 % 10) is 5 and 
        /// (8735 / 10) is 873. The do statement should continue as long as the remaining 
        /// number is not zero).
        /// </summary>
        private static void Question7()
        {
            Console.Write("Enter digits to reverse: ");
            int digits = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;
            string reversedString = "";
            do {
                reversed = digits % 10;
                digits /= 10;
                reversedString += reversed.ToString();
            } while (digits != 0);
            Console.WriteLine($"\nReversed Number is: {reversedString}\n");
        }
    }
}
