using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void PrimeFactor(long a)
        {
            for (int i = 1; i < 10000; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void SmalestMultiple()
        {
            const ushort ARRAY_SIZE = 21;
            ushort[] array = new ushort[ARRAY_SIZE];
            ushort check = 0;
            for (uint value = 1; value < uint.MaxValue; value++)
            {
                for (ushort j = 1; j < ARRAY_SIZE; j++)
                {
                    array[j] = j;
                    if (value % array[j] == 0)
                    {
                        check++;
                    }
                }
                if (check == 20)
                {
                    Console.WriteLine("The value is {0}", value);
                }
                else
                {
                    check = 0;
                }
            }
        }

        static void Palindrome()
        {
            int palindrom = 0;
            string str;
            int max = 0;
            for(int i = 100; i < 1000; i++)
            {
                for ( int j = 100; j < 1000; j++)
                {
                    palindrom = j * i;
                    str = palindrom.ToString();
                    char[] rev = str.ToCharArray();
                    Array.Reverse(rev);
                    
                    if (String.Join("", rev) == str)
                    {
                        if (max < palindrom)
                        {
                            max = palindrom;
                        }
                    }
                    

                }

            }
            Console.WriteLine(max);

        }

        static void SquareDifferance()
        {
            double maxSumSquare = 0;
            double min = 0;
            double resulet = 0;
            for (int i = 1; i <101; i++)
            {
                maxSumSquare += Math.Pow(i,2);
            }

            for (int i = 1; i < 101; i++)
            {
                min += i;
            }
            min = Math.Pow(min, 2);
            resulet = min - maxSumSquare;

            Console.WriteLine(resulet);
        }

        static void prime()
        {
            for (int i = 1; i < 20; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Done  PrimeFactor(600851475143);
            //Done  SmalestMultiple();
            //Done  Palindrome();
            //Done  SquareDifferance();
            prime();
        }
    }
}