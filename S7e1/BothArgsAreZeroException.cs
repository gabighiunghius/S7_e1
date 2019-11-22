using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7e1
{
    public class BothArgsAreZeroException : Exception
    {
        public BothArgsAreZeroException() { }
        public BothArgsAreZeroException(string message) : base(message) { }
        public BothArgsAreZeroException(string message, Exception inner) : base(message, inner) { }
        protected BothArgsAreZeroException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
