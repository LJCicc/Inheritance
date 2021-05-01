using System;

namespace inheritance
{
    class shape
    {
        public double width;
        public double height;
        public double rad;
        public void showShapeDimension()
        {
            Console.WriteLine("Width and height you put in were: {0} and {1}", width, height);
        }
        public void showCircleDimension()
        {
            Console.WriteLine("The radius you put in was: {0}", rad);
        }
    }
    class triangle : shape
    {
        public string type;
        public double area()
        {
            double area = (width * height) / 2;
            return (area);
        }
        public void showType()
        {
            Console.WriteLine("It is a {0} triangle.", type);

        }
    }
    class square : shape
    {
        public string type;
        public double area()
        {
            double area = width * height;
            return (area);
        }
        public void showType()
        {
            Console.WriteLine("It is a {0}.", type);

        }
    }
    class circle : shape
    {
        public double area()
        {
            double area = 3.14 * (rad * rad);
            return (area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i == 0)
            {
                Console.WriteLine("What kind of shape?");
                Console.WriteLine("Input any of the following: Triangle, Square, or Circle");
                string user_shape = Convert.ToString(Console.ReadLine());
                if (user_shape.ToUpper() == "TRIANGLE")
                {
                    triangle t1 = new triangle();

                    t1.type = "isosceles";
                    Console.WriteLine("Give the dimensions for a triangle:");
                    Console.WriteLine("Width:");
                    t1.width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Height:");
                    t1.height = Convert.ToDouble(Console.ReadLine());
                    if(t1.width == t1.height)
                    {
                        t1.type = "right";
                    }
                    else
                    {
                        t1.type = "isosceles";
                    }

                    Console.WriteLine("Info for t1: ");
                    t1.showType();
                    t1.showShapeDimension();
                    Console.WriteLine("Area is " + t1.area());


                    Console.WriteLine("Want to find the area of another shape?");
                    string ans = Convert.ToString(Console.ReadLine());
                    if(ans.ToUpper() == "YES" || ans.ToUpper() == "Y")
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                }
                else if (user_shape.ToUpper() == "SQUARE")
                {
                    square s1 = new square();
                    square s2 = new square();

                    s1.type = "Rectangle";
                    Console.WriteLine("Give the dimensions for a rectangle: ");
                    Console.WriteLine("Width:");
                    s1.width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Height:");
                    s1.height = Convert.ToDouble(Console.ReadLine());

                    s2.type = "Square";
                    Console.WriteLine("Give the dimensions for a square: ");
                    Console.WriteLine("Width:");
                    s2.width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Height:");
                    s2.height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Info for s1: ");
                    s1.showType();
                    s1.showShapeDimension();
                    Console.WriteLine("Area is: {0}", s1.area());
                    Console.WriteLine();
                    Console.WriteLine("Info for s2: ");
                    s2.showType();
                    s2.showShapeDimension();
                    Console.WriteLine("Area is: {0}", s2.area());

                    Console.WriteLine("Want to find the area of another shape?");
                    string ans = Convert.ToString(Console.ReadLine());
                    if (ans.ToUpper() == "YES" || ans.ToUpper() == "Y")
                    {
                        i = 0;
                    }
                    else
                    {
                        Console.WriteLine("Bye!");
                        i = 1;
                    }
                }
                else if (user_shape.ToUpper() == "CIRCLE")
                {
                    circle c1 = new circle();

                    Console.WriteLine("Give the radius for the circle: ");
                    Console.WriteLine("Radius: ");
                    c1.rad = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Infor for the circle: ");
                    c1.showCircleDimension();
                    Console.WriteLine("Area is: {0}", c1.area());

                    Console.WriteLine("Want to find the area of another shape?");
                    string ans = Convert.ToString(Console.ReadLine());
                    if (ans.ToUpper() == "YES" || ans.ToUpper() == "Y")
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                }
                else
                {
                    Console.WriteLine("That wasn't one of the options");
                }
            }
            

        }
    }
  
}
