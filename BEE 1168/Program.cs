using System;

namespace BEE_1168
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int N = Convert.ToInt32(Console.ReadLine());
           
            int i = 0;
           
           while (i<N)
            {
                string get = Console.ReadLine();
                char[] array = get.ToCharArray();
                int leds = 0;
                for (int l = 0; l < array.Length; l++)
                {
                    if (array[l] == '1')
                    {
                        leds += 2;
                    }
                    if (array[l] == '2' || array[l] == '3' || array[l] == '5')
                    {
                        leds += 5;
                    }
                    if (array[l] == '6' || array[l] == '9' || array[l] == '0')
                    {
                        leds += 6;
                    }
                    if (array[l] == '8')
                    {
                        leds += 7;
                    }
                    if (array[l] == '7')
                    {
                        leds += 3;
                    }
                    if (array[l] == '4')
                    {
                        leds += 4;

                    }
                    
                       
                }
                Console.Write($"{leds} leds");
                i++;
                Console.WriteLine();

               
            }
            




        }
    }
}
