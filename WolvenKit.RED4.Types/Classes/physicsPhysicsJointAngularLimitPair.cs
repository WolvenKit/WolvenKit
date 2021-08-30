using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsPhysicsJointAngularLimitPair : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _twist;
		private CFloat _upper;
		private CFloat _lower;

		[Ordinal(5)] 
		[RED("twist")] 
		public CEnum<physicsPhysicsJointMotion> Twist
		{
			get => GetProperty(ref _twist);
			set => SetProperty(ref _twist, value);
		}

		[Ordinal(6)] 
		[RED("upper")] 
		public CFloat Upper
		{
			get => GetProperty(ref _upper);
			set => SetProperty(ref _upper, value);
		}

		[Ordinal(7)] 
		[RED("lower")] 
		public CFloat Lower
		{
			get => GetProperty(ref _lower);
			set => SetProperty(ref _lower, value);
		}

		public physicsPhysicsJointAngularLimitPair()
		{
			_upper = 180.000000F;
			_lower = -180.000000F;
		}
	}
}
