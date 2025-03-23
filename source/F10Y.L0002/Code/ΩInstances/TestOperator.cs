using System;


namespace F10Y.L0002
{
    public class TestOperator : ITestOperator
    {
        #region Infrastructure

        public static ITestOperator Instance { get; } = new TestOperator();


        private TestOperator()
        {
        }

        #endregion
    }
}
