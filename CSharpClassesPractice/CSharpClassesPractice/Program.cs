using System;


namespace CSharpClassesPractice
{
    class Program
    {
        static void Main()
        {
            Auto myCar = new Auto();
            myCar.Speed = 100;
            myCar.Make = "BMW";
            myCar.Model = "M3";
            myCar.Year = 2018;
            myCar.Color = "Black";
            myCar.Miles = 10000;

            Console.WriteLine(myCar.Make  + " " + myCar.Model);

            //myCar.Accelerate();
            //myCar.Accelerate();
            //myCar.Accelerate();
            //myCar.Decelerate();

            Console.WriteLine("My current speed: " + myCar.Speed);
        } 
    }
}
