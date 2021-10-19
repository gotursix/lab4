using System;
using System.Collections.Generic;

namespace SOLID.OCP
{
    public enum BankTerminalModel
    {
        Brp,
        Dcp
    }

    public interface IBankTerminal
    {
    }

    public class BankTerminalFactory
    {
        private Dictionary<BankTerminalModel, IBankTerminal> _payments = new ();

        public BankTerminalFactory()
        {
            _payments.Add(BankTerminalModel.Brp,new BrpTerminal());
            _payments.Add(BankTerminalModel.Dcp,new DcpTerminal());
        }
        
        
        public IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            return _payments[model];
        }
    }

    public class BrpTerminal : IBankTerminal
    {
    }

    public class DcpTerminal : IBankTerminal
    {
    }
}