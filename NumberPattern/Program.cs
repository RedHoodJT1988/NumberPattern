namespace NumberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            //Example2();
            //Example3();
            //Example4();
            //Example5();
            //Example6();
            //Example7();
            //Example9();
            //Example10();
            Example11();
        }

        public static void Example1()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example2()
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example3()
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = x; y <= 5; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example4()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y <= 5; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example5()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example6()
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = 5; y >= x; y--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example7()
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example8()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 5; y >= x; y--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example9()
        {
            int x, y;
            for (x = 6; x >= 1; x--)
            {
                for (y = x; y >= 1; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example10()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 6; y >= x; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example11()
        {
            int x, y;
            for (x = 7; x >= 1; x -= 2)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}