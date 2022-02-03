using RuleEngine.Domain;

namespace WindowsForms
{
    public class ESBuilder
    {
        public ESBuilder(List<Rule> rules, List<Value> variables)
        {
            Rules = rules;
            Variables = variables;
        }
        public ESBuilder()
        {
            Rules = new();
            Variables = new();
        }

        public ESBuilder(ExpertSystem system)
        {
            System = system;
            Rules = system.Rules.Keys.ToList();
            Variables = system.Variables;
        }

        public List<Rule> Rules { get; }
        public List<Value> Variables { get; }
        public ExpertSystem? System { get; }

        public ExpertSystem Build() { return new ExpertSystem(Variables, Rules); }
    }
}