namespace RuleEngine.Domain.ValueTypes
{
    public class NumericValue : Value<double>
    {
        public override double CurrentValue { get; }

        public NumericValue(double value)
        {
            CurrentValue = value;
        }

        public override bool Equals(Value<double> v2)
        {
            return CurrentValue == v2.CurrentValue;
        }

        public override bool NotEquals(Value<double> v2)
        {
            return CurrentValue != v2.CurrentValue;
        }

        public bool Greater(Value<double> v2)
        {
            return CurrentValue > v2.CurrentValue;
        }

        public bool Lesser(Value<double> v2)
        {
            return CurrentValue < v2.CurrentValue;
        }

        public bool GreaterOrEquals(Value<double> v2)
        {
            return CurrentValue >= v2.CurrentValue;
        }

        public bool LesserOrEquals(Value<double> v2)
        {
            return CurrentValue <= v2.CurrentValue;
        }

        protected override bool Evaluate(OperatorType operatorTypeValue, Value<double> value) 
        {
            return operatorTypeValue switch
            {
                OperatorType.Lesser => Lesser(value),
                OperatorType.Greater => Greater(value),
                OperatorType.LesserOrEquals => LesserOrEquals(value),
                OperatorType.GreaterOrEquals => GreaterOrEquals(value),
                _ => throw new Exception($"Invalid enum value exception {operatorTypeValue}"),
            };
        }

        public override string ToString()
        {
            return $"{CurrentValue}";
        }
    }
}
