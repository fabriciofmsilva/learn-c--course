﻿using System;
using System.Net;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("https://www.google.com");
                Console.WriteLine(googleMainPage);
            }
        }
    }
}
