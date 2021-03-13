using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAdditionalFloatTrackContainer : CVariable
	{
		[Ordinal(0)] [RED("entries")] public CArray<animAdditionalFloatTrackEntry> Entries { get; set; }
		[Ordinal(1)] [RED("overwriteExistingValues")] public CBool OverwriteExistingValues { get; set; }

		public animAdditionalFloatTrackContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
