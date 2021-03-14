using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGrenadeThrowQueryParams : CVariable
	{
		private wCHandle<gameObject> _requester;
		private wCHandle<gameObject> _target;
		private CHandle<entIPositionProvider> _targetPositionProvider;
		private CFloat _minRadius;
		private CFloat _maxRadius;
		private CFloat _friendlyAvoidanceRadius;
		private CFloat _throwAngleDegrees;
		private CFloat _gravitySimulation;
		private CFloat _minTargetAngleDegrees;
		private CFloat _maxTargetAngleDegrees;

		[Ordinal(0)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get
			{
				if (_targetPositionProvider == null)
				{
					_targetPositionProvider = (CHandle<entIPositionProvider>) CR2WTypeManager.Create("handle:entIPositionProvider", "targetPositionProvider", cr2w, this);
				}
				return _targetPositionProvider;
			}
			set
			{
				if (_targetPositionProvider == value)
				{
					return;
				}
				_targetPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minRadius")] 
		public CFloat MinRadius
		{
			get
			{
				if (_minRadius == null)
				{
					_minRadius = (CFloat) CR2WTypeManager.Create("Float", "minRadius", cr2w, this);
				}
				return _minRadius;
			}
			set
			{
				if (_minRadius == value)
				{
					return;
				}
				_minRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxRadius")] 
		public CFloat MaxRadius
		{
			get
			{
				if (_maxRadius == null)
				{
					_maxRadius = (CFloat) CR2WTypeManager.Create("Float", "maxRadius", cr2w, this);
				}
				return _maxRadius;
			}
			set
			{
				if (_maxRadius == value)
				{
					return;
				}
				_maxRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("friendlyAvoidanceRadius")] 
		public CFloat FriendlyAvoidanceRadius
		{
			get
			{
				if (_friendlyAvoidanceRadius == null)
				{
					_friendlyAvoidanceRadius = (CFloat) CR2WTypeManager.Create("Float", "friendlyAvoidanceRadius", cr2w, this);
				}
				return _friendlyAvoidanceRadius;
			}
			set
			{
				if (_friendlyAvoidanceRadius == value)
				{
					return;
				}
				_friendlyAvoidanceRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("throwAngleDegrees")] 
		public CFloat ThrowAngleDegrees
		{
			get
			{
				if (_throwAngleDegrees == null)
				{
					_throwAngleDegrees = (CFloat) CR2WTypeManager.Create("Float", "throwAngleDegrees", cr2w, this);
				}
				return _throwAngleDegrees;
			}
			set
			{
				if (_throwAngleDegrees == value)
				{
					return;
				}
				_throwAngleDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get
			{
				if (_gravitySimulation == null)
				{
					_gravitySimulation = (CFloat) CR2WTypeManager.Create("Float", "gravitySimulation", cr2w, this);
				}
				return _gravitySimulation;
			}
			set
			{
				if (_gravitySimulation == value)
				{
					return;
				}
				_gravitySimulation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("minTargetAngleDegrees")] 
		public CFloat MinTargetAngleDegrees
		{
			get
			{
				if (_minTargetAngleDegrees == null)
				{
					_minTargetAngleDegrees = (CFloat) CR2WTypeManager.Create("Float", "minTargetAngleDegrees", cr2w, this);
				}
				return _minTargetAngleDegrees;
			}
			set
			{
				if (_minTargetAngleDegrees == value)
				{
					return;
				}
				_minTargetAngleDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maxTargetAngleDegrees")] 
		public CFloat MaxTargetAngleDegrees
		{
			get
			{
				if (_maxTargetAngleDegrees == null)
				{
					_maxTargetAngleDegrees = (CFloat) CR2WTypeManager.Create("Float", "maxTargetAngleDegrees", cr2w, this);
				}
				return _maxTargetAngleDegrees;
			}
			set
			{
				if (_maxTargetAngleDegrees == value)
				{
					return;
				}
				_maxTargetAngleDegrees = value;
				PropertySet(this);
			}
		}

		public gameGrenadeThrowQueryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
