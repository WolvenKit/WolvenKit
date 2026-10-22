using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Ik2 : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("firstBone")] 
		public animTransformIndex FirstBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("secondBone")] 
		public animTransformIndex SecondBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("endBone")] 
		public animTransformIndex EndBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(5)] 
		[RED("minHingeAngleDegrees")] 
		public CFloat MinHingeAngleDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxHingeAngleDegrees")] 
		public CFloat MaxHingeAngleDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("firstBoneIkGain")] 
		public CFloat FirstBoneIkGain
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("secondBoneIkGain")] 
		public CFloat SecondBoneIkGain
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("endBoneIkGain")] 
		public CFloat EndBoneIkGain
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("enforceEndPosition")] 
		public CBool EnforceEndPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("enforceEndOrientation")] 
		public CBool EnforceEndOrientation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("endBoneOffsetPositionLS")] 
		public Vector4 EndBoneOffsetPositionLS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(15)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(16)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("endTargetPositionNode")] 
		public animVectorLink EndTargetPositionNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(18)] 
		[RED("endTargetOrientationNode")] 
		public animQuaternionLink EndTargetOrientationNode
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		public animAnimNode_Ik2()
		{
			Id = uint.MaxValue;
			FirstBone = new animTransformIndex();
			SecondBone = new animTransformIndex();
			EndBone = new animTransformIndex();
			HingeAxis = Enums.animAxis.Y;
			MaxHingeAngleDegrees = 180.000000F;
			FirstBoneIkGain = 1.000000F;
			SecondBoneIkGain = 1.000000F;
			EndBoneIkGain = 1.000000F;
			EnforceEndPosition = true;
			EndBoneOffsetPositionLS = new Vector4();
			Bone = new animTransformIndex();
			FloatTrack = new animNamedTrackIndex();
			InputPoseNode = new animPoseLink();
			WeightNode = new animFloatLink();
			EndTargetPositionNode = new animVectorLink();
			EndTargetOrientationNode = new animQuaternionLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
