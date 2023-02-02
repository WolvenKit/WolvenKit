using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MathExpressionPose : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetPropertyValue<animMathExpressionNodeData>();
			set => SetPropertyValue<animMathExpressionNodeData>(value);
		}

		[Ordinal(13)] 
		[RED("outputFloatTrack")] 
		public animNamedTrackIndex OutputFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_MathExpressionPose()
		{
			Id = 4294967295;
			InputLink = new();
			ExpressionData = new() { FloatSockets = new(), VectorSockets = new(), QuaternionSockets = new() };
			OutputFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
