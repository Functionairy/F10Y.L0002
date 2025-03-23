using System;

using F10Y.L0003;
using F10Y.T0002;


namespace F10Y.L0002
{
    [FunctionsMarker]
    public partial interface IExpectationOperator
    {
        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            IEqualityComparer<TOutput> outputEqualityComparer)
        {
            var expectation = new Expectation<TInput, TOutput>
            {
                Input = input,
                Output = output,
                OutputEqualityComparer = outputEqualityComparer,
            };

            return expectation;
        }

        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
            => this.From(
                input,
                output,
                FrameworkEqualityComparerBased_EqualityComparer<TOutput>.Default);
    }
}
