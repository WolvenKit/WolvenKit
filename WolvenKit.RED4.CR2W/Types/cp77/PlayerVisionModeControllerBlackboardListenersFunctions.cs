using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBlackboardListenersFunctions : CVariable
	{
		private CName _kerenzikov;
		private CName _restrictedScene;
		private CName _dead;
		private CName _takedown;
		private CName _deviceTakeover;
		private CName _braindanceFPP;
		private CName _braindanceActive;
		private CName _veryHardLanding;
		private CName _noScanningRestriction;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CName Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CName RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CName Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CName Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CName DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CName BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CName BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CName VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}

		[Ordinal(8)] 
		[RED("noScanningRestriction")] 
		public CName NoScanningRestriction
		{
			get => GetProperty(ref _noScanningRestriction);
			set => SetProperty(ref _noScanningRestriction, value);
		}

		public PlayerVisionModeControllerBlackboardListenersFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
