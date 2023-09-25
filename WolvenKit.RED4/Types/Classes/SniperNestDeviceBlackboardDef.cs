using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SniperNestDeviceBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsInTheSniperNest")] 
		public gamebbScriptID_Bool IsInTheSniperNest
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("FastForwardToZoom4")] 
		public gamebbScriptID_Bool FastForwardToZoom4
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("SniperNestDefaultSpeedMultiplier")] 
		public gamebbScriptID_Float SniperNestDefaultSpeedMultiplier
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("SniperNestZoomedSpeedMultiplier")] 
		public gamebbScriptID_Float SniperNestZoomedSpeedMultiplier
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public SniperNestDeviceBlackboardDef()
		{
			IsInTheSniperNest = new gamebbScriptID_Bool();
			FastForwardToZoom4 = new gamebbScriptID_Bool();
			SniperNestDefaultSpeedMultiplier = new gamebbScriptID_Float();
			SniperNestZoomedSpeedMultiplier = new gamebbScriptID_Float();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
