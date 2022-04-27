using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AddIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(15)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(16)] 
		[RED("poleVector")] 
		public animPoleVectorDetails PoleVector
		{
			get => GetPropertyValue<animPoleVectorDetails>();
			set => SetPropertyValue<animPoleVectorDetails>(value);
		}

		[Ordinal(17)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("weightRotation")] 
		public CFloat WeightRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimNode_AddIkRequest()
		{
			Id = 4294967295;
			InputLink = new();
			TargetBone = new();
			PositionOffset = new();
			RotationOffset = new() { R = 1.000000F };
			PoleVector = new() { TargetBone = new(), PositionOffset = new() };
			WeightPosition = 1.000000F;
			WeightRotation = 1.000000F;
			BlendTimeIn = 0.500000F;
			BlendTimeOut = 0.500000F;
			Priority = 100;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
