using System.ComponentModel;
using System.Threading;
using System;
using AssignmentOOP04.Part01.Question01;
using System.Drawing;
using System.IO;
using System.Numerics;
using complex = AssignmentOOP04.Part01.Question03 ;
using AssignmentOOP04.Part01.Question04;
using AssignmentOOP04.Part01.Question05;
using AssignmentOOP04.Part02;
using System.Security.Claims;

namespace AssignmentOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Q01
            //Q1) Write a class named Calculator that contains a method named Add.Overload the Add method to:
            //Accept two integers and return their sum.
            //Accept three integers and return their sum.
            //Accept two doubles and return their sum.

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2));
            //Console.WriteLine(calculator.Add(1, 2, 3)); 
            //Console.WriteLine(calculator.Add(1.1, 2.2)); 
            #endregion
            #region Q02
            //(Q2) Create a class named Rectangle with the following constructors:
            //    A parameterless constructor that sets the width and height to 0.
            //    A constructor that accepts width and height as integers.
            //    A constructor that accepts a single integer and sets both width and height to that value.
            //Part01.Question01.Rectangle rectangle = new Part01.Question01.Rectangle(3);
            //Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");


            #endregion
            #region Q03
            //Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
            //* Note: Overload the +, - operator to add and subtract two complex numbers.
            //complex.Complex c1 = new complex.Complex() { Real = 1, Img = 2 };
            //complex.Complex c2 = new complex.Complex() { Real = 3, Img = 4 };
            //Console.WriteLine(c1 + c2);
            #endregion
            #region Q4
            //Question 4)   
            //a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
            //b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            //    *Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.
            //Employee employee = new Employee();
            //Employee manger = new Manager();
            //employee.Work();
            //manger.Work();

            #endregion
            #region Q05
            //a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
            //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
            //C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
            // Then explain the difference between using override and new (using binding behavior)
            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();
            //BaseClass derivedClass1 = new DerivedClass1();
            //derivedClass1.DisplayMessage();
            //DerivedClass2 D2 = new DerivedClass2();
            //D2.DisplayMessage();
            //BaseClass derivedClass2 = new DerivedClass2();
            //derivedClass2.DisplayMessage();
            #endregion
            #endregion
            #region Part 02
            //Duration duration1 = new Duration(1, 30, 45);
            //Console.WriteLine(duration1); 
            //Duration duration2 = new Duration(3600);
            #region 3.Run All Required Constructors to Produce this output:
            //Duration D1 =new Duration(1,10,15);

            //Duration D1 = new Duration(3600);

            //Duration D1 = new Duration(7800);

            //Duration D1 = new Duration(666);

            //Console.WriteLine(D1);
            #region 4-Implement All required Operators overloading to enable this Code:
            Duration D1 = new Duration(1, 10, 15);

            Duration D2 = new Duration(3600);//1Hour

            Duration D3 = new Duration(7800);

            #region D3=D1+D2

            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            #endregion

            #region D3 = D1 + 7800
            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            #endregion

            #region D3=666+D3
            //D3 = 666 + D3;
            //Console.WriteLine(D3);
            #endregion

            #region D3 = ++D1 (Increase One Minute)

            //D3 = ++D1;
            //Console.WriteLine(D3);
            #endregion

            #region D3 = --D2 (Decrease One Minute)
            //D3 = --D1;
            //Console.WriteLine(D3);
            #endregion

            #region If(D1>D2) 
            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1>D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1<D2");
            //}
            #endregion

            #region D1= D1 - D2
            //D1 = D1 - D2;
            //Console.WriteLine(D1);
            #endregion

            #region If(D1<=D2)
            //if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 <= D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1 >= D2");

            //}
            #endregion

            #region If(D1)
            //if (D1)
            //    Console.WriteLine(D1);
            //else
            //    Console.WriteLine(new Duration());
            #endregion

            #region DateTime Obj = (DateTime)D1
            //DateTime obj = (DateTime)D1;
            //Console.WriteLine(obj);

            #endregion
            #endregion

            #endregion

            #endregion

        }
    }
}
