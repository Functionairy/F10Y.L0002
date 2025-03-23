using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using F10Y.T0002;


namespace F10Y.L0002.F000
{
    [FunctionsMarker]
    public partial interface IExceptionOperator
    {
        public AssertFailedException Get_AreEqual_AssertFailedException<T>(
            T expected,
            T actual)
        {
            var message = Instances.MessageOperator.Get_AreEqual_FailedMessage(
                expected,
                actual);

            var output = new AssertFailedException(message);
            return output;
        }
    }
}
