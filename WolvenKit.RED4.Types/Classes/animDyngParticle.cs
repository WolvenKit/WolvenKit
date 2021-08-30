using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDyngParticle : RedBaseClass
	{
		private CFloat _mass;
		private CFloat _damping;
		private CFloat _pullForceFactor;
		private CBool _isFree;
		private animTransformIndex _bone;
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;
		private Vector3 _collisionCapsuleAxisLS;
		private CEnum<animDyngParticleProjectionType> _projectionType;

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(2)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		[Ordinal(3)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get => GetProperty(ref _pullForceFactor);
			set => SetProperty(ref _pullForceFactor, value);
		}

		[Ordinal(4)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetProperty(ref _isFree);
			set => SetProperty(ref _isFree, value);
		}

		[Ordinal(5)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(6)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetProperty(ref _collisionCapsuleRadius);
			set => SetProperty(ref _collisionCapsuleRadius, value);
		}

		[Ordinal(7)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetProperty(ref _collisionCapsuleHeightExtent);
			set => SetProperty(ref _collisionCapsuleHeightExtent, value);
		}

		[Ordinal(8)] 
		[RED("collisionCapsuleAxisLS")] 
		public Vector3 CollisionCapsuleAxisLS
		{
			get => GetProperty(ref _collisionCapsuleAxisLS);
			set => SetProperty(ref _collisionCapsuleAxisLS, value);
		}

		[Ordinal(9)] 
		[RED("projectionType")] 
		public CEnum<animDyngParticleProjectionType> ProjectionType
		{
			get => GetProperty(ref _projectionType);
			set => SetProperty(ref _projectionType, value);
		}

		public animDyngParticle()
		{
			_mass = 1.000000F;
			_damping = 1.000000F;
			_isFree = true;
			_projectionType = new() { Value = Enums.animDyngParticleProjectionType.ShortestPath };
		}
	}
}
