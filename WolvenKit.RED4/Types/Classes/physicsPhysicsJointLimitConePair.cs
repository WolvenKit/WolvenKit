using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		[Ordinal(5)] 
		[RED("swingY")] 
		public CEnum<physicsPhysicsJointMotion> SwingY
		{
			get => GetPropertyValue<CEnum<physicsPhysicsJointMotion>>();
			set => SetPropertyValue<CEnum<physicsPhysicsJointMotion>>(value);
		}

		[Ordinal(6)] 
		[RED("swingZ")] 
		public CEnum<physicsPhysicsJointMotion> SwingZ
		{
			get => GetPropertyValue<CEnum<physicsPhysicsJointMotion>>();
			set => SetPropertyValue<CEnum<physicsPhysicsJointMotion>>(value);
		}

		[Ordinal(7)] 
		[RED("yAngle")] 
		public CFloat YAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("zAngle")] 
		public CFloat ZAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsPhysicsJointLimitConePair()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
