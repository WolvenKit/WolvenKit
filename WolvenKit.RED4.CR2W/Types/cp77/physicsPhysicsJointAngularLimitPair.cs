using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointAngularLimitPair : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _twist;
		private CFloat _upper;
		private CFloat _lower;

		[Ordinal(5)] 
		[RED("twist")] 
		public CEnum<physicsPhysicsJointMotion> Twist
		{
			get
			{
				if (_twist == null)
				{
					_twist = (CEnum<physicsPhysicsJointMotion>) CR2WTypeManager.Create("physicsPhysicsJointMotion", "twist", cr2w, this);
				}
				return _twist;
			}
			set
			{
				if (_twist == value)
				{
					return;
				}
				_twist = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("upper")] 
		public CFloat Upper
		{
			get
			{
				if (_upper == null)
				{
					_upper = (CFloat) CR2WTypeManager.Create("Float", "upper", cr2w, this);
				}
				return _upper;
			}
			set
			{
				if (_upper == value)
				{
					return;
				}
				_upper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lower")] 
		public CFloat Lower
		{
			get
			{
				if (_lower == null)
				{
					_lower = (CFloat) CR2WTypeManager.Create("Float", "lower", cr2w, this);
				}
				return _lower;
			}
			set
			{
				if (_lower == value)
				{
					return;
				}
				_lower = value;
				PropertySet(this);
			}
		}

		public physicsPhysicsJointAngularLimitPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
