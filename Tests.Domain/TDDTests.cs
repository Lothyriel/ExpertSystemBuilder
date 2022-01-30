using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using RuleEngine.Domain;
using RuleEngine.Domain.ValueTypes;

namespace Tests.Domain
{
    public class TDDTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldResultSimpleRule()
        {
            var variable = new NumericValue(50);
            var operatorType = OperatorType.Equals;
            var targetValue = new NumericValue(50);
            var result = new Objective("you should get some rest it's already 7:12 AM");

            var rules = new List<Rule>
            {
                new Rule<double>(variable, operatorType, targetValue, result),
            };

            var variables = new List<Value>
            {
                variable,
            };

            var es = new ExpertSystem(variables, rules);

            es.Result().Should().Be(result);
        }
    }
}