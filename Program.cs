using CS.Cargille.Logers;
using CS.Cargille.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using CS.Cargille.Core;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CoherentSolutions.Cargille.DevOpsStart
{
    public delegate int Initializer(int data);

    public  class Program
    {
        public static async Task Main(string[] args)
        {
            VirtualMachine vm1 = new HyperVVirtualMachine("1000", 512, "Windows 10", "internal");

            VirtualMachine vm2 = new ContainerVirtualMachine("1001", 512, "Windows 10", "10.10.10.1", "Docker");

            VirtualMachine vm3 = new HyperVVirtualMachine("1002", 256, "Tindows 11", "default");

            System.Collections.Generic.List<VirtualMachine> listVMs = new List<VirtualMachine>();


            listVMs.Add(vm1);
            listVMs.Add(vm2);
            listVMs.Add(vm3);

            string os = vm1.Id;

            vm1.OS = "LINUX";
            vm1.RAMSize = 1234;
            Console.WriteLine("VMS Created");

            var task = () => CalculateData(5,"");
            var taskRun1 = Task.Run(task);            
            var taskRun2 = Task.Run(() => CalculateData(7, "Name2"));

            Task.WaitAll(taskRun2, taskRun1);
        
            Console.ReadKey();
        }

        static  bool CheckCondition(VirtualMachine x) 
        {
            return x.OS == "Windows 10";
        }


        static async Task CalculateData(int count, string name)
        {
            await Task.Run(() =>
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{name}, iteration number: {i}");
                        Thread.Sleep(1000);
                    }
                });
        }



    }
}