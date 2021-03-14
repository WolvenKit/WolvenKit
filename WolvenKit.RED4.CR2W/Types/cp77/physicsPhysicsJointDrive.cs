using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDrive : CVariable
	{
		private CFloat _forceLimit;
		private CBool _isAcceleration;
		private CFloat _stiffness;
		private CFloat _damping;

		[Ordinal(0)] 
		[RED("forceLimit")] 
		public CFloat ForceLimit
		{
			get
			{
				if (_forceLimit == null)
				{
					_forceLimit = (CFloat) CR2WTypeManager.Create("Float", "forceLimit", cr2w, this);
				}
				return _forceLimit;
			}
			set
			{
				if (_forceLimit == value)
				{
					return;
				}
				_forceLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isAcceleration")] 
		public CBool IsAcceleration
		{
			get
			{
				if (_isAcceleration == null)
				{
					_isAcceleration = (CBool) CR2WTypeManager.Create("Bool", "isAcceleration", cr2w, this);
				}
				return _isAcceleration;
			}
			set
			{
				if (_isAcceleration == value)
				{
					return;
				}
				_isAcceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get
			{
				if (_stiffness == null)
				{
					_stiffness = (CFloat) CR2WTypeManager.Create("Float", "stiffness", cr2w, this);
				}
				return _stiffness;
			}
			set
			{
				if (_stiffness == value)
				{
					return;
				}
				_stiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get
			{
				if (_damping == null)
				{
					_damping = (CFloat) CR2WTypeManager.Create("Float", "damping", cr2w, this);
				}
				return _damping;
			}
			set
			{
				if (_damping == value)
				{
					return;
				}
				_damping = value;
				PropertySet(this);
			}
		}

		public physicsPhysicsJointDrive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
