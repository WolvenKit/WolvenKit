using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_MathExpressionPose : animAnimNode_OnePoseInput
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
	}
}
