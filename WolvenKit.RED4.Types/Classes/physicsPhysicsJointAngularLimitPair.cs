using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicsJointAngularLimitPair : physicsPhysicsJointLimitBase
	{
		[Ordinal(5)] 
		[RED("twist")] 
		public CEnum<physicsPhysicsJointMotion> Twist
		{
			get => GetPropertyValue<CEnum<physicsPhysicsJointMotion>>();
			set => SetPropertyValue<CEnum<physicsPhysicsJointMotion>>(value);
		}

		[Ordinal(6)] 
		[RED("upper")] 
		public CFloat Upper
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lower")] 
		public CFloat Lower
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsPhysicsJointAngularLimitPair()
		{
			Upper = 180.000000F;
			Lower = -180.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
