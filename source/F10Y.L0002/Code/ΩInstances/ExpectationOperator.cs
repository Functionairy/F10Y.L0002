using System;


namespace F10Y.L0002
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
