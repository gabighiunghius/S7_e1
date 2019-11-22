using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7e1
{
    class Program
    {
        static void Main(string[] args)
        {

            Readnumber();
           
        }




        //            3. Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end ).
        //If an invalid number or non-number text is entered, the method should throw an exception.

        //Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
        //Output
        //Print 1 < a1< ... < a10< 100
        //Or Exception if the above inequality is not true

        public static void Readnumber()
        {
            try
            {
                Console.WriteLine("Enter range:");

                Console.WriteLine("Start:"); string n = Console.ReadLine();
                int nr1 = int.Parse(n);

                Console.WriteLine("End:"); string m = Console.ReadLine();
                int nr2 = int.Parse(m);

                if (nr1 == 0 && nr2 == 0)
                {
                    throw new BothArgsAreZeroException();
                }
                              

                int[] arr = new int[10];
                int i;


                Console.Write("Input 10 elements in the array :\n");
                for (i = 0; i < 10; i++)
                {
                   
                    Console.Write("element - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());


                }
                if (arr[i] < nr1 && arr[i] > nr2)
                {
                    throw new RangeException();
                } ///DE CE NU MA LASA SA ADAUG EXCEPTIE IN FOR, in timp ce scriu elementele, si ma lasa numai la final?


                int temp = 0;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
                    {
                        if (arr[sort] > arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }


                }
                int j = 0;
                Console.Write("\nFinal : ");
                Console.Write("\n");
                Console.WriteLine("1");
                for (j = 0; j < arr.Length; j++)
                {
                    Console.Write("{0}  ", arr[j]);
                }
                Console.WriteLine("100");

                Console.Write("\n");

            }
            catch (FormatException e)
            {
                throw new FormatException("my exception", e);

                Console.WriteLine($"ArgumentException {e.StackTrace}");

            }
            catch (BothArgsAreZeroException e)
            {
                throw new BothArgsAreZeroException("my exception", e);

                Console.WriteLine($"BothArgsAreZeroException {e.StackTrace}");
            }
            catch (RangeException e)
            {
                throw new RangeException("my exception", e);
                Console.WriteLine($"RangeException {e.StackTrace}");
            }

            finally
            {
                Console.WriteLine("Mesaj de final");
            }
            Console.ReadKey();

            
        }
    }
}
