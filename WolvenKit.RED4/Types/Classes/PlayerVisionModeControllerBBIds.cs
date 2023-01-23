using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerBBIds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CHandle<gamebbScriptDefinition> Kerenzikov
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CHandle<gamebbScriptDefinition> RestrictedScene
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CHandle<gamebbScriptDefinition> Dead
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CHandle<gamebbScriptDefinition> Takedown
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CHandle<gamebbScriptDefinition> DeviceTakeover
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CHandle<gamebbScriptDefinition> BraindanceFPP
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CHandle<gamebbScriptDefinition> BraindanceActive
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CHandle<gamebbScriptDefinition> VeryHardLanding
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(8)] 
		[RED("isBriefingActive")] 
		public CHandle<gamebbScriptDefinition> IsBriefingActive
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		public PlayerVisionModeControllerBBIds()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
