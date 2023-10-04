using System;
using CS.Cargille.Interfaces;

namespace CS.Cargille.Logers
{
    public class FileLogger : ILogger
    {

        public string FileName { get; set; }

        public FileLogger(string fileName) 
        {
            FileName = fileName;
        }


        public void Log(string message)
        {
            // 1. Open fileNaME
            // 2. Write info to file
            // 3. close file

            Console.WriteLine("Info is logged to file" + message);
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
