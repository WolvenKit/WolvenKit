using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetInteractionVisualizerOverride : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)]  [RED("applyOverride")] public CBool ApplyOverride { get; set; }
		[Ordinal(2)]  [RED("removeAfterSingleUse")] public CBool RemoveAfterSingleUse { get; set; }

		public questSetInteractionVisualizerOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
