using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartInfo : CVariable
	{
		[Ordinal(0)]  [RED("partName")] public CName PartName { get; set; }
		[Ordinal(1)]  [RED("defaultPositionBoneName")] public CName DefaultPositionBoneName { get; set; }

        [Ordinal(999)] [RED("debugDrawingEnabled")] public CBool debugDrawingEnabled { get; set; }

		public animLookAtPartInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
