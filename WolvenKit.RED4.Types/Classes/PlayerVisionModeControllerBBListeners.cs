using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVisionModeControllerBBListeners : RedBaseClass
	{
		private CHandle<redCallbackObject> _kerenzikov;
		private CHandle<redCallbackObject> _restrictedScene;
		private CHandle<redCallbackObject> _dead;
		private CHandle<redCallbackObject> _takedown;
		private CHandle<redCallbackObject> _deviceTakeover;
		private CHandle<redCallbackObject> _braindanceFPP;
		private CHandle<redCallbackObject> _braindanceActive;
		private CHandle<redCallbackObject> _veryHardLanding;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CHandle<redCallbackObject> Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CHandle<redCallbackObject> RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CHandle<redCallbackObject> Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CHandle<redCallbackObject> Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CHandle<redCallbackObject> DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CHandle<redCallbackObject> BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CHandle<redCallbackObject> BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CHandle<redCallbackObject> VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}
	}
}
