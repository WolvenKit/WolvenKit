using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LeftHandCyberwareDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ProjectileCaught")] 
		public gamebbScriptID_Bool ProjectileCaught
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public LeftHandCyberwareDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
