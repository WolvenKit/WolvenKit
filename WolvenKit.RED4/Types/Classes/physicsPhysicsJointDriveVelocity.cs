using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicsJointDriveVelocity : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("linearVelocity")] 
		public Vector4 LinearVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("angularVelocity")] 
		public Vector4 AngularVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public physicsPhysicsJointDriveVelocity()
		{
			LinearVelocity = new Vector4 { W = 1.000000F };
			AngularVelocity = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
