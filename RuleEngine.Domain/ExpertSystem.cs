namespace RuleEngine.Domain
{
    public class ExpertSystem
    {
        public ExpertSystem(List<Value> variables, List<Rule> rules)
        {
            Rules = rules.ToDictionary(rule => rule, rule => false);
            Variables = variables;
        }
        public List<Value> Variables { get; }

        public Dictionary<Rule, bool> Rules { get; }

        public Objective Result(List<Rule>? rules = null)
        {
            rules ??= Rules.Keys.ToList();

            foreach (var rule in rules)
            {
                var result = rule.IsMet();
                if (result == null)
                {
                    rules = DeriveRules(rule);
                    return Result();
                }
                if (result == true)
                {
                    Rules[rule] = true;
                }
                if (rule.Result is Objective obj)
                    return obj;
            }
            throw new Exception("The system couldn't resolve this problem!");
        }

        private List<Rule> DeriveRules(Rule testedRule)
        {
            var rules = Rules.Keys.Where(r =>
            Rules[r] == false &&
            r.Result is ActionResult &&
            testedRule.Variable != null &&
            r.Variable == testedRule.Variable);

            return rules.ToList();
        }
    }
}