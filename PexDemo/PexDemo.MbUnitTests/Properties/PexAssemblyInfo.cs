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
[assembly: PexAssemblyUnderTest("PexDemo")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PexDemo")]

// Microsoft.Pex.Stubs
[assembly: PexAssumeContractEnsuresFailureAtStubSurface]
[assembly: PexChooseAsStubFallbackBehavior]
[assembly: PexStubsPackage]
[assembly: PexUseStubsFromTestAssembly]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]

