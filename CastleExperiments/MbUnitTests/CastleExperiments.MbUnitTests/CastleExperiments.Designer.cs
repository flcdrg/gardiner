#pragma warning disable 0067, 0108
// ------------------------------------
// 
// Assembly CastleExperiments
// 
// ------------------------------------
namespace CastleExperiments.Stubs
{
    /// <summary>Stub of IService</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Stubs", "0.13.40528.2")]
    [global::System.Serializable]
    [global::System.Diagnostics.DebuggerDisplay("Stub = IService")]
    [global::System.Diagnostics.DebuggerStepThrough]
    internal partial class SIService
      : global::Microsoft.Stubs.Framework.StubBase
      , global::CastleExperiments.IService
    {
        /// <summary>Initializes a new instance of type SIService</summary>
        [global::System.Diagnostics.DebuggerHidden]
        public SIService()
        {
        }

        /// <summary>Stub of method System.Void CastleExperiments.IService.Thingy(System.String name)</summary>
        [global::System.Diagnostics.DebuggerHidden]
        void global::CastleExperiments.IService.Thingy(string name)
        {
            global::Microsoft.Stubs.Framework.StubDelegates.Action<string> sh = this.Thingy;
            if (sh != (global::Microsoft.Stubs.Framework.StubDelegates.Action<string>)null)
              sh.Invoke(name);
            else 
            {
              global::Microsoft.Stubs.Framework.IStubBehavior stub = base.FallbackBehavior;
              stub.VoidResult<global::CastleExperiments.Stubs.SIService>(this);
            }
        }

        /// <summary>Stub of method System.Void CastleExperiments.IService.Thingy(System.String name)</summary>
        public global::Microsoft.Stubs.Framework.StubDelegates.Action<string> Thingy;
    }
}
namespace CastleExperiments.Stubs
{
    /// <summary>Stub of ISomething</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Stubs", "0.13.40528.2")]
    [global::System.Serializable]
    [global::System.Diagnostics.DebuggerDisplay("Stub = ISomething")]
    [global::System.Diagnostics.DebuggerStepThrough]
    internal partial class SISomething
      : global::Microsoft.Stubs.Framework.StubBase
      , global::CastleExperiments.ISomething
    {
        /// <summary>Initializes a new instance of type SISomething</summary>
        [global::System.Diagnostics.DebuggerHidden]
        public SISomething()
        {
        }

        /// <summary>Stub of method System.String CastleExperiments.ISomething.Hey()</summary>
        [global::System.Diagnostics.DebuggerHidden]
        string global::CastleExperiments.ISomething.Hey()
        {
            global::Microsoft.Stubs.Framework.StubDelegates.Func<string> sh = this.Hey;
            if (sh != (global::Microsoft.Stubs.Framework.StubDelegates.Func<string>)null)
              return sh.Invoke();
            else 
            {
              global::Microsoft.Stubs.Framework.IStubBehavior stub = base.FallbackBehavior;
              return stub.Result<global::CastleExperiments.Stubs.SISomething, string>(this);
            }
        }

        /// <summary>Stub of method System.String CastleExperiments.ISomething.Hey()</summary>
        public global::Microsoft.Stubs.Framework.StubDelegates.Func<string> Hey;
    }
}
namespace CastleExperiments.Stubs
{
    /// <summary>Stub of Program</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Stubs", "0.13.40528.2")]
    [global::System.Serializable]
    [global::System.Diagnostics.DebuggerDisplay("Stub = Program")]
    [global::System.Diagnostics.DebuggerStepThrough]
    internal partial class SProgram
      : global::CastleExperiments.Program
      , global::Microsoft.Stubs.Framework.IStub
      , global::Microsoft.Stubs.Framework.IPartialStub
    {
        /// <summary>Initializes a new instance of type SProgram</summary>
        [global::System.Diagnostics.DebuggerHidden]
        public SProgram()
        {
            this.defaultStub =
              global::Microsoft.Stubs.Framework.StubFallbackBehavior.Current;
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            [global::System.Diagnostics.DebuggerHidden]
            get
            {
                return this.callBase;
            }
            [global::System.Diagnostics.DebuggerHidden]
            set
            {
                this.callBase = value;
            }
        }

        /// <summary>Gets or sets the fallback behavior.</summary>
        public global::Microsoft.Stubs.Framework.IStubBehavior FallbackBehavior
        {
            [global::System.Diagnostics.DebuggerHidden]
            get
            {
                return this.defaultStub;
            }
            [global::System.Diagnostics.DebuggerHidden]
            set
            {
                this.defaultStub = value;
            }
        }

        private bool callBase;

        private global::Microsoft.Stubs.Framework.IStubBehavior defaultStub;
    }
}
namespace CastleExperiments.Stubs
{
    /// <summary>Stub of Service</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Stubs", "0.13.40528.2")]
    [global::System.Serializable]
    [global::System.Diagnostics.DebuggerDisplay("Stub = Service")]
    [global::System.Diagnostics.DebuggerStepThrough]
    public partial class SService
      : global::CastleExperiments.Service
      , global::Microsoft.Stubs.Framework.IStub
      , global::Microsoft.Stubs.Framework.IPartialStub
    {
        /// <summary>Initializes a new instance of type SService</summary>
        [global::System.Diagnostics.DebuggerHidden]
        public SService()
        {
            this.defaultStub =
              global::Microsoft.Stubs.Framework.StubFallbackBehavior.Current;
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            [global::System.Diagnostics.DebuggerHidden]
            get
            {
                return this.callBase;
            }
            [global::System.Diagnostics.DebuggerHidden]
            set
            {
                this.callBase = value;
            }
        }

        /// <summary>Gets or sets the fallback behavior.</summary>
        public global::Microsoft.Stubs.Framework.IStubBehavior FallbackBehavior
        {
            [global::System.Diagnostics.DebuggerHidden]
            get
            {
                return this.defaultStub;
            }
            [global::System.Diagnostics.DebuggerHidden]
            set
            {
                this.defaultStub = value;
            }
        }

        /// <summary>Stub of method System.Void CastleExperiments.Service.Thingy(System.String name)</summary>
        [global::System.Diagnostics.DebuggerHidden]
        public override void Thingy(string name)
        {
            global::Microsoft.Stubs.Framework.StubDelegates.Action<string> sh
               = this.ThingyString;
            if (sh != (global::Microsoft.Stubs.Framework.StubDelegates.Action<string>)null)
              sh.Invoke(name);
            else 
            {
              if (this.callBase)
                base.Thingy(name);
              else 
              {
                global::Microsoft.Stubs.Framework.IStubBehavior stub = this.FallbackBehavior
                  ;
                stub.VoidResult<global::CastleExperiments.Stubs.SService>(this);
              }
            }
        }

        /// <summary>Stub of method System.Void CastleExperiments.Service.Thingy(System.String name)</summary>
        public global::Microsoft.Stubs.Framework.StubDelegates.Action<string> ThingyString;

        private bool callBase;

        private global::Microsoft.Stubs.Framework.IStubBehavior defaultStub;
    }
}

