// <copyright file="WeekendNotifierTest.cs">Copyright ©  2018</copyright>
using System;
using ConsoleApp2;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    /// <summary>This class contains parameterized unit tests for WeekendNotifier</summary>
    [PexClass(typeof(WeekendNotifier))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class WeekendNotifierTest
    {
        /// <summary>Test stub for IsWeekendNear()</summary>
        [PexMethod]
        public bool IsWeekendNearTest([PexAssumeUnderTest]WeekendNotifier target)
        {
            bool result = target.IsWeekendNear();
            return result;
            // TODO: add assertions to method WeekendNotifierTest.IsWeekendNearTest(WeekendNotifier)
        }
    }
}
