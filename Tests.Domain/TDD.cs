using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using RuleEngine.Domain;
using RuleEngine.Domain.ValueTypes;

namespace Tests.Domain
{
    public class TDD
    {
        [Test]
        public void ShouldConcludeSimpleRule()
        {
            var variable = new NumericValue(50);
            var targetValue = new NumericValue(50);
            var result = new Conclusion("you should get some rest it's already 7:12 AM");

            var rules = new List<Rule>
            {
                new Rule<double>(variable, OperatorType.Equals, targetValue, result)
            };

            var variables = new List<Value>
            {
                variable
            };

            var es = new ExpertSystem(variables, rules);

            es.Result().Should().Be(result);
        }
        [Test]
        public void ShouldActAndResultSimleConclusion()
        {
            var variable = new NumericValue(10);
            var targetValue = new NumericValue(50);
            var action = new ActionResult<double>(variable, targetValue);

            var conclusion = new Conclusion("it's easy when you big in japan");

            var rules = new List<Rule>
            {
                new Rule<double>(variable, OperatorType.Lesser, targetValue, action),
                new Rule<double>(variable, OperatorType.Equals, targetValue, conclusion)
            };

            var variables = new List<Value>
            {
                variable,
            };

            var es = new ExpertSystem(variables, rules);

            es.Result().Should().Be(conclusion);
        }

        [Test]
        public void ShouldDeriveNewRulesAndResultSimleConclusion()
        {
            var variable = new NumericValue(10);
            var targetValue = new NumericValue(50);
            var action = new ActionResult<double>(variable, targetValue);

            var conclusion = new Conclusion("it's easy when you big in japan");

            var rules = new List<Rule>
            {
                new Rule<double>(variable, OperatorType.Equals, targetValue, conclusion),
                new Rule<double>(variable, OperatorType.Lesser, targetValue, action)
            };

            var variables = new List<Value>
            {
                variable,
            };

            var es = new ExpertSystem(variables, rules);

            es.Result().Should().Be(conclusion);
        }

        [Test]
        public void ShouldDeriveAndResultSimleConclusion()
        {
            var targetValue = new NumericValue(50);
            var action = new ActionResult<double>(variable, targetValue);

            var conclusion = new Conclusion("it's easy when you big in japan");

            var rules = new List<Rule>
            {
                new Rule<double>(null, OperatorType.Equals, targetValue, conclusion),
                new Rule<double>(null, OperatorType.Lesser, targetValue, action)
            };

            var variables = new List<Value>
            {
                variable,
            };

            var es = new ExpertSystem(variables, rules);

            es.Result().Should().Be(conclusion);
        }
    }
}