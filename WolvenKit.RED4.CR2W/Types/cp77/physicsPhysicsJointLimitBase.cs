using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitBase : CVariable
	{
		private CFloat _restitution;
		private CFloat _bounceThreshold;
		private CFloat _stiffness;
		private CFloat _damping;
		private CFloat _contactDistance;

		[Ordinal(0)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get
			{
				if (_restitution == null)
				{
					_restitution = (CFloat) CR2WTypeManager.Create("Float", "restitution", cr2w, this);
				}
				return _restitution;
			}
			set
			{
				if (_restitution == value)
				{
					return;
				}
				_restitution = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bounceThreshold")] 
		public CFloat BounceThreshold
		{
			get
			{
				if (_bounceThreshold == null)
				{
					_bounceThreshold = (CFloat) CR2WTypeManager.Create("Float", "bounceThreshold", cr2w, this);
				}
				return _bounceThreshold;
			}
			set
			{
				if (_bounceThreshold == value)
				{
					return;
				}
				_bounceThreshold = value;
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

		[Ordinal(4)] 
		[RED("contactDistance")] 
		public CFloat ContactDistance
		{
			get
			{
				if (_contactDistance == null)
				{
					_contactDistance = (CFloat) CR2WTypeManager.Create("Float", "contactDistance", cr2w, this);
				}
				return _contactDistance;
			}
			set
			{
				if (_contactDistance == value)
				{
					return;
				}
				_contactDistance = value;
				PropertySet(this);
			}
		}

		public physicsPhysicsJointLimitBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
