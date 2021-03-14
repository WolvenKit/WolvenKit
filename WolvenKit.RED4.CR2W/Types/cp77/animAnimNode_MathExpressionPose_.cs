using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionPose_ : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
		[Ordinal(13)] [RED("outputFloatTrack")] public animNamedTrackIndex OutputFloatTrack { get; set; }

		public animAnimNode_MathExpressionPose_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
