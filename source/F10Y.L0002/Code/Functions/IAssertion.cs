using System;

using F10Y.T0002;

using Framework = System.Collections.Generic;
using Simplified = F10Y.L0003;


namespace F10Y.L0002
{
    /// <summary>
    /// Operator for <see cref="Microsoft.VisualStudio.TestTools.UnitTesting.Assert"/> functionality.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="F000.Documentation.AssertionOperatorNonStandardName" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IAssertion :
        F000.IAssertion
    {
        public void Are_Equal<TOutput>(
            IExpectationOutput<TOutput> expectedValue,
            TOutput encounteredValue,
            Framework.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue.Output,
                encounteredValue,
                equalityComparer);
        }

        public void Are_Equal<TOutput>(
            IExpectationOutput<TOutput> expectedValue,
            TOutput encounteredValue)
        {
            this.Are_Equal(
                expectedValue.Output,
                encounteredValue);
        }

        public void Are_Equal<T>(
            T expected,
            T actual,
            Simplified.IEqualityComparer<T> equalityComparer)
        {
            var equalityComparer_Framework = Instances.EqualityComparerOperator.From(equalityComparer);

            this.Are_Equal(
                expected,
                actual,
                equalityComparer_Framework);
        }

        public void Are_Equal<TOutput>(
            IExpectationOutput<TOutput> expectedValue,
            TOutput encounteredValue,
            Simplified.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue.Output,
                encounteredValue,
                equalityComparer);
        }
    }
}
