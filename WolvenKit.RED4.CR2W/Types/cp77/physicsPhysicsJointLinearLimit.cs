using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLinearLimit : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _x;
		private CEnum<physicsPhysicsJointMotion> _y;
		private CEnum<physicsPhysicsJointMotion> _z;
		private CFloat _value;

		[Ordinal(5)] 
		[RED("x")] 
		public CEnum<physicsPhysicsJointMotion> X
		{
			get
			{
				if (_x == null)
				{
					_x = (CEnum<physicsPhysicsJointMotion>) CR2WTypeManager.Create("physicsPhysicsJointMotion", "x", cr2w, this);
				}
				return _x;
			}
			set
			{
				if (_x == value)
				{
					return;
				}
				_x = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("y")] 
		public CEnum<physicsPhysicsJointMotion> Y
		{
			get
			{
				if (_y == null)
				{
					_y = (CEnum<physicsPhysicsJointMotion>) CR2WTypeManager.Create("physicsPhysicsJointMotion", "y", cr2w, this);
				}
				return _y;
			}
			set
			{
				if (_y == value)
				{
					return;
				}
				_y = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("z")] 
		public CEnum<physicsPhysicsJointMotion> Z
		{
			get
			{
				if (_z == null)
				{
					_z = (CEnum<physicsPhysicsJointMotion>) CR2WTypeManager.Create("physicsPhysicsJointMotion", "z", cr2w, this);
				}
				return _z;
			}
			set
			{
				if (_z == value)
				{
					return;
				}
				_z = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public physicsPhysicsJointLinearLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
