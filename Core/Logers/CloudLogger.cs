using System;
using CS.Cargille.Interfaces;

namespace CS.Cargille.Logers
{
    public class CloudLogger : ILogger, IBackup
    {
        const string AzureURL = "www.azure.cs.com";
        
        public void Log(string message)
        {
            //1. Open connection



            // 5. Save info to cloud
            Console.WriteLine("Save to cloud" + message);            
        }

        public void MakeBackup()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
