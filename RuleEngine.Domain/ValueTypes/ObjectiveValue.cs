namespace RuleEngine.Domain.ValueTypes
{
    public class ObjectiveValue : Value<string?>
    {
        public override string Name { get; }
        public override string? CurrentValue { get; set; }
        public HashSet<string> PossibleValues { get; }
        public override VariableType Type => VariableType.Objective;


        public ObjectiveValue(string name, string? actualValue, HashSet<string> possibleValues)
        {
            Name = name;
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