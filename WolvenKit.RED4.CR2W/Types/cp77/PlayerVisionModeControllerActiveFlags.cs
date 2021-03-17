using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerActiveFlags : CVariable
	{
		private CBool _kerenzikov;
		private CBool _restrictedScene;
		private CBool _dead;
		private CBool _takedown;
		private CBool _deviceTakeover;
		private CBool _braindanceFPP;
		private CBool _braindanceActive;
		private CBool _veryHardLanding;
		private CBool _noScanningRestriction;
		private CBool _hasNotCybereye;
		private CBool _isPhotoMode;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CBool Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CBool RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CBool Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CBool Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CBool DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CBool BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CBool BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CBool VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}

		[Ordinal(8)] 
		[RED("noScanningRestriction")] 
		public CBool NoScanningRestriction
		{
			get => GetProperty(ref _noScanningRestriction);
			set => SetProperty(ref _noScanningRestriction, value);
		}

		[Ordinal(9)] 
		[RED("hasNotCybereye")] 
		public CBool HasNotCybereye
		{
			get => GetProperty(ref _hasNotCybereye);
			set => SetProperty(ref _hasNotCybereye, value);
		}

		[Ordinal(10)] 
		[RED("isPhotoMode")] 
		public CBool IsPhotoMode
		{
			get => GetProperty(ref _isPhotoMode);
			set => SetProperty(ref _isPhotoMode, value);
		}

		public PlayerVisionModeControllerActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
