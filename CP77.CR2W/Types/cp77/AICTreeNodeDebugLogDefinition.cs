using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDebugLogDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(0)]  [RED("text")] public CString Text { get; set; }
		[Ordinal(1)]  [RED("timeOnScreen")] public CFloat TimeOnScreen { get; set; }
		[Ordinal(2)]  [RED("useVisualDebug")] public CBool UseVisualDebug { get; set; }

		public AICTreeNodeDebugLogDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
