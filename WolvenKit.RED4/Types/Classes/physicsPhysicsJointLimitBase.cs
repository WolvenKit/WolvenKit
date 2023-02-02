using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicsJointLimitBase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("bounceThreshold")] 
		public CFloat BounceThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("contactDistance")] 
		public CFloat ContactDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsPhysicsJointLimitBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
