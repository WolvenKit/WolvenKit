using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDriveVelocity : CVariable
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

		public physicsPhysicsJointDriveVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
