using CS.Cargille.Interfaces;
using System.Threading;


namespace CS.Cargille.Core
{
    public class HyperVVirtualMachine: VirtualMachine
    {
        public string NetWorkType;

        public HyperVVirtualMachine(string id, int ramSize, string os, string ntType):  base(id, ramSize, os, "")
        {
            NetWorkType = ntType;           
        }

        public override void StartVM(ILogger logger)
        {
            Thread.Sleep(5000);
            //logger.Log($"Hello! Hyper VM {Id}+{RAMSize} + {NetWorkType} started");
        }
    }
}
