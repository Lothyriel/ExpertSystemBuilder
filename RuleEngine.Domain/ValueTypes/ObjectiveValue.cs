namespace RuleEngine.Domain.ValueTypes
{
    public class ObjectiveValue : Value<string?>
    {
        public override string? CurrentValue { get; set; }
        private HashSet<string?> PossibleValues { get; }

        public ObjectiveValue(string? actualValue, HashSet<string?> possibleValues)
        {
            CurrentValue = actualValue;
            PossibleValues = possibleValues;
        }

        protected override bool Evaluate(OperatorType operatorTypeValue, Value<string?> value)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(Value<string?> v2)
        {
            throw new NotImplementedException();
        }

        public override bool NotEquals(Value<string?> v2)
        {
            throw new NotImplementedException();
        }
    }
}