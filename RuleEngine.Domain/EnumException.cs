using System.Runtime.Serialization;

namespace RuleEngine.Domain
{
    [Serializable]
    internal class EnumException : Exception
    {
        public EnumException()
        {
        }

        public EnumException(VariableType type) : base($"Enum value dont't exist {type}") { }

        public EnumException(string? message) : base(message)
        {
        }

        public EnumException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EnumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}