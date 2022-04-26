using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerBBValuesIds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public gamebbScriptID_Int32 Kerenzikov
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public gamebbScriptID_Int32 RestrictedScene
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public gamebbScriptID_Int32 Dead
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public gamebbScriptID_EntityID DeviceTakeover
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public gamebbScriptID_Bool BraindanceFPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public gamebbScriptID_Bool BraindanceActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public gamebbScriptID_Int32 VeryHardLanding
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("isBriefingActive")] 
		public gamebbScriptID_Bool IsBriefingActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public PlayerVisionModeControllerBBValuesIds()
		{
			Kerenzikov = new();
			RestrictedScene = new();
			Dead = new();
			Takedown = new();
			DeviceTakeover = new();
			BraindanceFPP = new();
			BraindanceActive = new();
			VeryHardLanding = new();
			IsBriefingActive = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
