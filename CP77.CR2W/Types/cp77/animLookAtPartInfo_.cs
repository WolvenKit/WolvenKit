using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartInfo_ : CVariable
	{
		[Ordinal(0)] [RED("partName")] public CName PartName { get; set; }
		[Ordinal(1)] [RED("defaultPositionBoneName")] public CName DefaultPositionBoneName { get; set; }

		public animLookAtPartInfo_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
