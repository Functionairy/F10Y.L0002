using System;


namespace F10Y.L0002
{
    public static class Instances
    {
        public static IAssertion Assertion => L0002.Assertion.Instance;
        public static L0003.IEqualityComparerOperator EqualityComparerOperator => L0003.EqualityComparerOperator.Instance;
        public static L0000.IFunctionOperator FunctionOperator => L0000.FunctionOperator.Instance;
    }
}