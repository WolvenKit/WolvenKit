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
			get
			{
				if (_reactionZonesSide == null)
				{
					_reactionZonesSide = (CEnum<ReactionZones_Humanoid_Side>) CR2WTypeManager.Create("ReactionZones_Humanoid_Side", "reactionZonesSide", cr2w, this);
				}
				return _reactionZonesSide;
			}
			set
			{
				if (_reactionZonesSide == value)
				{
					return;
				}
				_reactionZonesSide = value;
				PropertySet(this);
			}
		}

		public HitData_Humanoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
