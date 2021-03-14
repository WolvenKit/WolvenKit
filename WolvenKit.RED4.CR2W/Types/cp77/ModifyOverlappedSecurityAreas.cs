using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyOverlappedSecurityAreas : redEvent
	{
		[Ordinal(0)] [RED("isEntering")] public CBool IsEntering { get; set; }
		[Ordinal(1)] [RED("zoneID")] public gamePersistentID ZoneID { get; set; }

		public ModifyOverlappedSecurityAreas(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
