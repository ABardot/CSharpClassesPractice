using System;


namespace CSharpClassesPractice
{
    class Program
    {
        static void Main()
        {

            Engine v4 = new Engine();
            v4.Size = "v4";
            v4.HorsePower = 200;
            v4.FuelConsumption = 1.6;


            Engine v6 = new Engine();
            v6.Size = "v6";
            v6.HorsePower = 300;
            v6.FuelConsumption = 2.6;

            Engine v8 = new Engine();
            v8.Size = "v8";
            v8.HorsePower = 500;
            v8.FuelConsumption = 3.7;

            AssemblyRobot robot = new AssemblyRobot();
            Auto myCar = robot.AssembleCar("M5", v8);
            Console.WriteLine(myCar.Engine.HorsePower.ToString());

            

            //Auto myCar = new Auto();
            //myCar.Engine = v8;

            //Console.WriteLine(myCar.Engine.HorsePower.ToString());
            //Console.WriteLine(myCar.Engine.Size.ToString());
            //Console.WriteLine(myCar.Engine.FuelConsumption.ToString());

            //Auto myCar = new Auto();
            //myCar.CurrentSpeed = 40;
            //myCar.Make = "BMW";
            //myCar.Model = "M3";
            //myCar.Year = 2018;
            //myCar.Color = "Black";
            //myCar.Miles = 10000;

            //Console.WriteLine(myCar.Make  + " " + myCar.Model);

            ////myCar.Accelerate(5);
            ////myCar.Accelerate(6);


            //int myCurrentSpeed = 0;

            ////myCurrentSpeed = myCar.Accelerate(8);
            ////Console.WriteLine("My current speed: " + myCar.CurrentSpeed);

            //myCurrentSpeed = myCar.Decelerate(100);
            //Console.WriteLine("My current speed: " + myCar.CurrentSpeed);

            //string message = myCar.SpeedLimitViolation("Warning: ", 100);
            //Console.WriteLine(message);
        }
    }
}
