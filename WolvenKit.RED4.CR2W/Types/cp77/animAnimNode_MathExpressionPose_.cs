using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionPose_ : animAnimNode_OnePoseInput
	{
		private animMathExpressionNodeData _expressionData;
		private animNamedTrackIndex _outputFloatTrack;

		[Ordinal(12)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetProperty(ref _expressionData);
			set => SetProperty(ref _expressionData, value);
		}

		[Ordinal(13)] 
		[RED("outputFloatTrack")] 
		public animNamedTrackIndex OutputFloatTrack
		{
			get => GetProperty(ref _outputFloatTrack);
			set => SetProperty(ref _outputFloatTrack, value);
		}

		public animAnimNode_MathExpressionPose_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
