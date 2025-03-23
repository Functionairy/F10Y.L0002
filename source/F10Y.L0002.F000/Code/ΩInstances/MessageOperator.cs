using System;


namespace F10Y.L0002.F000
{
    public class MessageOperator : IMessageOperator
    {
        #region Infrastructure

        public static IMessageOperator Instance { get; } = new MessageOperator();


        private MessageOperator()
        {
        }

        #endregion
    }
}
