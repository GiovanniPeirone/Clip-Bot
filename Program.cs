using System;
using PuppeteerSharp;

namespace HelloWorld
{
    class Program
    {
        static async void Main(string[] args)
        {
            string url = "https://www.twitch.tv/";
            string chorme = @"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            using var borowser = new BrowserFetcher();
            await borowser.DownloadAsync();

            await using var browser = await Puppeteer.LaunchAsync(
                new LaunchOptions
                {
                    Headless = true,
                    ExecutablePath = chorme,
                });


            await using var page = await browser.NewPageAsync();

            await page.GoToAsync(url);

            List<String> titles = new List<string>();





        }
    }
}   
 