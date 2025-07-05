using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LocomotionAdjuster : animAnimNode_OnePoseInput
	{
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
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(15)] 
		[RED("blendSpeedPos")] 
		public CFloat BlendSpeedPos
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("blendSpeedPosMin")] 
		public CFloat BlendSpeedPosMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("blendSpeedRot")] 
		public CFloat BlendSpeedRot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_LocomotionAdjuster()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			TargetPosition = new animVectorLink();
			TargetDirection = new animVectorLink();
			InitialForwardVector = new Vector4 { Y = 1.000000F };
			BlendSpeedPos = 8.000000F;
			BlendSpeedPosMin = 2.000000F;
			BlendSpeedRot = 180.000000F;
			MaxDistance = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
