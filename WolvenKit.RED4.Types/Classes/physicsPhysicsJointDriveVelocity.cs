using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsPhysicsJointDriveVelocity : RedBaseClass
	{
		private Vector4 _linearVelocity;
		private Vector4 _angularVelocity;

		[Ordinal(0)] 
		[RED("linearVelocity")] 
		public Vector4 LinearVelocity
		{
			get => GetProperty(ref _linearVelocity);
			set => SetProperty(ref _linearVelocity, value);
		}

		[Ordinal(1)] 
		[RED("angularVelocity")] 
		public Vector4 AngularVelocity
		{
			get => GetProperty(ref _angularVelocity);
			set => SetProperty(ref _angularVelocity, value);
		}
	}
}
