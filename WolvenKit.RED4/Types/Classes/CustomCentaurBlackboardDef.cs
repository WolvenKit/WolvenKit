using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomCentaurBlackboardDef : CustomBlackboardDef
	{
		[Ordinal(0)] 
		[RED("ShieldState")] 
		public gamebbScriptID_Int32 ShieldState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("WeakSpotHitTimeStamp")] 
		public gamebbScriptID_Float WeakSpotHitTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("ShieldTarget")] 
		public gamebbScriptID_EntityID ShieldTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(3)] 
		[RED("WoundedStateHPThreshold")] 
		public gamebbScriptID_Float WoundedStateHPThreshold
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public CustomCentaurBlackboardDef()
		{
			ShieldState = new gamebbScriptID_Int32();
			WeakSpotHitTimeStamp = new gamebbScriptID_Float();
			ShieldTarget = new gamebbScriptID_EntityID();
			WoundedStateHPThreshold = new gamebbScriptID_Float();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
