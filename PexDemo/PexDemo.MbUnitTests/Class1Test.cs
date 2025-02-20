// <copyright file="Class1Test.cs" company="Gardiner Family">Copyright © Gardiner Family 2009</copyright>
using System;
using MbUnit.Framework;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using PexDemo;

namespace PexDemo
{
    /// <summary>This class contains parameterized unit tests for Class1</summary>
    [TestFixture]
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class Class1Test
    {
        /// <summary>Test stub for PascalCase(String)</summary>
        [PexMethod]
        public string PascalCase([PexAssumeUnderTest]Class1 target, string value)
        {
            // TODO: add assertions to method Class1Test.PascalCase(Class1, String)
            string result = target.PascalCase(value);
            return result;
        }

        [PexMethod]
        public void AnotherTest()
        {
            
            var c = new Class1();
            
            const string TEST_NAME = "david gardiner";
            var result = c.PascalCase(TEST_NAME);

            Assert.AreEqual(TEST_NAME.Length - 1, result.Length);
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public void Null_Argument()
        {
            var c = new Class1();

            c.PascalCase(null);
        }
        
    }
}
