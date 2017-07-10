using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Methods are a tool for us to create reusable pieces of code.
            ////Methods are a way of us collecting a series of instructions and then call then when we need them.
            ////Methods are ALWAYS a part of a class. Methods are ALWAYS children of classes.
            ////This means a method will NEVER be inside antoher method or member of the class.
            ////However, methods are frequently CALLED inside of another class or method.

            //Console.WriteLine("Hello. Please enter the first number to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);
            //Console.WriteLine("The sum of your two answers is " + answer);

            //RobotWarning("Will Robinson");
            //Useless();
            //string myBirthMonth = "Septemeber";
            //string myVehicle = "December";
            //string myFriendVehicle = Vehicle(myBirthMonth);
            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendVehicle);

            //FavoriteFood("Paige's", "Pizza");
            //int years = RetirementCalculator(65);
            //Console.WriteLine("The user will retire in {0} years", years);

            //double hoursWorked = 42.3d;
            //double hourlyWage = 12.50d;
            //WageCalculator(hoursWorked, hourlyWage);
            //Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorked, hourlyWage));




        }
        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    //static means we do not have to worry about objects right now

        //    //method body
        //    //A complete method - header and body - is called a method declaration

        //    int sum = firstNumber + secondNumber;

        //    return sum;
        //    //the "return" keyword take whatever value is determined by using this method
        //    //and sends that value back to where I call my method
        //}



        ////If you have a method that does not have a return value, you would use the keyword
        ////"void". When we have a "void" return type we DON'T need to use the keyword RETURN.
        //public static void RobotWarning(string name)
        //{
        //    Console.WriteLine("Danger, " + name + "!!");
        //}

        //public static void Useless()
        //{
        //    Console.WriteLine("Blah blah blah");
        //}

        //public static string Vehicle(string birthMonth)
        //{
        //    string vehicleFortune;
        //    if (birthMonth.ToUpper() == "September" || birthMonth.ToUpper() == "October")
        //    {
        //        vehicleFortune = "Hoverboard";
        //    }
        //    else
        //    {
        //        vehicleFortune = "SUV";
        //    }
        //    return vehicleFortune;
        //}
        ////Method header
        ////Access Modifier - Return Type - Method Name (Pascal Case) - Parentheses (sometimes with parameters)


        ////Create a method called FavoriteFood
        ////It should take two string parameters. One representing a name, and the other representing a favorite food.
        ////the return type should be void
        ////The method should concatenate

        
        //public static void FavoriteFood(string name, string food)
        //{
        //    Console.WriteLine("{0} favorite food is {1} ", name, food);
        //}

        //Create a method called RetirementCalculator
        //It should take and int as a parameter representing the user's age
        //The method should calculate how mant more years until the user retires using 65 as the age of retirement.
        //the return type should not be a void, should be an int.
        //once it calculates the users retirement age it should print
        //"the user will retire in X years" where X represents the value that was calculated.

    //    public static int RetirementCalculator(int age)
    //    {
    //        int years;            
    //        switch (age)
    //        {
    //            case 30:
    //                years = 5;
    //                break;
    //            case 40:
    //                years = 10;
    //                break;

    //            default:
    //                years = 15;
    //                break;
    //        }
    //        return years;

    //}


    //    public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
    //    {
    //        //this method should calulate the MONTHLY wage
    //        double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
    //        return monthlyWage;
    //    }




    }//end program class
}

  






