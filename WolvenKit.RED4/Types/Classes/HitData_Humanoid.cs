using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitData_Humanoid : HitData_Base
	{
		[Ordinal(3)] 
		[RED("reactionZonesSide")] 
		public CEnum<ReactionZones_Humanoid_Side> ReactionZonesSide
		{
			get => GetPropertyValue<CEnum<ReactionZones_Humanoid_Side>>();
			set => SetPropertyValue<CEnum<ReactionZones_Humanoid_Side>>(value);
		}

		public HitData_Humanoid()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
