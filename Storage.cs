using System;
using System.Collections.Generic;
using System.Text;

namespace Hw29
{
    public abstract class Storage
    {
        private string name;
        private string model;

        public double GetMemory(double memory)
        {
            Console.WriteLine($"This is your memory - {memory}");
            return memory;
        }
        public void Copy(double speedOfLoad, double fileSize, double bas, double memory, double time)
        {
            time = fileSize / speedOfLoad;
            bas = fileSize;
            Console.WriteLine($"Done - {bas} is busy on your device.Completed in {time} second");
            memory = (memory * 1024) - bas;
        }
        public void MemoryBusy(double memory, double bas)
        {
            Console.WriteLine($"{(memory * 1024) - bas} free on your device");
        }
        public void GeneralInformation(double memory, string name, string model)
        {
            Console.WriteLine($"{name} of your device");
            Console.WriteLine($"{model} model of your device");
            Console.WriteLine($"{memory} memory on your device");

        }
        public void SizeForThis(double memoryOfFlash, double memoryOfHDD, double memoryOfDVD, double amount)
        {
            double gbOfThing;
            int choice;
            Console.WriteLine("How much memory do you need?(In Gb");
            gbOfThing = double.Parse(Console.ReadLine());
            Console.WriteLine("1 - in Flash, 2 - HDD, 3 - DVD");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    amount = (memoryOfFlash * 1024) / gbOfThing;
                    Console.WriteLine($"{amount}");
                    break;
                case 2:
                    amount = (memoryOfHDD * 1024) / gbOfThing;
                    Console.WriteLine($"{amount}");
                    break;
                case 3:
                    amount = (memoryOfDVD * 1024) / gbOfThing;
                    Console.WriteLine($"{amount}");
                    break;
                default: break;
            }
        }
        public void GeneralMemory(double memoryOfFlash, double memoryOfHDD, double memoryOfDVD, double amountOfFlash, double amountOfHDD, double amountOfDVD)
        {
            double generalMemory;
            generalMemory = (memoryOfFlash * 1024 * amountOfFlash) + (memoryOfHDD * 1024 * amountOfHDD) + (memoryOfDVD * 1024 * amountOfDVD);
            Console.WriteLine($"{generalMemory} - this your memory in all device's");
        }
    }
}
