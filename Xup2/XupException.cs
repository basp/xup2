namespace Xup2
{
    using System;
    using System.Runtime.Serialization;

    public class XupException : System.Exception
    {
        public XupException()
        {
        }

        public XupException(string message)
            : base(message)
        {
        }

        public XupException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected XupException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}