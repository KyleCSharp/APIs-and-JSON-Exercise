using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void Weather()
        {
            var client = new HttpClient();
            var apiKey = "99ea03e8cde48abd35ff6c19d8578ac3";
            while (true)
            {
                Console.WriteLine();
                TypeWriter.TypeLine("Please Enter the city name or type exit to exit ");
                Console.WriteLine();
                Console.WriteLine ("read in F");
                
                var cityName = Console.ReadLine();
                if (cityName.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }
                var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={apiKey}";
                var response = client.GetStringAsync(weatherURL).Result;
                var formatted = JObject.Parse(response).GetValue("main").ToString();
                Console.WriteLine();
                TypeWriter.TypeLine(formatted);
                Console.WriteLine();

            }

        }
    }
}
