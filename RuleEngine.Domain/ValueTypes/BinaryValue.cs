namespace RuleEngine.Domain.ValueTypes
{
    public class BinaryValue : Value<bool?>
    {
        public override string Name { get; }
        public override bool? CurrentValue { get; set; }
        public override VariableType Type => VariableType.Binary;

        public BinaryValue(string name, bool? currentValue)
        {
            Name = name;
            CurrentValue = currentValue;
        }

        public override bool Equals(Value<bool?> v2)
        {
            throw new NotImplementedException();
        }

        public override bool NotEquals(Value<bool?> v2)
        {
            throw new NotImplementedException();
        }

        protected override bool Evaluate(OperatorType operatorTypeValue, Value<bool?> value)
        {
            throw new NotImplementedException();
        }
    }
}
