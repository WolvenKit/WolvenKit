using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionBossDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _excludedWaypointPosition;

		[Ordinal(0)] 
		[RED("excludedWaypointPosition")] 
		public gamebbScriptID_Variant ExcludedWaypointPosition
		{
			get => GetProperty(ref _excludedWaypointPosition);
			set => SetProperty(ref _excludedWaypointPosition, value);
		}
	}
}
