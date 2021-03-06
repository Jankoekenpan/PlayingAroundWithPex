// <copyright file="FooTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for Foo</summary>
    [PexClass(typeof(Foo))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FooTest
    {
        /// <summary>Test stub for MyMethod(Boolean, Boolean, Boolean)</summary>
        [PexMethod]
        public bool MyMethodTest(
            [PexAssumeUnderTest]Foo target,
            bool p,
            bool q,
            bool r
        )
        {
            // TODO: add assertions to method FooTest.MyMethodTest(Foo, Boolean, Boolean, Boolean)

            PexAssume.IsTrue(p);

            bool result = target.MyMethod(p, q, r);

            PexAssert.AreEqual(q, result);
            return result;
        }
    }
}
