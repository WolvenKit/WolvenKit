using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkHudEntryInfo : inkUserData
	{
		[Ordinal(0)] [RED("size")] public Vector2 Size { get; set; }
		[Ordinal(1)] [RED("offset")] public Vector2 Offset { get; set; }

		public inkHudEntryInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
