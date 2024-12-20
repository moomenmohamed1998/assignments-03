using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo


            #region value type casting

            #region implicit casting
            //int x = 4;//4 Bytes
            //long y = x;
            #endregion

            #region Explict casting
            //long x = 123456789987;//8 Bytes
            //int y;
            //checked
            //{
            //     y = (int)x;

            //}
            /*
              unchecked
            {
                 y = (int)x;
            }
             */
            //Console.WriteLine(y);

            /*
            int x = 80;
            double y = (int)x;
            Console.WriteLine(y);
            */



            #endregion

            #region Parse 

            //Console.WriteLine(" Enter Data User ");
            //Console.Write(" Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.Write(" Enter Age : ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write(" Enter Salary : ");
            //Double Salary = Double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine(" Name : " + Name + " Age : " + Age + " Salary : " + Salary);
            #endregion

            #region Convert

            //Console.WriteLine(" Enter Data User ");
            //Console.Write(" Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.Write(" Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" Enter Salary : ");
            //Double Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine(" Name : " + Name + " Age : " + Age + " Salary : " + Salary);

            #endregion



            #endregion


            #region Opreators

            #region Unary Operators [ ++ , -- ]
            //int x = 5;
            //Console.WriteLine(x);
            //Console.WriteLine(++x);

            //Console.WriteLine(--x);
            //Console.WriteLine(x--);

            #endregion

            #region Binary Operator
            //int sum, mul, sub, div, mod;

            //int A = 8;
            //int B = 5;

            //sum = A + B;
            //mul = A * B;
            //sub = A - B;
            //div = A / B;
            //mod = A % B;
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            //Console.WriteLine(sub);
            //Console.WriteLine(div);
            //Console.WriteLine(mod);

            #endregion

            #region Assignment Opreator
            //int x = 10;

            //x += 10;
            //x -= 10;
            //x *= 10;
            //x /= 10;
            //x %= 10;

            //Console.WriteLine(x);
            #endregion

            #region relation Operators

            //int A = 10;
            //int B = 10;
            //Console.WriteLine(A == B);
            //Console.WriteLine(A != B);


            #endregion

            #region Logical Operators [short circut]
            //Console.WriteLine(!true);

            //Console.WriteLine(true && false);
            //true  && true  ==> true
            //true  && false ==> false
            //false && true  ==> false
            //false && false ==> false


            //Console.WriteLine(true || false);
            //true  || true  ==> true
            //true  || false ==> true
            //false || true  ==> true
            //false || false ==> false

            #endregion

            #region Bitwise Operators [Log Circut]

            //Console.WriteLine(true & false);

            //true  & true  ==> true
            //true  & false ==> false
            //false & true  ==> false
            //false & false ==> false


            //Console.WriteLine(true | false);

            //true  | true  ==> true
            //true  | false ==> true
            //false | true  ==> true
            //false | false ==> false

            #endregion

            #region Ternary Operator 

            //int x = 4;
            //string Message = x > 4 ? " X greater than 4 ":" X Less than or Equal 4 " ;
            //Console.WriteLine(Message);

            #endregion



            #endregion


            #region Operator Periorety

            /*
            1.Unary Operator [ PreFix ]
            2. (   )
            3. * / %
            4. +  -
            */

            //int A = 20;
            //int B = 15;
            //int c = 10;
            //int D = 11;

            //int Result;

            //Result = (A + B) * c / D;
            //Result = A++ * c;

            //Console.WriteLine(Result);

            #endregion


            #region string format
            //Equation = x + y = Resulte
            //Equation = 10 + 5 = 15
            //-----------------------
            //int x = 5;
            //int Y = 10;
            //int Resulte = x + Y;


            #region 1. Composite Format
            //string message = string.Format("Equation = {0} + {1} = {2}" ,x,Y,Resulte);
            //Console.WriteLine(message);
            #endregion

            #region 2.String Manipolition
            //Console.WriteLine($"Equation = {x} + {Y} = {Resulte}");


            #endregion
            #endregion


            #region IF Else -&&- Swich Case


            //Console.WriteLine(" Enter Month Number ");
            //int monthNumber = int.Parse(Console.ReadLine());

            // 1 ===> Month is Jan
            // 2 ===> Month is Feb
            // 3 ===> Month is Mar
            // Invalid Input

            #region 1.IF
            /*
            if (monthNumber ==1)
              Console.WriteLine("Month is Jan");         
            else if (monthNumber == 2)           
              Console.WriteLine("Month is Feb");           
            else if (monthNumber == 3)           
              Console.WriteLine("Month is Mar");
            else 
            Console.WriteLine("Invalid Input");
            */

            //---------------------------
            /*
            Console.WriteLine(" Enter Name ");
            string Name = Console.ReadLine();

            if (Name == "Mostafa" || Name == "mosatfa")
            {
              Console.WriteLine("Hello Mostafa");
            }
            else if (Name == "Aliaa" || Name == "aliaa")
            {
              Console.WriteLine("Hello Aliaa");
            }
            else if (Name == "Ahmed" || Name == "ahmed") 
            {
              Console.WriteLine("Hello Ahmed");
            }
            */
            #endregion


            #region Switch
            /*
            switch(monthNumber)
            {

               case 1:
                   Console.WriteLine("Month is Jan");
                   break;

               case 2:
                   Console.WriteLine("Month is Jan");
                   break;

               case 3:
                   Console.WriteLine("Month is Jan");
                   break;

               default:
                   Console.WriteLine("Invalid Input");
                   break;
            }
            */

            //-----------------------------------------

            /*
            Console.WriteLine(" Enter Name ");
            string Name = Console.ReadLine();
            switch (Name)
            {
                case "Mostafa":
                case "mostafa":
                    Console.WriteLine("Hello Mostafa");
                    break;

                case "Aliaa":
                case "aliaa":
                    Console.WriteLine("Hello Aliaa");
                    break;

                case "Ahmed":
                case "ahmed":
                    Console.WriteLine("Hello Ahmed");
                    break;

            }
            */
            #endregion

            #endregion

            #region Goto
            //Console.WriteLine("Enter Option");

            //int Option = int.Parse(Console.ReadLine());
            //switch (Option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("option 02");
            //        goto case 1000;

            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //}
            #endregion

            #endregion

            #region Assignment 3 

            #region  - 1 -
            //1 - Write a program that takes a number from the user then print yes if
            //that number can be divided by 3 and 4 otherwise print no.
            /*
            Console.WriteLine("Enter Number:");
            int number = int.Parse(Console.ReadLine());

            if (number % 4 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            */
            #endregion

            #region - 2 -
            //2 - Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            /*
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());

            if (0 > number)
            {
                Console.WriteLine(" negative ");
            }
            else
            {
                Console.WriteLine(" positive ");
            }
            */
            #endregion

            #region - 3 -
            //3 - Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            /*
            Console.WriteLine("num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("num3: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine($"Input {num1} {num2} {num3}");

            Console.WriteLine("Output");
            Console.WriteLine($"max element: {max}");
            Console.WriteLine($"min element: {min}");
            */

            #endregion

            #region - 4 -
            //4- Write a program that allows the user to insert an
            //integer number then check If a number is even or odd.
            /*
            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)           
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
            */
            #endregion

            #region - 5 -

            //5- Write a program that takes character from the user then if it is a vowel
            //chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            /*
            Console.WriteLine("Enter a character ");
            string character = Console.ReadLine(); 

            if (character == "a" || character == "e" || character == "i" || character == "o" || character == "u")
            {
                Console.WriteLine("vowel ");
            }
            else
            {
                Console.WriteLine("consonant ");
            }
            */
            #endregion

            #region - 7 -
            //7- Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.

            #endregion

            #region - 9 -
            //Write a program that takes two integers then prints the power.
            /*
                       Console.WriteLine("Enter Num1 : ");
                        int Num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Num2 : ");
                        int Num2 = int.Parse(Console.ReadLine());

                        int result = Num1*Num1*Num1;

                        Console.WriteLine(result);
                        //how to calculate 4 ^ 3 = 4 * 4 * 4 = 64
            */
            #endregion

            #region - 10 -
            //10- Write a program to enter marks of five subjects and
            //calculate total, average and percentage.

            /*
            int mark1, mark2, mark3, mark4, mark5;

            Console.WriteLine(" Enter Marks of five subjects");

            Console.Write("Enter marks 1: ");
            mark1 = int.Parse(Console.ReadLine());

            Console.Write("Enter marks 2: ");
            mark2 = int.Parse(Console.ReadLine());

            Console.Write("Enter marks 3: ");
            mark3 = int.Parse(Console.ReadLine());

            Console.Write("Enter marks 4: ");
            mark4 = int.Parse(Console.ReadLine());

            Console.Write("Enter marks 5: ");
            mark5 = int.Parse(Console.ReadLine());

            int totalmarks = mark1 + mark2 + mark3 + mark4 + mark5;

            int average = totalmarks / 5;

            int percentage = (totalmarks * 100) / 500;
            Console.Clear();
            Console.WriteLine($"Total Marks: {totalmarks} " );
            Console.WriteLine($"Average Marks: {average} " );
            Console.WriteLine($"Percentage: {percentage} % " );
            */

            #endregion

            #region - 11 -
            //11 - Write a program to input the month number and
            //print the number of days in that month.
            /*
            Console.Write("Enter the Month Number  ");
            int month = int.Parse(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1: // January
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: // December
                    days = 31;
                    Console.WriteLine(days);
                    break;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    days = 30;
                    Console.WriteLine(days);
                    break;
            }
            */
            #endregion

            #region- 18 -
            /*18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */
            /*
            Console.Write("Enter the time: ");
            int time = int.Parse(Console.ReadLine());

            if (time >= 2 && time <= 3)
            {
                Console.WriteLine("they are considered highly efficient");
            }
            else if (time > 3 && time <= 4)
            {
                Console.WriteLine("Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: \r\n- If the worker completes the job within 2 to 3 hours, they are considered highly efficient. \r\n- If the worker takes 3 to 4 hours, they are instructed to increase their speed. \r\n- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. \r\n- If the worker takes more than 5 hours, they are required to leave the company. \r\nTo calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.\r\n");
            }
            else if (time > 4 && time <= 5)
            {
                Console.WriteLine("they are provided with training to enhance their speed");
            }
            else if (time > 5)
            {
                Console.WriteLine("they are required to leave the company");
            }
            else
            {
                Console.WriteLine("they are required to leave the company");
            }
            */
            #endregion

            #region - 21 -
            //21- Write C# program that Assigning one value type variable to another and
            //modifying the value of one variable and mention what will happen
            /*
               int x = 10;
                 int y = x;
                    y = 20;

                   Console.WriteLine($"Value of x: {x}");
                     Console.WriteLine($"Value of y: {y}");
                        */

            #endregion

            #region - 23 -

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            //b)A value 1 will be assigned to d 

            #endregion


            #region - 24 -

            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //d) 6 1
            #endregion

            #region - 25 -

            //int num = 1, z = 5;


            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            //d) 7 7

            #endregion

            #endregion

        }
    }
}
