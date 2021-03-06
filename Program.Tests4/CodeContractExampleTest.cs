// <copyright file="CodeContractExampleTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for CodeContractExample</summary>
    [PexClass(typeof(CodeContractExample))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CodeContractExampleTest
    {
        /// <summary>Test stub for divide(Int32, Int32)</summary>
        [PexMethod]
        public int divideTest(
            [PexAssumeUnderTest]CodeContractExample target,
            int teller,
            int noemer
        )
        {
            int result = target.divide(teller, noemer);
            return result;
            // TODO: add assertions to method CodeContractExampleTest.divideTest(CodeContractExample, Int32, Int32)
        }
    }
}
