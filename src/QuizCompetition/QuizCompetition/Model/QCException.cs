using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class QCException : ApplicationException
    {

        public QCException(string msg) : base(msg) { }

        public QCException() { }

        public QCException(string message, Exception inner)
        : base(message, inner) { }

    }
}
