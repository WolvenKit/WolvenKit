using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionPose : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
		[Ordinal(1)]  [RED("outputFloatTrack")] public animNamedTrackIndex OutputFloatTrack { get; set; }

        [Ordinal(999)] [RED("expressionString")] public CString ExpressionString { get; set; }

		public animAnimNode_MathExpressionPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
