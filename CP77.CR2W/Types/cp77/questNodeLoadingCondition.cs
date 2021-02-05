using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questNodeLoadingCondition : questCondition
	{
		[Ordinal(0)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)]  [RED("inverted")] public CBool Inverted { get; set; }

		public questNodeLoadingCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
