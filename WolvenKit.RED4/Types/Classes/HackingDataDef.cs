using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackingDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("SpreadMap")] 
		public gamebbScriptID_Variant SpreadMap
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public HackingDataDef()
		{
			SpreadMap = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
