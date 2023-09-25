using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CW_MuteArmDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("MuteArmActive")] 
		public gamebbScriptID_Bool MuteArmActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("MuteArmRadius")] 
		public gamebbScriptID_Float MuteArmRadius
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public CW_MuteArmDef()
		{
			MuteArmActive = new gamebbScriptID_Bool();
			MuteArmRadius = new gamebbScriptID_Float();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
