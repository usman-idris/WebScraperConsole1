using System;
using System.Linq;
using HtmlAgilityPack;

/// <summary>
/// A webscraping application that gets information from multiple webpages with the same signature
/// Incremente with numbers
/// </summary>
namespace WebScraperConsole1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String m = "";
            String err = "";
            int counter = 281; //The number of webpage to start
            string url = "https://boxnovel.com/novel/chronicles-of-primordial-wars/chapter-"; //The signature url
            HtmlWeb web = new HtmlWeb();

            try
            {
                while (counter <= 846)
                {
                    HtmlDocument doc = web.Load(url + counter);

                    var HeaderNames = doc.DocumentNode.SelectNodes("//div[@class='text-left']").ToList();
                    foreach (var item in HeaderNames)
                    {
                        m += item.InnerText;
                        Console.WriteLine(item.InnerText);
                    }

                    counter++;
                }
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            finally
            {
                TextCreate txt = new TextCreate(m);
                txt.CreateFile();
                Console.WriteLine(err);
            }
        }
    }
}
