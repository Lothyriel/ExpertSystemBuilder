namespace RuleEngine.Domain
{
    public class Objective : Result
    {
        public Objective(string message)
        {
            Message = message;
        }

        public string Message { get; }

        public override string ToString()
        {
            return Message;
        }
    }
}