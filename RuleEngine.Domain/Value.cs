using RuleEngine.Domain.ValueTypes;

namespace RuleEngine.Domain
{
    public abstract class Value
    {
        public static Value? CreateValue(VariableType type, string text, HashSet<string>? objectiveValues = null)
        {
            return type switch
            {
                VariableType.Binary => new BinaryValue(text == "" ? null : bool.Parse(text)),
                VariableType.Objective => new ObjectiveValue(text, objectiveValues!),
                VariableType.Numeric => new NumericValue(text == "" ? null : double.Parse(text)),
                _ => throw new Exception("Erro muito fatal este Enum nem existe")
            };
        }
    }

    public abstract class Value<T> : Value
    {
        public abstract T? CurrentValue { get; set; }
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
    public enum VariableType
    {
        Binary,
        Objective,
        Numeric,
    }
}