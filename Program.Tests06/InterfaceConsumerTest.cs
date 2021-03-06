// <copyright file="InterfaceConsumerTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Using;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for InterfaceConsumer</summary>
    [PexClass(typeof(InterfaceConsumer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class InterfaceConsumerTest
    {
        /// <summary>Test stub for DoSomethingWithMyInterface(MockMe)</summary>
        [PexMethod]
        [PexUseType(typeof(ImplOne))]
        [PexUseType(typeof(ImplTwo))]
        public string DoSomethingWithMyInterfaceTest([PexAssumeUnderTest]InterfaceConsumer target, MockMe mockMe)
        {
            string result = target.DoSomethingWithMyInterface(mockMe);
            return result;
        }
    }

    public class ImplOne : MockMe
    {
        public int GetInteger()
        {
            return 0;
        }

        public string GetString()
        {
            return "Foo";
        }
    }

    public class ImplTwo : MockMe
    {
        public int GetInteger()
        {
            return 1;
        }

        public string GetString()
        {
            return "Bar";
        }
    }
}
