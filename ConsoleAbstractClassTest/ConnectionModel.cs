using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAbstractClassTest
{
    public class ConnectionModel : Base.ConnectionModel
    {
        public override string ConnectionString()
        {
            return $"Connection string";
        }

        public override string ConnectionStatus()
        {
            return $"ConnectionStatus";
        }
    }
}
