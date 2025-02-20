// <copyright file="ServiceTest.cs" company="Gardiner Family">Copyright © Gardiner Family 2009</copyright>
using System;
using Castle.MicroKernel;
using CastleExperiments;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CastleExperiments
{
    /// <summary>This class contains parameterized unit tests for Service</summary>
    [PexClass(typeof(Service))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ServiceTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Service Constructor()
        {
            // TODO: add assertions to method ServiceTest.Constructor()
            Service target = new Service();
            return target;
        }

        /// <summary>Test stub for .ctor(String, IKernel)</summary>
        [PexMethod]
        public Service Constructor01(string hooHaa, IKernel kernel)
        {
            // TODO: add assertions to method ServiceTest.Constructor01(String, IKernel)
            Service target = new Service(hooHaa, kernel);
            return target;
        }

        /// <summary>Test stub for Thingy(String)</summary>
        [PexMethod]
        public void Thingy([PexAssumeUnderTest]Service target, string name)
        {
            // TODO: add assertions to method ServiceTest.Thingy(Service, String)
            target.Thingy(name);
        }
    }
}
