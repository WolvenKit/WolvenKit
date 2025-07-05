using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FootStepAdjuster : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("leftToeName")] 
		public animTransformIndex LeftToeName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("rightToeName")] 
		public animTransformIndex RightToeName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("leftFootName")] 
		public animTransformIndex LeftFootName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("rightFootName")] 
		public animTransformIndex RightFootName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("leftCalfName")] 
		public animTransformIndex LeftCalfName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(17)] 
		[RED("rightCalfName")] 
		public animTransformIndex RightCalfName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(18)] 
		[RED("leftThighName")] 
		public animTransformIndex LeftThighName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(19)] 
		[RED("rightThighName")] 
		public animTransformIndex RightThighName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(20)] 
		[RED("pelvisBoneName")] 
		public animTransformIndex PelvisBoneName
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(21)] 
		[RED("calfHingeAxis")] 
		public Vector4 CalfHingeAxis
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(22)] 
		[RED("IKBlendTime")] 
		public CFloat IKBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("pelvisAdjustmentBlendSpeed")] 
		public CFloat PelvisAdjustmentBlendSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("adjustPelvisVertically")] 
		public CBool AdjustPelvisVertically
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("stepAdjustmentInterval")] 
		public CFloat StepAdjustmentInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("controlValueNode")] 
		public animFloatLink ControlValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(27)] 
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
