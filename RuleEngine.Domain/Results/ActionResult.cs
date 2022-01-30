namespace RuleEngine.Domain
{
    public class ActionResult : Result
    {
        public ActionResult(Value variable, Value newValue)
        {
            Variable = variable;
            NewValue = newValue;
        }

        public Value Variable { get; }
        public Value NewValue { get; }

        public override string ToString()
        {
            return $"{nameof(Variable)}: {Variable} | {nameof(NewValue)}: {NewValue}";
        }
    }
}
