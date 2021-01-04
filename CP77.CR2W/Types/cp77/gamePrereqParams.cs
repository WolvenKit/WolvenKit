using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePrereqParams : CVariable
	{
		[Ordinal(0)]  [RED("objectID")] public gameStatsObjectID ObjectID { get; set; }
		[Ordinal(1)]  [RED("otherData")] public CVariant OtherData { get; set; }
		[Ordinal(2)]  [RED("otherObjectID")] public gameStatsObjectID OtherObjectID { get; set; }

		public gamePrereqParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
