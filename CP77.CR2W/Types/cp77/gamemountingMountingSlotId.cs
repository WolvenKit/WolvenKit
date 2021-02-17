using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingSlotId : CVariable
	{
		[Ordinal(0)] [RED("id")] public CName Id { get; set; }

		public gamemountingMountingSlotId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
