using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionBossDataDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("excludedWaypointPosition")] 
		public gamebbScriptID_Variant ExcludedWaypointPosition
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public AIActionBossDataDef()
		{
			ExcludedWaypointPosition = new();
		}
	}
}
