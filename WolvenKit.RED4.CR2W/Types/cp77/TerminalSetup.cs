using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalSetup : CVariable
	{
		private CInt32 _minClearance;
		private CInt32 _maxClearance;
		private CBool _ignoreSlaveAuthorizationModule;
		private CBool _shouldForceVirtualSystem;

		[Ordinal(0)] 
		[RED("minClearance")] 
		public CInt32 MinClearance
		{
			get => GetProperty(ref _minClearance);
			set => SetProperty(ref _minClearance, value);
		}

		[Ordinal(1)] 
		[RED("maxClearance")] 
		public CInt32 MaxClearance
		{
			get => GetProperty(ref _maxClearance);
			set => SetProperty(ref _maxClearance, value);
		}

		[Ordinal(2)] 
		[RED("ignoreSlaveAuthorizationModule")] 
		public CBool IgnoreSlaveAuthorizationModule
		{
			get => GetProperty(ref _ignoreSlaveAuthorizationModule);
			set => SetProperty(ref _ignoreSlaveAuthorizationModule, value);
		}

		[Ordinal(3)] 
		[RED("shouldForceVirtualSystem")] 
		public CBool ShouldForceVirtualSystem
		{
			get => GetProperty(ref _shouldForceVirtualSystem);
			set => SetProperty(ref _shouldForceVirtualSystem, value);
		}

		public TerminalSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
