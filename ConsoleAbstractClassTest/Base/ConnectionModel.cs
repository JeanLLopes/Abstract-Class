using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAbstractClassTest.Base
{
    public abstract class ConnectionModel
    {
        public virtual string ConnectionString()
        {
            return $"Connection abstract string";
        }

        public virtual string ConnectionStatus()
        {
            return $"ConnectionStatus abstract";
        }

        public virtual string ConnectionClose()
        {
            return $"ConnectionClose abstract";
        }
    }
}
