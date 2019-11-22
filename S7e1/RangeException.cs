using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7e1
{
    [Serializable]
    public class RangeException : Exception
    {
        public RangeException() 
        {
        
        }

        public RangeException(string message) : base(message) { }

        public RangeException(string message, Exception inner) : base(message, inner) { }

        protected RangeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
