﻿using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Formatters;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
            
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
