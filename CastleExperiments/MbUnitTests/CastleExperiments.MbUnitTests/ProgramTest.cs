// <copyright file="ProgramTest.cs" company="Gardiner Family">Copyright © Gardiner Family 2009</copyright>
using System;
using CastleExperiments;
using MbUnit.Framework;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace CastleExperiments
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [TestFixture]
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class ProgramTest
    {
    }
}
