using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ConsoleApp2.Tests
{
    public partial class MyClassTest
    {

[TestMethod]
[PexGeneratedBy(typeof(MyClassTest))]
public void MyMethodTest415()
{
    bool b;
    MyClass s0 = new MyClass();
    b = this.MyMethodTest(s0, true, false, false);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}
    }
}
