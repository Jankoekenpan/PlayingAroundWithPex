// <copyright file="InterfaceConsumerTest.cs">Copyright ©  2018</copyright>
using System;
using Microsoft.Pex.Framework;
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
        /// <summary>Test stub for DoSomethingWithMyInterface(MyInterface)</summary>
        [PexMethod]
        public string DoSomethingWithMyInterfaceTest(
            [PexAssumeUnderTest]InterfaceConsumer target,
            MockMe zieJeWel
        )
        {
            //PexAssume.IsNotNull(zieJeWel);
            string result = target.DoSomethingWithMyInterface(zieJeWel);
            return result;
            // TODO: add assertions to method InterfaceConsumerTest.DoSomethingWithMyInterfaceTest(InterfaceConsumer, MyInterface)
        }

    
    }
}

