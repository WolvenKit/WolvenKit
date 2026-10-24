using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FootStepAdjuster : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("leftToeName")] 
		public animTransformIndex LeftToeName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("rightToeName")] 
		public animTransformIndex RightToeName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("leftFootName")] 
		public animTransformIndex LeftFootName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("rightFootName")] 
		public animTransformIndex RightFootName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("leftCalfName")] 
		public animTransformIndex LeftCalfName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(7)] 
		[RED("rightCalfName")] 
		public animTransformIndex RightCalfName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(8)] 
		[RED("leftThighName")] 
		public animTransformIndex LeftThighName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(9)] 
		[RED("rightThighName")] 
		public animTransformIndex RightThighName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(10)] 
		[RED("pelvisBoneName")] 
		public animTransformIndex PelvisBoneName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(11)] 
		[RED("calfHingeAxis")] 
		public Vector4 CalfHingeAxis
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(12)] 
		[RED("IKBlendTime")] 
		public CFloat IKBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("pelvisAdjustmentBlendSpeed")] 
		public CFloat PelvisAdjustmentBlendSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("adjustPelvisVertically")] 
		public CBool AdjustPelvisVertically
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("stepAdjustmentInterval")] 
		public CFloat StepAdjustmentInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("controlValueNode")] 
		public animFloatLink ControlValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("controlVectorNode")] 
		public animVectorLink ControlVectorNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_FootStepAdjuster()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			LeftToeName = new animTransformIndex();
			RightToeName = new animTransformIndex();
			LeftFootName = new animTransformIndex();
			RightFootName = new animTransformIndex();
			LeftCalfName = new animTransformIndex();
			RightCalfName = new animTransformIndex();
			LeftThighName = new animTransformIndex();
			RightThighName = new animTransformIndex();
			PelvisBoneName = new animTransformIndex();
			CalfHingeAxis = new Vector4 { Z = 1.000000F, W = 1.000000F };
			IKBlendTime = 0.200000F;
			PelvisAdjustmentBlendSpeed = 0.200000F;
			StepAdjustmentInterval = 1.000000F;
			ControlValueNode = new animFloatLink();
			ControlVectorNode = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
