using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIActionBossDataDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("excludedWaypointPosition")] 
		public gamebbScriptID_Variant ExcludedWaypointPosition
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("excludedTeleportPosition")] 
		public gamebbScriptID_Vector4 ExcludedTeleportPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		public AIActionBossDataDef()
		{
			ExcludedWaypointPosition = new gamebbScriptID_Variant();
			ExcludedTeleportPosition = new gamebbScriptID_Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
