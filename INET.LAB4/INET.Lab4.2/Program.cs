using System;
using SOLID.OCP;
using SOLID.OCP.Violation;

namespace ToImport
{
    static class Program
    {
        static void Main()
        {
            var factory = new DeviceFactory();
            var port = factory.GetDevice(DeviceModel.BillDispenserEcdm).FindPort();
            Console.WriteLine(DeviceFinder.Find(port));
        }
    }
}