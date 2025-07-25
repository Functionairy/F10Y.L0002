using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using F10Y.T0002;


namespace F10Y.L0002.F000
{
    [FunctionsMarker]
    public partial interface IMessageOperator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Message format discovered using R5T.S0111.V000.Tests.AreEqual_ForIntegers().
        /// </remarks>
        public string Get_AreEqual_FailedExceptionMessage(
            object expected,
            object actual)
        {
            var output = $"{nameof(Assert)}.{nameof(Assert.AreEqual)} failed. Expected:<{expected}>. Actual:<{actual}>.";
            return output;
        }
    }
}
