namespace RuleEngine.Domain
{
    public class ExpertSystem
    {
        public ExpertSystem(List<Value> variables, List<Rule> rules)
        {
            Rules = rules.ToDictionary(rule => rule, rule => false);
            Variables = variables;
        }
        private List<Value> Variables { get; }

        private Dictionary<Rule, bool> Rules { get; }

        public Conclusion Result()
        {
            var rules = NotMetRules();

            while (rules.Any())
            {
                foreach (var rule in rules)
                {
                    if (rule.IsMet() == true)
                    {
                        Rules[rule] = true;
                        if (rule.Result is IActionResult action)
                            action.Act();
                        else if (rule.Result is Conclusion obj)
                            return obj;
                    }
                }
                rules = NotMetRules();
            }

            throw new Exception("The system couldn't resolve this problem!");
        }

        private IEnumerable<Rule> NotMetRules() => Rules.Keys.Where(r => Rules[r] == false);
    }
}