using RuleEngine.Domain.ValueTypes;

namespace RuleEngine.Domain
{
    public abstract class Value
    {
        public abstract string Name { get; }

        public abstract VariableType Type { get; }

        public static Value? CreateValue(VariableType type, string name, string value, HashSet<string> objectiveValues)
        {
            if (name == "")
                return null;

            if (!Valid(type, value, objectiveValues))
                return null;

            if (type == VariableType.Objective && !objectiveValues.TryGetValue(name, out _))
                return null;

            return type switch
            {
                VariableType.Binary => new BinaryValue(name, value == "" ? null : bool.Parse(value)),
                VariableType.Objective => new ObjectiveValue(name, value, objectiveValues!),
                VariableType.Numeric => new NumericValue(name, value == "" ? null : double.Parse(value)),
                _ => throw new EnumException(type),
            };
        }

        private static bool Valid(VariableType type, string value, HashSet<string> objectiveValues)
        {
            return type switch
            {
                VariableType.Binary => bool.TryParse(value, out _),
                VariableType.Objective => objectiveValues.TryGetValue(value, out _),
                VariableType.Numeric => double.TryParse(value, out _),
                _ => throw new EnumException(type),
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
        public override string ToString()
        {
            return $"{Name}: {CurrentValue}";
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