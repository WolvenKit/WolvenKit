using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEventData : CVariable
	{
		[Ordinal(0)]  [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
		[Ordinal(1)]  [RED("requests")] public CArray<animLookAtRequestForPart> Requests { get; set; }

		public scnLookAtAdvancedEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
