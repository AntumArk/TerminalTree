using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Terminal_Tree
{
   public class FancyWriter
    {

     public   static void WriteSlow(string sentence)
        {
            foreach (var letter in sentence)
            {

                Console.Write(letter);
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }
       public static void WriteSlow(string sentence,int duration)
        {
            foreach (var letter in sentence)
            {

                Console.Write(letter);
                Thread.Sleep(duration/sentence.Length);
            }
            Console.WriteLine();
        }
    }
}
