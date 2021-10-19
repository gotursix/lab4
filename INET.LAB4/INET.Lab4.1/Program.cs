using SOLID.OCP;

namespace INET.Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new BankTerminalFactory();
            var instance = factory.CreateBankTerminal(BankTerminalModel.Brp);
        }
    }
}