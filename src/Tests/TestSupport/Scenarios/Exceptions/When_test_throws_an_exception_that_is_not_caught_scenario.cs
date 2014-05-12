using System;

namespace Kekiri.TestSupport.Scenarios.Exceptions
{
    public class When_test_throws_an_exception_that_is_not_caught_scenario : ScenarioTest
    {
        [When, Throws]
        public void When()
        {
            throw new ApplicationException();
        }

        [Then]
        public void Then()
        {
        }
    }
}