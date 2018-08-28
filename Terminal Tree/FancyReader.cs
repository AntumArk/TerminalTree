using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal_Tree
{
  public  class FancyReader
    {



        public static bool AwaitConfirmation()
        {
            List<string> OKStrings = new List<string>()
            {
                "Yes",
                "Ok",
                "OK",
                "taip"
            };
            List<string> NOStrings = new List<string>()
            {
                "No",
                "NO",
                "Ne",
                "Never"
            };
            bool receivedResult = false;
            bool resultValue = false;
            string result = "";
            bool firstRead = true;

            while(!receivedResult)
            {   if (!firstRead)
                    FancyWriter.WriteSlow("I did not get that... Please repeat that.");
                var inString = Console.ReadLine();
                var words = inString.Split(" ");
                foreach (var word in words)
                {
                    if(OKStrings.Contains(word))
                       
                    {
                        receivedResult = true;
                        result = word;
                        resultValue = true;
                        FancyWriter.WriteSlow("Ok is ok. Proceding...");
                        break;
                    }
                    if (NOStrings.Contains(word))
                    {
                        receivedResult = true;
                        result = word;
                        resultValue = false;
                        FancyWriter.WriteSlow("It's treason then!");
                    }

                }
                firstRead = false;
            }
            
            return resultValue;

        }
        public static string AwaitResponse()
        {
         /*   List<string> OKStrings = new List<string>()
            {
                "Yes",
                "Ok",
                "OK",
                "taip"
            };
            List<string> NOStrings = new List<string>()
            {
                "No",
                "NO",
                "Ne",
                "Never"
            };
            bool receivedResult = false;
            bool resultValue = false;
            string result = "";
            bool firstRead = true;

            while (!receivedResult)
            {
                if (!firstRead)
                    FancyWriter.WriteSlow("I did not get that... Please repeat that.");
                var inString = Console.ReadLine();
                var words = inString.Split(" ");
                foreach (var word in words)
                {
                    if (OKStrings.Contains(word))

                    {
                        receivedResult = true;
                        result = word;
                        resultValue = true;
                        FancyWriter.WriteSlow("Ok is ok. Proceding...");
                        break;
                    }
                    if (NOStrings.Contains(word))
                    {
                        receivedResult = true;
                        result = word;
                        resultValue = false;
                        FancyWriter.WriteSlow("It's treason then!");
                    }

                }
                firstRead = false;
            }*/

            return Console.ReadLine();

        }
    }
}
