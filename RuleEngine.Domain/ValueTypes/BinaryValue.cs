namespace RuleEngine.Domain.ValueTypes
{
    public class BinaryValue : Value<bool>
    {
        public override bool CurrentValue { get; set; }

        public BinaryValue(bool currentValue)
        {
            CurrentValue = currentValue;
        }

        public override bool Equals(Value<bool> v2)
        {
            throw new NotImplementedException();
        }

        public override bool NotEquals(Value<bool> v2)
        {
            throw new NotImplementedException();
        }

        protected override bool Evaluate(OperatorType operatorTypeValue, Value<bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
