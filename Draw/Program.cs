using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {


            Draw();



            Console.Read();
        }
        static private void Calcul()
        {
            double x = 0;
            double y = 0;
            string math;
            Console.WriteLine("enter number: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("enter again:");
            y = double.Parse(Console.ReadLine());

            Console.Write("\nEnter the operation: ");

            math = (Console.ReadLine());
            switch (math)
            {
                case "*":
                    Console.WriteLine($"{x}*{y}={x * y}");
                    break;

                case "X":
                    Console.WriteLine($"{x}*{y}={x * y}");
                    break;
                case "+":
                    Console.WriteLine($"{x}+{y}={x + y}");
                    break;
                case "/":
                    if (x == 0)
                    {
                        Console.WriteLine("INVALID OPERATiON");

                    }
                    else
                    {
                        Console.WriteLine($"{x}/{y}={x / y}");

                    }
                    break;

                default:
                    Console.WriteLine("Could not evaluate the expression.");
                    break;
            }

        }
        static private void Draw()
        {
            int X = 0;
            int Y = 0;
            int A = 0;
            int B = 0;
            int avelocit = 2;
            int bvelocit = 2;
            int xvelocity = 3;
            int yvelocity = 3;
            bool operation = true;
            int bole = 7;
            bool ioperation = true;


            CDrawer canvas = new CDrawer();
            canvas.Scale = 5;
            canvas.ContinuousUpdate = false;


            while (operation)
            {
                canvas.AddCenteredEllipse(X, Y, 10, 10, Color.Aqua, 6);
                canvas.AddLine(X, Y, 88, 4, Color.Red, 4);


                canvas.Render();
                System.Threading.Thread.Sleep(10);



                canvas.Clear();



                X += xvelocity;
                Y += yvelocity;





                if ((Y >= canvas.ScaledHeight) || (Y <= 0))
                    yvelocity *= -1;

                //check for left or right side of the screen
                if ((X >= canvas.ScaledWidth) || (X <= 0))
                    xvelocity *= -1;
                if (ioperation)
                {
                    canvas.AddCenteredEllipse(A, B, 10, 10, Color.Red, 5);
                    canvas.AddLine(A, B, 85, 4, Color.Blue, 6);

                    canvas.Render();
                    System.Threading.Thread.Sleep(bole);
                    canvas.Clear();

                    A += avelocit; _ = A != X;
                    B += bvelocit; _ = B != Y;


                    if ((A >= canvas.ScaledWidth) || (A <= 0))
                        avelocit *= -1;
                    if ((B >= canvas.ScaledHeight) || (B <= 0))
                        bvelocit *= -1;

                }

            }



            Console.Read();


        }
    }
}
