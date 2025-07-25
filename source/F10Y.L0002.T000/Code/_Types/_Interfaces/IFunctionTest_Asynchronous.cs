using System;
using System.Threading.Tasks;

using F10Y.L0003;
using F10Y.T0004;


namespace F10Y.L0002.T000
{
    /// <summary>
    /// Represents a test tying together a function, an input, an expected output, and the means to equate encounted output instances against the expected output instance.
    /// This means is provided by a simplified equality comparer instance (<see cref="IEqualityComparer{T}"/>).
    /// A test provides all the information required to run and verify an operation transforming a <typeparamref name="TInput"/> into a <typeparamref name="TOutput"/>.
    /// </summary>
    [DataTypeMarker, UtilityTypeMarker]
    public interface IFunctionTest_Asynchronous<TInput, TOutput> :
        IExpectation<TInput, TOutput>
    {
        public Func<TInput, Task<TOutput>> Function { get; set; }
    }
}
