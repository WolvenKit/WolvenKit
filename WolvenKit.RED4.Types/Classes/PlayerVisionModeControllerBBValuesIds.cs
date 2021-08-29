using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVisionModeControllerBBValuesIds : RedBaseClass
	{
		private gamebbScriptID_Int32 _kerenzikov;
		private gamebbScriptID_Int32 _restrictedScene;
		private gamebbScriptID_Int32 _dead;
		private gamebbScriptID_Int32 _takedown;
		private gamebbScriptID_EntityID _deviceTakeover;
		private gamebbScriptID_Bool _braindanceFPP;
		private gamebbScriptID_Bool _braindanceActive;
		private gamebbScriptID_Int32 _veryHardLanding;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public gamebbScriptID_Int32 Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public gamebbScriptID_Int32 RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public gamebbScriptID_Int32 Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public gamebbScriptID_EntityID DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public gamebbScriptID_Bool BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public gamebbScriptID_Bool BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public gamebbScriptID_Int32 VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}
	}
}
