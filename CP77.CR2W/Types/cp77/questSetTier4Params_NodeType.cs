using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetTier4Params_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)] [RED("adjustTime")] public CFloat AdjustTime { get; set; }
		[Ordinal(2)] [RED("usePlayerWorkspot")] public CBool UsePlayerWorkspot { get; set; }
		[Ordinal(3)] [RED("useEnterAnim")] public CBool UseEnterAnim { get; set; }
		[Ordinal(4)] [RED("useExitAnim")] public CBool UseExitAnim { get; set; }

		public questSetTier4Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
