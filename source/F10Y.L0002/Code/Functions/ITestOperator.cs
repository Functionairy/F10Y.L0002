using System;

using F10Y.T0002;


namespace F10Y.L0002
{
    [FunctionsMarker]
    public partial interface ITestOperator
    {
        public void Test_Function<TInput, TOutput>(
            Func<TInput, TOutput> function,
            IExpectation<TInput, TOutput> expectation)
        {
            var actual = Instances.FunctionOperator.Run(
                expectation.Input,
                function);

            Instances.Assertion.Are_Equal(
                expectation,
                actual);
        }
    }
}
