using System;

namespace functions
{
    class Program
    {

        static void Main(string[] args)
        {
            float sum(float a, float b)
            {
                return a + b;
            }

            float prod(float a, float b)
            {
                return a * b;
            }
            float div(float a, float b)
            {
                return a / b;
            }
            float a, b, o;
            string op;
            Console.WriteLine("Enter the 1st number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            b = float.Parse(Console.ReadLine());

            

                Console.WriteLine("Choose + , x , / or S to stop");
                op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        o = sum(a, b);
                        Console.WriteLine("a+b =" + o);
                        break;
                    case "x":
                        o = prod(a, b);
                        Console.WriteLine("a x b =" + o);
                        break;
                    case "/":
                        if (b != 0)
                        {
                            o = div(a, b);
                            Console.WriteLine("a/b =" + o);
                        }
                        else
                        {

                            Console.WriteLine("IMPOSSIBLE");

                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
         

        }
    }



}