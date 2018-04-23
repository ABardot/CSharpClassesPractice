using System;


namespace CSharpClassesPractice
{
    class Program
    {
        static void Main()
        {
            Auto myCar = new Auto();
            myCar.CurrentSpeed = 40;
            myCar.Make = "BMW";
            myCar.Model = "M3";
            myCar.Year = 2018;
            myCar.Color = "Black";
            myCar.Miles = 10000;

            Console.WriteLine(myCar.Make  + " " + myCar.Model);

            myCar.Accelerate(5);
            myCar.Accelerate(6);
           

            int myCurrentSpeed = 0;

            myCurrentSpeed = myCar.Accelerate(8);
            Console.WriteLine("My current speed: " + myCar.CurrentSpeed);

            myCurrentSpeed = myCar.Decelerate(10);
            Console.WriteLine("My current speed: " + myCar.CurrentSpeed);

            string message = myCar.SpeedLimitViolation("Warning: ", 100);
            Console.WriteLine(message);
        } 
    }
}
