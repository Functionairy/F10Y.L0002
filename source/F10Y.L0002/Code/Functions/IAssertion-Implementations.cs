using System;

using F10Y.T0002;

using Simplified = F10Y.L0003;


namespace F10Y.L0002.Implementations
{
    /// <summary>
    /// Operator for <see cref="Microsoft.VisualStudio.TestTools.UnitTesting.Assert"/> functionality.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="F000.Documentation.AssertionOperatorNonStandardName" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IAssertion
    {
#pragma warning disable IDE1006 // Naming Styles

        private static L0002.IAssertion _Base => L0002.Assertion.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="L0002.IAssertion.Are_Equal{T}(T, T, Simplified.IEqualityComparer{T})" path="/summary"/>
        /// <inheritdoc cref="F000.IAssertion.Are_Equal{T}(T, T, System.Collections.Generic.IEqualityComparer{T})" path="/exception"/>
        public void Are_Equal_WrapWithSystemComparer<T>(
            T expected,
            T actual,
            Simplified.IEqualityComparer<T> equalityComparer)
        {
            var equalityComparer_Framework = Instances.EqualityComparerOperator.From(equalityComparer);

            _Base.Are_Equal(
                expected,
                actual,
                equalityComparer_Framework);
        }

        /// <inheritdoc cref="L0002.IAssertion.Are_Equal{T}(T, T, Simplified.IEqualityComparer{T})" path="/summary"/>
        /// <remarks>
        /// A re-implementation of <inheritdoc cref="F000.IAssertion.Are_Equal{T}(T, T, System.Collections.Generic.IEqualityComparer{T})" path="descendant::method"/>
        /// </remarks>
        /// <inheritdoc cref="F000.IExceptionOperator.Get_AreEqual_AssertFailedException{T}(T, T)" path="/exception"/>
        public void Are_Equal_ReimplementException<T>(
            T expected,
            T actual,
            Simplified.IEqualityComparer<T> equalityComparer)
        {
            var areEqual = equalityComparer.Equals(expected, actual);
            if (!areEqual)
            {
                throw Instances.ExceptionOperator.Get_AreEqual_AssertFailedException(
                    expected,
                    actual);
            }
        }
    }
}
