using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using F10Y.T0002;


namespace F10Y.L0002.F000
{
    /// <summary>
    /// Operator for <see cref="Assert"/> functionality.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.AssertionOperatorNonStandardName" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IAssertion
    {
        /// <summary>
        /// Calls <method><see cref="Assert.AreEqual{T}(T, T, IEqualityComparer{T})"/></method>.
        /// </summary>
        /// <inheritdoc cref="Assert.AreEqual{T}(T, T, IEqualityComparer{T})" path="/exception"/>
        public void Are_Equal<T>(
            T expected,
            T actual,
            IEqualityComparer<T> equalityComparer)
        {
            Assert.AreEqual(
                expected,
                actual,
                equalityComparer);
        }

        public void Are_Equal<T>(
            T expected,
            T actual)
        {
            Assert.AreEqual(
                expected,
                actual);
        }

        public void Are_Equal_ForArray<T>(
            T[] expected,
            T[] actual,
            IComparer comparer)
        {
            CollectionAssert.AreEqual(
                expected,
                actual,
                comparer);
        }

        public void Are_Equal_ForArray<T>(
            T[] expected,
            T[] actual)
        {
            CollectionAssert.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// Allows explicitly stating that an action should not thrown an exception.
        /// With MSTest, if code throws an exception the test will fail. However, relying on this behavior means that test code will lack an assertion,
        /// which makes these tests look different from all other tests.
        /// This method allows a conforming assertion to be made in the case of testing for no exceptions.
        /// </summary>
        /// <remarks>
        /// From: https://stackoverflow.com/a/9417242
        /// </remarks>
        public void DoesNotThrowException_Synchronous(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                Assert.Fail($"Expected no exception, found:\n{exception}");
            }
        }

        /// <inheritdoc cref="DoesNotThrowException_Synchronous(Action)"/>
        public async Task DoesNotThrowException_Asynchronous(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception exception)
            {
                Assert.Fail($"Expected no exception, found:\n{exception}");
            }
        }

        /// <summary>
        /// Chooses <see cref="DoesNotThrowException_Synchronous(Action)"/> as the default.
        /// </summary>
        public void DoesNotThrowException(Action action)
        {
            this.DoesNotThrowException_Synchronous(action);
        }

        public void Is_Null(object value)
        {
            Assert.IsNull(value);
        }

        public void ThrowsExactException_Synchronous<TException>(Action action)
            where TException : Exception
        {
            Assert.ThrowsExactly<TException>(action);
        }

        public void ThrowsException_Synchronous<TException>(
            Action action,
            string expectedMessageOfException)
            where TException : Exception
        {
            var exceptionWasThrown = false;
            var exceptionMessageWasAsExpected = false;

            try
            {
                action();
            }
            catch (TException ex)
            {
                exceptionWasThrown = true;

                exceptionMessageWasAsExpected = ex.Message == expectedMessageOfException;
            }

            if (!exceptionWasThrown)
            {
                Assert.Fail($"Expected an exception, but no exception occurred.");
            }

            if (!exceptionMessageWasAsExpected)
            {
                Assert.Fail($"Exception message was not as expected.\nExpected:{expectedMessageOfException}");
            }
        }

        public async Task ThrowsException_Asynchronous(Func<Task> action)
        {
            var exceptionWasThrown = false;
            try
            {
                await action();
            }
            catch
            {
                exceptionWasThrown = true;
            }

            if (!exceptionWasThrown)
            {
                Assert.Fail($"Expected an exception, but no exception occurred.");
            }
        }

        public async Task ThrowsExactException_Asynchronous<TException>(
            Func<Task> action)
            where TException : Exception
        {
            await Assert.ThrowsExactlyAsync<TException>(action);
        }

        /// <summary>
        /// Chooses <see cref="ThrowsExactException_Synchronous{TException}(Action)"/> as the default.
        /// </summary>
        public void ThrowsException<TException>(Action action)
            where TException : Exception
        {
            this.ThrowsExactException_Synchronous<TException>(action);
        }

        /// <summary>
        /// Chooses <see cref="ThrowsException_Synchronous{TException}(Action, string)"/> as the default.
        /// </summary>
        public void ThrowsException<TException>(
            Action action,
            string expectedMessageOfException)
            where TException : Exception
        {
            this.ThrowsException_Synchronous<TException>(
                action,
                expectedMessageOfException);
        }
    }
}
