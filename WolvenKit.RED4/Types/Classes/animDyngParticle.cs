using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDyngParticle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("collisionCapsuleAxisLS")] 
		public Vector3 CollisionCapsuleAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("projectionType")] 
		public CEnum<animDyngParticleProjectionType> ProjectionType
		{
			get => GetPropertyValue<CEnum<animDyngParticleProjectionType>>();
			set => SetPropertyValue<CEnum<animDyngParticleProjectionType>>(value);
		}

		public animDyngParticle()
		{
			Mass = 1.000000F;
			Damping = 1.000000F;
			IsFree = true;
			Bone = new animTransformIndex();
			CollisionCapsuleAxisLS = new Vector3 { X = 0.500000F };
			ProjectionType = Enums.animDyngParticleProjectionType.ShortestPath;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
