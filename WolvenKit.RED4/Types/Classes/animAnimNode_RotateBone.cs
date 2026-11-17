using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RotateBone : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(2)] 
		[RED("angleNode")] 
		public animFloatLink AngleNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(3)] 
		[RED("minValueNode")] 
		public animFloatLink MinValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(4)] 
		[RED("maxValueNode")] 
		public animFloatLink MaxValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(5)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("axis")] 
		public CEnum<animETransformAxis> Axis
		{
			get => GetPropertyValue<CEnum<animETransformAxis>>();
			set => SetPropertyValue<CEnum<animETransformAxis>>(value);
		}

		[Ordinal(7)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("biasAngle")] 
		public CFloat BiasAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("minAngle")] 
		public CFloat MinAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("maxAngle")] 
		public CFloat MaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("clampRotation")] 
		public CBool ClampRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("inModelSpace")] 
		public CBool InModelSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_RotateBone()
		{
			Id = uint.MaxValue;
			InputNode = new animPoseLink();
			AngleNode = new animFloatLink();
			MinValueNode = new animFloatLink();
			MaxValueNode = new animFloatLink();
			Bone = new animTransformIndex();
			Axis = Enums.animETransformAxis.X_Axis;
			Scale = 1.000000F;
			MinAngle = -90.000000F;
			MaxAngle = 90.000000F;
			ResetOnActivation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
