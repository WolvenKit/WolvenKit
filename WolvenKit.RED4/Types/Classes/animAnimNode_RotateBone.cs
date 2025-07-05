using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RotateBone : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("angleNode")] 
		public animFloatLink AngleNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(13)] 
		[RED("minValueNode")] 
		public animFloatLink MinValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("maxValueNode")] 
		public animFloatLink MaxValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(15)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("axis")] 
		public CEnum<animETransformAxis> Axis
		{
			get => GetPropertyValue<CEnum<animETransformAxis>>();
			set => SetPropertyValue<CEnum<animETransformAxis>>(value);
		}

		[Ordinal(17)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("biasAngle")] 
		public CFloat BiasAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("minAngle")] 
		public CFloat MinAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("maxAngle")] 
		public CFloat MaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("clampRotation")] 
		public CBool ClampRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
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
