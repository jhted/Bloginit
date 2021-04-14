using System;
using System.Runtime.Serialization;

namespace MyFirstForm.Controllers
{
    [Serializable]
    internal class ex : Exception
    {
        public ex()
        {
        }

        public ex(string message) : base(message)
        {
        }

        public ex(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ex(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}