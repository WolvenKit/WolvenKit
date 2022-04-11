using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicsJointLinearLimit : physicsPhysicsJointLimitBase
	{
		[Ordinal(5)] 
		[RED("x")] 
		public CEnum<physicsPhysicsJointMotion> X
		{
			get => GetPropertyValue<CEnum<physicsPhysicsJointMotion>>();
			set => SetPropertyValue<CEnum<physicsPhysicsJointMotion>>(value);
		}

		[Ordinal(6)] 
		[RED("y")] 
		public CEnum<physicsPhysicsJointMotion> Y
		{
			get => GetPropertyValue<CEnum<physicsPhysicsJointMotion>>();
			set => SetPropertyValue<CEnum<physicsPhysicsJointMotion>>(value);
		}

		[Ordinal(7)] 
		[RED("z")] 
		public CEnum<physicsPhysicsJointMotion> Z
		{
			get => GetPropertyValue<CEnum<physicsPhysicsJointMotion>>();
			set => SetPropertyValue<CEnum<physicsPhysicsJointMotion>>(value);
		}

		[Ordinal(8)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsPhysicsJointLinearLimit()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
