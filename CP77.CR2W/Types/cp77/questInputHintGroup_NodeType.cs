using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInputHintGroup_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("show")] public CBool Show { get; set; }
		[Ordinal(1)] [RED("iconID")] public TweakDBID IconID { get; set; }
		[Ordinal(2)] [RED("groupId")] public CName GroupId { get; set; }
		[Ordinal(3)] [RED("localizedTitle")] public CString LocalizedTitle { get; set; }
		[Ordinal(4)] [RED("localizedDescription")] public CString LocalizedDescription { get; set; }

		public questInputHintGroup_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
