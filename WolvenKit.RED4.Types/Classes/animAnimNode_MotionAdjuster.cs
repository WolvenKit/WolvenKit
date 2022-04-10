using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MotionAdjuster : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("targetPosition")] 
		public animVectorLink TargetPosition
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(13)] 
		[RED("targetDirection")] 
		public animVectorLink TargetDirection
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(14)] 
		[RED("totalTimeToAdjust")] 
		public animFloatLink TotalTimeToAdjust
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(15)] 
		[RED("forwardVector")] 
		public Vector4 ForwardVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimNode_MotionAdjuster()
		{
			Id = 4294967295;
			InputNode = new();
			TargetPosition = new();
			TargetDirection = new();
			TotalTimeToAdjust = new();
			ForwardVector = new() { Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
