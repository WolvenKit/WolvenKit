using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitBase : CVariable
	{
		private CFloat _restitution;
		private CFloat _bounceThreshold;
		private CFloat _stiffness;
		private CFloat _damping;
		private CFloat _contactDistance;

		[Ordinal(0)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetProperty(ref _restitution);
			set => SetProperty(ref _restitution, value);
		}

		[Ordinal(1)] 
		[RED("bounceThreshold")] 
		public CFloat BounceThreshold
		{
			get => GetProperty(ref _bounceThreshold);
			set => SetProperty(ref _bounceThreshold, value);
		}

		[Ordinal(2)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetProperty(ref _stiffness);
			set => SetProperty(ref _stiffness, value);
		}

		[Ordinal(3)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		[Ordinal(4)] 
		[RED("contactDistance")] 
		public CFloat ContactDistance
		{
			get => GetProperty(ref _contactDistance);
			set => SetProperty(ref _contactDistance, value);
		}

		public physicsPhysicsJointLimitBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
