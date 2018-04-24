using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassesPractice
{
    class Auto
    {
        private string make;
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        private int speed;

        public string Make
        {
            get { return make; }
            set
            {
                switch (value)
                {
                    case "BMW":
                        make = value;
                        break;
                    case "Audi":
                        make = value;
                        break;
                    default:
                        throw new Exception("Not a valid Make");
                }

            }
        }


        public int CurrentSpeed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else if (value > 100)
                {
                    speed = 110;
                }
                else
                {
                    speed = value;
                }
            }
        }




        public int Accelerate(int increasedSpeed)
        {
            CurrentSpeed += increasedSpeed;
            //Speed++;
            //Console.WriteLine("Current speed: " + Speed.ToString());
            writeLine("Current speed: " + CurrentSpeed);
            return speed;
        }

        public int Decelerate(int decreasedSpeed)
        {
            CurrentSpeed += decreasedSpeed;
            //Speed--;
            //Console.WriteLine("Current speed: " + Speed.ToString());
            writeLine("Current speed: " + CurrentSpeed);
            return speed;
        }

        public string SpeedLimitViolation(string inititalMessage, int speedLimit)
        {
            string message = "";

            if (CurrentSpeed > speedLimit)
            {
                message =  "Too Fast!";
            }
            else if (CurrentSpeed < speedLimit)
            {
                message =  "Too Slow!";
            }
            else
            {
                message = "You're Okay";
            }

            return inititalMessage + " " + message;
        }

        private void writeLine(string message)
        {
            Console.WriteLine("From my helper method");
            Console.WriteLine(message);
        }
    }
}
