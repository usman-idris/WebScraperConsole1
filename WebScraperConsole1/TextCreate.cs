using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WebScraperConsole1
{
    class TextCreate
    {
        readonly String s;
        public TextCreate(String s)
        {
            this.s = s;
        }

        //public static async Task ExampleAsync()
        //{
        //    using(StreamWriter file = new StreamWriter("WriteLines2.txt", append: true))
        //    await file.WriteLineAsync("Fourth line");
        //}

        public void CreateFile()
        {
            //File and path you want to create and write to
            string fileName = @"C:\Users\USER\Documents\Temp.txt";
            //Check if the file exists
            if (!File.Exists(fileName))
            {
                // Create the file and use streamWriter to write text to it.
                //If the file existence is not check, this will overwrite said file.
                //Use the using block so the file can close and vairable disposed correctly
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(s);
                }
            }
        }

        
    }
}
