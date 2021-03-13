using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputHint_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("show")] public CBool Show { get; set; }
		[Ordinal(1)] [RED("action")] public CName Action { get; set; }
		[Ordinal(2)] [RED("groupId")] public CName GroupId { get; set; }
		[Ordinal(3)] [RED("localizedLabel")] public CString LocalizedLabel { get; set; }

		public questInputHint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
