// <copyright file="SomethingTest.cs" company="Gardiner Family">Copyright © Gardiner Family 2009</copyright>
using System;
using CastleExperiments;
using MbUnit.Framework;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace CastleExperiments
{
    /// <summary>This class contains parameterized unit tests for Something</summary>
    [TestFixture]
    [PexClass(typeof(Something))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class SomethingTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Something Constructor(string name)
        {
            // TODO: add assertions to method SomethingTest.Constructor(String)
            Something target = new Something(name);
            return target;
        }

        /// <summary>Test stub for Hey()</summary>
        [PexMethod]
        public string Hey([PexAssumeUnderTest]Something target)
        {
            // TODO: add assertions to method SomethingTest.Hey(Something)
            string result = target.Hey();
            return result;
        }
    }
}
