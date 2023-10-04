using CS.Cargille.Interfaces;
using System.Threading;

namespace CS.Cargille.Core
{
    public class ContainerVirtualMachine : VirtualMachine
    {
        private string ContainerEngine;

        public ContainerVirtualMachine(string id, int ramSize, string os, string url, string engine): base(id, ramSize, os, url)
        {
            ContainerEngine = engine;
        }

        
        public override void StartVM(ILogger logger)
        {          
            Thread.Sleep(5000);
        }


    }
}
