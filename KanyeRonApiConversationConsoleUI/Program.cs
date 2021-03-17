using System;
using System.Net.Http;
using KanyeRonApiConversationLibrary.Logic;
using KanyeRonApiConversationLibrary.Model;
using Newtonsoft.Json.Linq;

namespace KanyeRonApiConversationConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ApiModel kanyeApi = ApiGenerator.CreateApiConnection("https://api.kanye.rest/", "quote");
                ApiModel ronApi = ApiGenerator.CreateApiConnection("https://ron-swanson-quotes.herokuapp.com/v2/quotes");

                Console.WriteLine($"\"{kanyeApi.NewJToken}\", Kanye says.");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.WriteLine($"Ron replies, \"{ronApi.NewJToken}\"");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }

            Console.WriteLine("Kanye and Ron end their conversation. The end.");
            Console.ReadLine();
        }
    }
}
