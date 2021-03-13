using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questReplacer_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questReplacer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
