using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitData_Humanoid : HitData_Base
	{
		private CEnum<ReactionZones_Humanoid_Side> _reactionZonesSide;

		[Ordinal(3)] 
		[RED("reactionZonesSide")] 
		public CEnum<ReactionZones_Humanoid_Side> ReactionZonesSide
		{
			get => GetProperty(ref _reactionZonesSide);
			set => SetProperty(ref _reactionZonesSide, value);
		}
	}
}
