using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetReplicatedState : netIEntityState
	{
		private gameMuppetState _state;
		private EulerAngles _initialOrientation;
		private Vector3 _initialLocation;
		private CFloat _health;
		private CFloat _armor;

		[Ordinal(2)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get
			{
				if (_state == null)
				{
					_state = (gameMuppetState) CR2WTypeManager.Create("gameMuppetState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get
			{
				if (_initialOrientation == null)
				{
					_initialOrientation = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "initialOrientation", cr2w, this);
				}
				return _initialOrientation;
			}
			set
			{
				if (_initialOrientation == value)
				{
					return;
				}
				_initialOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get
			{
				if (_initialLocation == null)
				{
					_initialLocation = (Vector3) CR2WTypeManager.Create("Vector3", "initialLocation", cr2w, this);
				}
				return _initialLocation;
			}
			set
			{
				if (_initialLocation == value)
				{
					return;
				}
				_initialLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("health")] 
		public CFloat Health
		{
			get
			{
				if (_health == null)
				{
					_health = (CFloat) CR2WTypeManager.Create("Float", "health", cr2w, this);
				}
				return _health;
			}
			set
			{
				if (_health == value)
				{
					return;
				}
				_health = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("armor")] 
		public CFloat Armor
		{
			get
			{
				if (_armor == null)
				{
					_armor = (CFloat) CR2WTypeManager.Create("Float", "armor", cr2w, this);
				}
				return _armor;
			}
			set
			{
				if (_armor == value)
				{
					return;
				}
				_armor = value;
				PropertySet(this);
			}
		}

		public gameMuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
