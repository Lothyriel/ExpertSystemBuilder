namespace RuleEngine.Domain
{
    public abstract class Value
    {
    }

    public abstract class Value<T> : Value
    {
        public abstract T CurrentValue { get; }
        protected abstract bool Evaluate(OperatorType operatorTypeValue, Value<T> value);
        public abstract bool Equals(Value<T> v2);
        public abstract bool NotEquals(Value<T> v2);
        public bool EvaluateDefault(OperatorType operatorTypeValue, Value<T> value)
        {
            return operatorTypeValue switch
            {
                OperatorType.Equals => Equals(value),
                OperatorType.NotEquals => NotEquals(value),
                _ => Evaluate(operatorTypeValue, value),
            };
        }
    }
    public enum OperatorType
    {
        Equals,
        NotEquals,
        Lesser,
        Greater,
        LesserOrEquals,
        GreaterOrEquals
    }
}