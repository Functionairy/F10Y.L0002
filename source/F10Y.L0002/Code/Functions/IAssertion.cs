using System;

using F10Y.T0002;
using F10Y.T0011;

using Expectations = F10Y.L0002.T000;
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
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Implementations.IAssertion _Implementations => Implementations.Assertion.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public void Are_Equal<TOutput>(
            Expectations.IExpectationOutput<TOutput> expectation,
            TOutput encounteredValue)
        {
            this.Are_Equal(
                expectation.Output_Expected,
                encounteredValue,
                expectation.Output_EqualityComparer);
        }

        /// <summary>
        /// Determines if two instances are equal using the provided simplified equality comparer.
        /// </summary>
        public void Are_Equal<T>(
            T expected,
            T actual,
            Simplified.IEqualityComparer<T> equalityComparer)
            => _Implementations.Are_Equal_ReimplementException(
                expected,
                actual,
                equalityComparer);
    }
}
