using System;

using F10Y.T0004;


namespace F10Y.L0002
{
    /// <summary>
    /// Represents an expectation tying together an input, an expected output, and the means to equate encounted output instances against the expected output instance.
    /// This means is provided by a simplified equality comparer instance (<see cref="L0003.IEqualityComparer{T}"/>).
    /// An expectation provides all the information required to verify an operation transforming a <typeparamref name="TInput"/> into a <typeparamref name="TOutput"/>.
    /// </summary>
    [DataTypeMarker, UtilityTypeMarker]
    public interface IExpectation<TInput, TOutput> :
        IExpectationOutput<TOutput>
    {
        public TInput Input { get; set; }
    }


    /// <inheritdoc cref="IExpectation{TInput, TOutput}"/>
    [DataTypeMarker, UtilityTypeMarker]
    public interface IExpectation<TInput1, TInput2, TOutput> :
        IExpectationOutput<TOutput>
    {
        public TInput1 Input1 { get; set; }
        public TInput2 Input2 { get; set; }
    }
}