using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class restart
    {
        public static void redo()
        {
            while (true)
            { 
                TypeWriter.TypeLine("would you like to see quotes or get the weather?  please Type one or the other.");
                Console.WriteLine();

                var UserResponce = Console.ReadLine();
                if (UserResponce.ToLower() == "quotes")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        RonVSKanyeAPI.KanyeQuote();

                        RonVSKanyeAPI.RonQuote();
                        
                   
                    }
                }
                if (UserResponce.ToLower() == "weather")
                {
                    OpenWeatherMapAPI.Weather();
                }
                if (UserResponce.ToLower() == "exit")
                {

                Environment.Exit(0);

                }

            }
           





        }


    }
}
