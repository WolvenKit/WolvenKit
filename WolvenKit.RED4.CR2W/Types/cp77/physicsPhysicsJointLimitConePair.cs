using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _swingY;
		private CEnum<physicsPhysicsJointMotion> _swingZ;
		private CFloat _yAngle;
		private CFloat _zAngle;

		[Ordinal(5)] 
		[RED("swingY")] 
		public CEnum<physicsPhysicsJointMotion> SwingY
		{
			get
			{
				if (_swingY == null)
				{
					_swingY = (CEnum<physicsPhysicsJointMotion>) CR2WTypeManager.Create("physicsPhysicsJointMotion", "swingY", cr2w, this);
				}
				return _swingY;
			}
			set
			{
				if (_swingY == value)
				{
					return;
				}
				_swingY = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("swingZ")] 
		public CEnum<physicsPhysicsJointMotion> SwingZ
		{
			get
			{
				if (_swingZ == null)
				{
					_swingZ = (CEnum<physicsPhysicsJointMotion>) CR2WTypeManager.Create("physicsPhysicsJointMotion", "swingZ", cr2w, this);
				}
				return _swingZ;
			}
			set
			{
				if (_swingZ == value)
				{
					return;
				}
				_swingZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("yAngle")] 
		public CFloat YAngle
		{
			get
			{
				if (_yAngle == null)
				{
					_yAngle = (CFloat) CR2WTypeManager.Create("Float", "yAngle", cr2w, this);
				}
				return _yAngle;
			}
			set
			{
				if (_yAngle == value)
				{
					return;
				}
				_yAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("zAngle")] 
		public CFloat ZAngle
		{
			get
			{
				if (_zAngle == null)
				{
					_zAngle = (CFloat) CR2WTypeManager.Create("Float", "zAngle", cr2w, this);
				}
				return _zAngle;
			}
			set
			{
				if (_zAngle == value)
				{
					return;
				}
				_zAngle = value;
				PropertySet(this);
			}
		}

		public physicsPhysicsJointLimitConePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
