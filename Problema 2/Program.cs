using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {

        //1. Write a program that enters the file name along with its full file path(e.g.C:\WINDOWS\win.ini), reads its contents and prints it on the
        //    console.Find in MSDN how to use System.IO.File.ReadAllText(...). Be sure to catch all possible exceptions and print user-friendly error messages.
        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Andrei\Desktop\S7e1\Problema 2\draft.txt");

                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }
            }


            catch (ArgumentException e)
            {
                Console.WriteLine("ArgumentException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw new ArgumentException();
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("UnauthorizedAccessException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw new UnauthorizedAccessException();
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("NotSupportedException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw new NotSupportedException();
            }
            //catch (PathTooLongException e)
            //{
            //    throw new FileException(e);
            //}
            //catch (DirectoryNotFoundException e)
            //{
            //    throw new FileException(e);
            //}
            //catch (FileNotFoundException e)
            //{
            //    throw new FileException(e);
            //}
            //catch (IOException e)
            //{
            //    throw new FileException(e);
            //}
           
            //catch (SecurityException e)
            //{
            //    throw new FileException(e);
            //}
            //Nu ma lasa sa le folosesc


        }


    }
}
