using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questInputHint_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("action")] public CName Action { get; set; }
		[Ordinal(1)]  [RED("groupId")] public CName GroupId { get; set; }
		[Ordinal(2)]  [RED("localizedLabel")] public CString LocalizedLabel { get; set; }
		[Ordinal(3)]  [RED("show")] public CBool Show { get; set; }

		public questInputHint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
