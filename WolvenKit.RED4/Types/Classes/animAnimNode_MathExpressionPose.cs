using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MathExpressionPose : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetPropertyValue<animMathExpressionNodeData>();
			set => SetPropertyValue<animMathExpressionNodeData>(value);
		}

		[Ordinal(3)] 
		[RED("outputFloatTrack")] 
		public animNamedTrackIndex OutputFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_MathExpressionPose()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			ExpressionData = new animMathExpressionNodeData();
			OutputFloatTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
