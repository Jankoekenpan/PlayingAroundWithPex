// <copyright file="BarTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for Bar</summary>
    [PexClass(typeof(Bar))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BarTest
    {
        /// <summary>Test stub for Foo(Foo, Boolean, Boolean)</summary>
        [PexMethod]
        public string FooTest(
            [PexAssumeUnderTest]Bar target,
            Foo iksDee,
            bool b,
            bool c
        )
        {
            PexAssume.IsNotNull(iksDee);
            string result = target.Foo(iksDee, b, c);
            PexAssume.IsNotNull(target);

            int i = PexChoose.Value<int>("i");
            PexObserve.ValueForViewing<int>("yo_add_this_thing", i);
            PexObserve.Value<string>("Hello, World!", "Foo");

            string helloWorld = PexChoose.Value<string>("Hello, World!");
            Console.WriteLine(helloWorld);

            return result;
            // TODO: add assertions to method BarTest.FooTest(Bar, Foo, Boolean, Boolean)
        }
    }
}
