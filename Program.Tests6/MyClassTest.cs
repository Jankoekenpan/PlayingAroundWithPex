// <copyright file="MyClassTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for MyClass</summary>
    [PexClass(typeof(MyClass))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MyClassTest
    {
        /// <summary>Test stub for MyMethod(Boolean, Boolean, Boolean)</summary>
        [PexMethod]
        public bool MyMethodTest(
            [PexAssumeUnderTest]MyClass target,
            bool p,
            bool q,
            bool r
        )
        {
            PexAssume.IsTrue(p);
            bool result = target.MyMethod(p, q, r);
            PexAssert.AreEqual(q, result);
            return result;
        }
    }
}
