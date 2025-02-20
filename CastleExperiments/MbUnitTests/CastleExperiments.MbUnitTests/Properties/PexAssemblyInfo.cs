// <copyright file="PexAssemblyInfo.cs" company="Gardiner Family">Copyright © Gardiner Family 2009</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Stubs;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "MbUnit")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("CastleExperiments")]
[assembly: PexInstrumentAssembly("Castle.MicroKernel")]
[assembly: PexInstrumentAssembly("Castle.Windsor")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Castle.MicroKernel")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Castle.Windsor")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "CastleExperiments")]

// Microsoft.Pex.Stubs
[assembly: PexAssumeContractEnsuresFailureAtStubSurface]
[assembly: PexChooseAsStubFallbackBehavior]
[assembly: PexStubsPackage]
[assembly: PexUseStubsFromTestAssembly]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]

