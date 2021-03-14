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
			get
			{
				if (_linearVelocity == null)
				{
					_linearVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "linearVelocity", cr2w, this);
				}
				return _linearVelocity;
			}
			set
			{
				if (_linearVelocity == value)
				{
					return;
				}
				_linearVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("angularVelocity")] 
		public Vector4 AngularVelocity
		{
			get
			{
				if (_angularVelocity == null)
				{
					_angularVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "angularVelocity", cr2w, this);
				}
				return _angularVelocity;
			}
			set
			{
				if (_angularVelocity == value)
				{
					return;
				}
				_angularVelocity = value;
				PropertySet(this);
			}
		}

		public physicsPhysicsJointDriveVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
