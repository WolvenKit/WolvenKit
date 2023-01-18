using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicsJointDrive : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("forceLimit")] 
		public CFloat ForceLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("isAcceleration")] 
		public CBool IsAcceleration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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

		public physicsPhysicsJointDrive()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
