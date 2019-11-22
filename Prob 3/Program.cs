using System.Net;
namespace Prob_3
{
    class Program
    {

        //2. Write a program that downloads a file from the Internet(e.g.Ninja image) and stores it the current directory.
        //    Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.


        static void Main(string[] args)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjU1rDD8v3lAhWOLewKHVeaC2oQjRx6BAgBEAQ&url=https%3A%2F%2Fdepositphotos.com%2F36692817%2Fstock-illustration-christmans-backround.html&psig=AOvVaw2HdE2Eozr1sdfp2hbfbJXp&ust=1574514712604289", @"C:\Users\Andrei\Desktop\S7e1\Prob 3\");
            }
            catch (WebException e)
            {
                throw new WebException();
            }
            //catch (NotSupportedException e)
            //{
            //    throw new NotSupportedException();
            //}
            
        }
       


    }
}
