using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerRefreshPolicy : CVariable
	{
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _kerenzikov;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _restrictedScene;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _dead;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _takedown;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _deviceTakeover;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _braindanceFPP;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _braindanceActive;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _veryHardLanding;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _noScanningRestriction;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _hasNotCybereye;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _isPhotoMode;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}

		[Ordinal(8)] 
		[RED("noScanningRestriction")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> NoScanningRestriction
		{
			get => GetProperty(ref _noScanningRestriction);
			set => SetProperty(ref _noScanningRestriction, value);
		}

		[Ordinal(9)] 
		[RED("hasNotCybereye")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> HasNotCybereye
		{
			get => GetProperty(ref _hasNotCybereye);
			set => SetProperty(ref _hasNotCybereye, value);
		}

		[Ordinal(10)] 
		[RED("isPhotoMode")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> IsPhotoMode
		{
			get => GetProperty(ref _isPhotoMode);
			set => SetProperty(ref _isPhotoMode, value);
		}

		public PlayerVisionModeControllerRefreshPolicy(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
