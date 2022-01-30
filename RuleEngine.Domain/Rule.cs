namespace RuleEngine.Domain
{
    public abstract class Rule
    {
        public abstract bool? IsMet();
        public abstract Result Result { get; }
        public Value? Variable { get; }

        protected Rule(Value? variable)
        {
            Variable = variable;
        }
    }
    public class Rule<T> : Rule where T : struct
    {
        public Rule(Value<T> variable, OperatorType operatorType, Value<T> targetValue, Objective result) : base(variable)
        {
            Variable = variable;
            Operator = operatorType;
            TargetValue = targetValue;
            Result = result;
        }

        public new Value<T>? Variable { get; }

        public OperatorType Operator { get; }

        public Value<T> TargetValue { get; }

        public override Objective Result { get; }

        public override bool? IsMet() 
        {
            return Variable?.EvaluateDefault(Operator, TargetValue);
        }

        public override string ToString()
        {
            return $"{nameof(Variable)}: {Variable} | {nameof(Operator)}: {Operator} | {nameof(TargetValue)}: {TargetValue} = {nameof(Result)}: {Result}";
        }
    }
}