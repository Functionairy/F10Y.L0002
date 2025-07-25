using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;

using Expectations = F10Y.L0002.T000;


namespace F10Y.L0002
{
    [FunctionsMarker]
    public partial interface ITestOperator
    {
        public void Test_Function<TInput, TOutput>(
            Func<TInput, TOutput> function,
            params Expectations.IExpectation<TInput, TOutput>[] expectations)
            => this.Test_Function(
                function,
                expectations.AsEnumerable());

        public void Test_Function<TInput, TOutput>(
            Func<TInput, TOutput> function,
            IEnumerable<Expectations.IExpectation<TInput, TOutput>> expectations)
        {
            foreach (var expectation in expectations)
            {
                var actual = Instances.FunctionOperator.Run(
                    expectation.Input,
                    function);

                Instances.Assertion.Are_Equal(
                    expectation,
                    actual);
            }   
        }

        public void Run<TInput, TOutput>(Expectations.IFunctionTest_Synchronous<TInput, TOutput> test)
        {
            var actual = Instances.FunctionOperator.Run(
                test.Input,
                test.Function);

            Instances.Assertion.Are_Equal(
                test,
                actual);
        }
    }
}
