using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using F10Y.T0002;


namespace F10Y.L0002.F000
{
    [FunctionsMarker]
    public partial interface IExceptionOperator
    {
        /// <summary>
        /// Gets an exception configured to be the same as returned by the <see cref="Assert.AreEqual{T}(T, T)"/> method.
        /// </summary>
        /// <exception cref="AssertFailedException"/>
        public AssertFailedException Get_AreEqual_AssertFailedException<T>(
            T expected,
            T actual)
        {
            var message = Instances.MessageOperator.Get_AreEqual_FailedExceptionMessage(
                expected,
                actual);

            var output = new AssertFailedException(message);
            return output;
        }
    }
}
