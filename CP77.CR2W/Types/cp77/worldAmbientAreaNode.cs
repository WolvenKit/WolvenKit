using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAmbientAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] [RED("useCustomColor")] public CBool UseCustomColor { get; set; }

		public worldAmbientAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
