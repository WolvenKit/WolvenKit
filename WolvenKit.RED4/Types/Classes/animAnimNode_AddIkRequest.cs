using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AddIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(6)] 
		[RED("poleVector")] 
		public animPoleVectorDetails PoleVector
		{
			get => GetPropertyValue<animPoleVectorDetails>();
			set => SetPropertyValue<animPoleVectorDetails>(value);
		}

		[Ordinal(7)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("weightRotation")] 
		public CFloat WeightRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimNode_AddIkRequest()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			TargetBone = new animTransformIndex();
			PositionOffset = new Vector3();
			RotationOffset = new Quaternion();
			PoleVector = new animPoleVectorDetails();
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
