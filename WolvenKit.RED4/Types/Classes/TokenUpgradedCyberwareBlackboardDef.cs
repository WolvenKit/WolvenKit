using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TokenUpgradedCyberwareBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CyberwareTypes")] 
		public gamebbScriptID_Variant CyberwareTypes
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public TokenUpgradedCyberwareBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
