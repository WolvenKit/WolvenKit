using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCinematicAnimSetSRRef : CVariable
	{
		[Ordinal(0)] [RED("asyncAnimSet")] public raRef<animAnimSet> AsyncAnimSet { get; set; }
		[Ordinal(1)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(2)] [RED("isOverride")] public CBool IsOverride { get; set; }

		public scnCinematicAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
