using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnLookAtBasicEventData : CVariable
	{
		[Ordinal(0)] [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
		[Ordinal(1)] [RED("removePreviousAdvancedLookAts")] public CBool RemovePreviousAdvancedLookAts { get; set; }
		[Ordinal(2)] [RED("requests")] public CArray<animLookAtRequestForPart> Requests { get; set; }

		public scnLookAtBasicEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
