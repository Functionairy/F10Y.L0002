using System;


namespace F10Y.L0002.T000
{
    public class ExpectationOperator : IExpectationOperator
    {
        #region Infrastructure

        public static IExpectationOperator Instance { get; } = new ExpectationOperator();


        private ExpectationOperator()
        {
        }

        #endregion
    }
}
