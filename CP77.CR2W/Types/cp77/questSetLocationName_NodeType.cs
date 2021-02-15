using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetLocationName_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("locationName")] public CString LocationName { get; set; }
		[Ordinal(1)] [RED("action")] public CEnum<questLocationAction> Action { get; set; }
		[Ordinal(2)] [RED("districtID")] public TweakDBID DistrictID { get; set; }
		[Ordinal(3)] [RED("isNewLocation")] public CBool IsNewLocation { get; set; }

		public questSetLocationName_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
