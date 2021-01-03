using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitData_Humanoid : HitData_Base
	{
		[Ordinal(0)]  [RED("reactionZonesSide")] public CEnum<ReactionZones_Humanoid_Side> ReactionZonesSide { get; set; }

		public HitData_Humanoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
