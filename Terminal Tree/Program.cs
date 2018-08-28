using System;
using System.Threading;

namespace Terminal_Tree
{
    class Program
    {
       
        static void Main(string[] args)
        {
            FancyWriter.WriteSlow("Hello World!");
            FancyWriter.WriteSlow("My name is Terminal Tree. I am here to guide you to do various tasks and decisions.");
            FancyWriter.WriteSlow("Do you want to continue?");
            if (FancyReader.AwaitConfirmation())
            {
                FancyWriter.WriteSlow("What shall we do?");
                FancyWriter.WriteSlow("We shall "+ FancyReader.AwaitResponse());

            }

            
            
            Console.ReadKey();

        }
        
    }
}
