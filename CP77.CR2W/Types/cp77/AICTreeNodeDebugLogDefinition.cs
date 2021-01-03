using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
