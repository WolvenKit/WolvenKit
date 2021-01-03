using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionPose : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
		[Ordinal(1)]  [RED("outputFloatTrack")] public animNamedTrackIndex OutputFloatTrack { get; set; }

		public animAnimNode_MathExpressionPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
