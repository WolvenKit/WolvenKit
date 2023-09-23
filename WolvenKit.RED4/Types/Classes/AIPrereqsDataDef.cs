using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPrereqsDataDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("npcHitTypeTimeout")] 
		public gamebbScriptID_Variant NpcHitTypeTimeout
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public AIPrereqsDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
