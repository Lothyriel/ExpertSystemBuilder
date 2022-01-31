namespace RuleEngine.Domain
{
    public class ActionResult<T> : Result, IActionResult
    {
        public ActionResult(Value<T> variable, Value<T> newValue)
        {
            Variable = variable;
            NewValue = newValue;
        }

        public Value<T> Variable { get; set; }
        public Value<T> NewValue { get; }

        public void Act() 
        {
            Variable.CurrentValue = NewValue.CurrentValue;
        }

        public override string ToString()
        {
            return $"{nameof(Variable)}: {Variable} | {nameof(NewValue)}: {NewValue}";
        }
    }
}
