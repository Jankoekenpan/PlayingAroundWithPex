// <copyright file="TriangleTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for Triangle</summary>
    [PexClass(typeof(Triangle))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TriangleTest
    {
        /// <summary>Test stub for .ctor(Int32, Int32, Int32)</summary>
        [PexMethod]
        public Triangle ConstructorTest(
            int x,
            int y,
            int z
        )
        {
            Triangle target = new Triangle(x, y, z);
            return target;
            // TODO: add assertions to method TriangleTest.ConstructorTest(Int32, Int32, Int32)
        }

        /// <summary>Test stub for getTriangleType()</summary>
        [PexMethod]
        public TriangleType getTriangleTypeTest([PexAssumeUnderTest]Triangle target)
        {
            TriangleType result = target.getTriangleType();
            return result;
            // TODO: add assertions to method TriangleTest.getTriangleTypeTest(Triangle)
        }
    }
}
