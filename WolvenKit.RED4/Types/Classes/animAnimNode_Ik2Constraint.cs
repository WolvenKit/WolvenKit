using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Ik2Constraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("inputTarget")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> InputTarget
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>(value);
		}

		[Ordinal(3)] 
		[RED("inputPoleVector")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> InputPoleVector
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>(value);
		}

		[Ordinal(4)] 
		[RED("inputTargetOrientation")] 
		public CHandle<animAnimNodeSourceChannel_WeightedQuat> InputTargetOrientation
		{
			get => GetPropertyValue<CHandle<animAnimNodeSourceChannel_WeightedQuat>>();
			set => SetPropertyValue<CHandle<animAnimNodeSourceChannel_WeightedQuat>>(value);
		}

		[Ordinal(5)] 
		[RED("firstBoneIndex")] 
		public animTransformIndex FirstBoneIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("secondBoneIndex")] 
		public animTransformIndex SecondBoneIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(7)] 
		[RED("endBoneIndex")] 
		public animTransformIndex EndBoneIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(8)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(9)] 
		[RED("twistValue")] 
		public CFloat TwistValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(12)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(13)] 
		[RED("twistNode")] 
		public animFloatLink TwistNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("maxHingeAngle")] 
		public CFloat MaxHingeAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_Ik2Constraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			FirstBoneIndex = new animTransformIndex();
			SecondBoneIndex = new animTransformIndex();
			EndBoneIndex = new animTransformIndex();
			HingeAxis = Enums.animAxis.Y;
			Weight = 1.000000F;
			WeightFloatTrack = new animNamedTrackIndex();
			WeightNode = new animFloatLink();
			TwistNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
