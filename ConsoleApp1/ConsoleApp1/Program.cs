using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp1
{
    class ConsoleApp1
    {

        static void Main(string[] args)
        {
            // نساله ع الاسم والسن ونطبعله الاتنين

            // نعمل كومكانتينيشن 
            //نساله ع المرتب والخصم ونطبع المرتب بعد الخصم


            // Console.Write("enter your name : ");
            // string name = Console.ReadLine();
            // Console.WriteLine("name is: " + name);
            // Console.WriteLine("enter your age : ");
            // string age = Console.ReadLine();
            // Console.WriteLine("age is: "+ age);


            // Console.WriteLine("enter your first name : ");
            // string s1 = Console.ReadLine();
            // Console.WriteLine("enter your last name : ");
            // string s2 = Console.ReadLine();
            // Console.WriteLine("full name is: "+ s1 + s2);


            // Console.WriteLine("enter yor salary : ");
            // double salary = double.Parse(Console.ReadLine());
            // Console.WriteLine("enter your tax ");
            // double tax = double.Parse(Console.ReadLine());
            //// salary -= (salary * tax /100);
            // salary = (salary - tax);
            // Console.WriteLine("the salary after tax is: {0} " , salary);


            //lec 2
            //int Num;
            //int rem;
            //Console.Write("Enter a num ");
            //Num = int.Parse(Console.ReadLine());

            //rem = Num % 2;
            //if (rem != 0) //odd
            //{
            //    Num *= 2;
            //}
            //Console.WriteLine(Num);

            //else if
            //write a prog that eight a grade and print "pass if g>60 ,fail otherwise

            //int grade;
            //Console.Write("enter the grade");
            //grade = int.Parse(Console.ReadLine());
            //if (grade >= 60)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("FAil");
            //}

            //write a prod thar read a grade and print 'A' if grade >=90 ,print 'B' if >=80 , print c if value=60, and  fail otherwise


            //int g;
            //Console.Write("enter the grade");
            //g = int.Parse(Console.ReadLine());
            //if (g >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (g >= 80 && g < 90)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (g >= 60 && g < 80)
            //{
            //    Console.WriteLine("c");
            //}
            //else
            //{
            //    Console.WriteLine("FAIL");
            //}


            //Read a num if num is 1  print one , if num is 2 print two  3 print three other print out oof range

            //int num;
            //Console.Write("enter a num");
            //num = int.Parse(Console.ReadLine());

            //if (num == 1)
            //{
            //    Console.WriteLine("One");
            //}
            //else if (num == 2)
            //{
            //    Console.WriteLine("Two");
            //}
            //else if (num == 3)
            //{
            //    Console.WriteLine("Three");
            //}

            //else
            //{
            //    Console.WriteLine("Out Of Range");
            //}

            //switch

            //int n;
            //Console.Write("enter a num");
            //n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:

            //        Console.WriteLine("One");
            //        break;


            //    case 2:

            //        Console.WriteLine("two");
            //        break;

            //    case 3:

            //        Console.WriteLine("three");
            //        break;

            //    default:

            //        Console.WriteLine("Out of range");
            //        break;





            //for
            //pro to fint sum from 1 to 100 


            //int count;
            //int sum = 0;
            //for (count = 1; count <= 100; count++)
            //{
            //    sum = sum + count;
            //}
            //Console.WriteLine($"Total={sum}");

            //Console.ReadLine();



            //even num fron 1 to n
            // int i, num, sum = 0;
            // Reading number
            //Console.Write("Enter any number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //for (i = 2; i <= num; i += 2)
            //{
            //    //Adding current even number to sum variable
            //    sum += i;
            //}
            //Console.WriteLine("Sum of all even number between 1 to " + num + " = " + sum);

            //Console.ReadLine();


            //task 1 get max and min  5 unm

            // int num1, num2 , num3, num4, num5;
            // Console.Write("enter a num1");
            // num1 = int.Parse(Console.ReadLine());

            // Console.Write("enter a num2");
            //num2= int.Parse(Console.ReadLine());

            // Console.Write("enter a num3");
            // num3 = int.Parse(Console.ReadLine());

            // Console.Write("enter a num4");
            // num4 = int.Parse(Console.ReadLine());

            // Console.Write("enter a num5");
            // num5 = int.Parse(Console.ReadLine());


            // int largest=0;


            // int smallest=0;


            //if ( (num1 > num2) && (num1> num3)  && (num1>num4) && (num1>num5) )
            //        {
            //    max = num1;
            //    Console.WriteLine(max);
            //}
            //else if((num2 > num1) && (num2 > num3) && (num2 > num4) && (num2 > num5)  )
            //{
            //    max = num2;
            //    Console.WriteLine(max);
            //}




            // max and min of five int

            //int max = int.Parse(Console.ReadLine());
            //int min = max;
            //for (int i = 0; i < 4; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    else if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine($"max : {max}, {min}");




            //D  quadratic
            //    float a, b, c, D, x1, x2;
            //    Console.WriteLine("enter a value of a");
            //    a = float.Parse(Console.ReadLine());
            //    Console.WriteLine("enter a value of b");
            //    b = float.Parse(Console.ReadLine());
            //    Console.WriteLine("enter a value of c");
            //    c = float.Parse(Console.ReadLine());

            //    D = float.Parse(Console.ReadLine());

            //    D = ((b * b) - (4 * a * c));

            //    if (D == 0)
            //    {
            //        Console.WriteLine("root are equal");

            //        x1 = - b / (2 * a);
            //        x2 = x1;

            //        Console.WriteLine("root x1 ={0}", x1);
            //        Console.WriteLine("root x1 ={0}", x2);

            //    }
            //    else if (D > 0)
            //    {

            //        Console.WriteLine("roots ar real");
            //        x1 = (-b + Math.Sqrt(D)) / (2.0 * a);
            //        x2 = (-b - Math.Sqrt(D)) / (2.0 * a);

            //        Console.WriteLine("root x1 ={0}", x1);
            //        Console.WriteLine("root x2 ={0}", x2);
            //    }




            //Console.Write("enter num a");
            //double a =double.Parse(Console.ReadLine());
            //Console.Write("enter num b");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("enter num c");
            //double c = double.Parse(Console.ReadLine());


            //double eq = ((b * b) - (4 * a * c));
            // eq = Math.Sqrt(eq);
            //if (eq>0)
            //{
                
            //    Console.WriteLine((-b+eq) /(2*a));
            //    Console.WriteLine((-b - eq) / (2 * a));

            //}
            //else if (eq==0)
            //{
            //    Console.WriteLine(-b/2*a);
            //    Console.WriteLine(-b / 2 * a);
            //}







        }

    }
    } 
    



//if (a != 0)
//{
//    D = b * b - 4 * a * c;
//}
//else
//{
//    Console.WriteLine("quad not right");
//}

//D = b * b - 4 * a * c;

//if (D >= 0)
//{
//    D = Math.Sqrt(D);
//    x1 = (-b + D) / (2 * a);
//    x2 = (-b - D) / (2 * a);

//    Console.WriteLine("x1= " + x1);
//    Console.WriteLine("x2= " + x2);


//}
//else
//{
//    Console.WriteLine("root not possible");
//}




