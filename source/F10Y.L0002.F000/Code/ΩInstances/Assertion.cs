using System;


namespace F10Y.L0002.F000
{
    public class Assertion : IAssertion
    {
        #region Infrastructure

        public static IAssertion Instance { get; } = new Assertion();


        private Assertion()
        {
        }

        #endregion
    }
}
