using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionPose_ : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
		[Ordinal(3)] [RED("outputFloatTrack")] public animNamedTrackIndex OutputFloatTrack { get; set; }

		public animAnimNode_MathExpressionPose_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
