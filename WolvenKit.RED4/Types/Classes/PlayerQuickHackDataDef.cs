using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerQuickHackDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CachedQuickHackList")] 
		public gamebbScriptID_Variant CachedQuickHackList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public PlayerQuickHackDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
