using System;

using F10Y.L0003;
using F10Y.T0004;


namespace F10Y.L0002
{
    /// <inheritdoc cref="IExpectation{TInput, TOutput}"/>
    [DataTypeMarker, UtilityTypeMarker]
    public class Expectation<TInput, TOutput> : IExpectation<TInput, TOutput>
    {
        #region Static

        /// <summary>
        /// <inheritdoc cref="Documentation.ConvenientConversionToInputType"/>
        /// </summary>
        public static implicit operator TInput(Expectation<TInput, TOutput> pair)
        {
            return pair.Input;
        }

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }
        public IEqualityComparer<TOutput> OutputEqualityComparer { get; set; }


        public override string ToString()
        {
            var representation = $"{this.Output}\n- expected from -\n\t{this.Input}";
            return representation;
        }
    }


    /// <inheritdoc cref="Expectation{TInput, TOutput}"/>
    [DataTypeMarker, UtilityTypeMarker]
    public class Expectation<TInput1, TInput2, TOutput> : IExpectation<TInput1, TInput2, TOutput>
    {
        #region Static

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput1 Input1 { get; set; }
        public TInput2 Input2 { get; set; }
        public TOutput Output { get; set; }
        public IEqualityComparer<TOutput> OutputEqualityComparer { get; set; }


        public override string ToString()
        {
            var representation = $"{this.Output}\n- expected from -\n\t{this.Input1}\n\t{this.Input2}";
            return representation;
        }
    }


    /// <summary>
    /// <para>Use <see cref="IExpectationOperator"/> instead.</para>
    /// A static class for expection methods.
    /// Also helps to provide a non-type parametered class for use in documentation comments related to expectations.
    /// </summary>
    [UtilityTypeMarker]
    public static class Expectation
    {
        public static Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            IEqualityComparer<TOutput> outputEqualityComparer)
        {
            var expectation = new Expectation<TInput, TOutput>
            {
                Input = input,
                Output = output,
                OutputEqualityComparer = outputEqualityComparer,
            };

            return expectation;
        }

        public static Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
        {
            // Specify the type parameters to avoid selecting the two-inputs version.
            var expectation = Expectation.From<TInput, TOutput>(
                input,
                output,
                FrameworkEqualityComparerBased_EqualityComparer<TOutput>.Default);

            return expectation;
        }
    }
}
