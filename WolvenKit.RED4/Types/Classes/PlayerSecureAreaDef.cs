using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerSecureAreaDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("inside")] 
		public gamebbScriptID_Bool Inside
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public PlayerSecureAreaDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
