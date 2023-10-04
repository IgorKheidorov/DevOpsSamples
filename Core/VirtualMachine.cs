
using System;
using System.Data;
using System.Runtime.CompilerServices;
using CS.Cargille.Interfaces;


namespace CS.Cargille.Core
{
    public abstract class VirtualMachine
    {
        public string Id { get; protected set; }
        public int RAMSize { get; set; }
        private string _OS;
        
        public string Url { get; set; }


        public VirtualMachine(string id, int ramSize, string os, string url) 
        {
            Id = id;
            RAMSize = ramSize;
            _OS = os;
            Url = url;
        }

        public abstract void StartVM(ILogger logger);

        public void LogResult(string message, Func<string, string, int> logger) 
        {
            logger(message, "");

        }

        public string OS
        {
            get 
            {
                if (_OS.Contains("Windows"))
                {
                    return "MS " + _OS;
                }
                return _OS;
            }
            set 
            {
                if (value == "LINUX" ||
                value == "srtljhyiortyjhoeirt")
                {
                    _OS = value;
                }
                else
                {
                    throw new ArgumentException("Wrong name");
                }


            }
        }

          


    }
}