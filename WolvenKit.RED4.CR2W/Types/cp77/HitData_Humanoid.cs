using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitData_Humanoid : HitData_Base
	{
		private CEnum<ReactionZones_Humanoid_Side> _reactionZonesSide;

		[Ordinal(3)] 
		[RED("reactionZonesSide")] 
		public CEnum<ReactionZones_Humanoid_Side> ReactionZonesSide
		{
			get => GetProperty(ref _reactionZonesSide);
			set => SetProperty(ref _reactionZonesSide, value);
		}

		public HitData_Humanoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
