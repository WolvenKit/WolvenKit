using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePuppetReplicatedState : netIEntityState
	{
		private EulerAngles _initialOrientation;
		private Vector3 _initialLocation;
		private CName _initialAppearance;
		private gameActionsReplicationBuffer _actionsBuffer;
		private CFloat _health;
		private CFloat _armor;
		private CBool _hasCPOMissionData;
		private CArray<CName> _cPOMissionVotedHistory;
		private gameReplicatedAnimControllerEventsState _animEventsState;
		private gameReplicatedEntityEventsState _entityEventsState;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("initialAppearance")] 
		public CName InitialAppearance
		{
			get
			{
				if (_initialAppearance == null)
				{
					_initialAppearance = (CName) CR2WTypeManager.Create("CName", "initialAppearance", cr2w, this);
				}
				return _initialAppearance;
			}
			set
			{
				if (_initialAppearance == value)
				{
					return;
				}
				_initialAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actionsBuffer")] 
		public gameActionsReplicationBuffer ActionsBuffer
		{
			get
			{
				if (_actionsBuffer == null)
				{
					_actionsBuffer = (gameActionsReplicationBuffer) CR2WTypeManager.Create("gameActionsReplicationBuffer", "actionsBuffer", cr2w, this);
				}
				return _actionsBuffer;
			}
			set
			{
				if (_actionsBuffer == value)
				{
					return;
				}
				_actionsBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("hasCPOMissionData")] 
		public CBool HasCPOMissionData
		{
			get
			{
				if (_hasCPOMissionData == null)
				{
					_hasCPOMissionData = (CBool) CR2WTypeManager.Create("Bool", "hasCPOMissionData", cr2w, this);
				}
				return _hasCPOMissionData;
			}
			set
			{
				if (_hasCPOMissionData == value)
				{
					return;
				}
				_hasCPOMissionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("CPOMissionVotedHistory")] 
		public CArray<CName> CPOMissionVotedHistory
		{
			get
			{
				if (_cPOMissionVotedHistory == null)
				{
					_cPOMissionVotedHistory = (CArray<CName>) CR2WTypeManager.Create("array:CName", "CPOMissionVotedHistory", cr2w, this);
				}
				return _cPOMissionVotedHistory;
			}
			set
			{
				if (_cPOMissionVotedHistory == value)
				{
					return;
				}
				_cPOMissionVotedHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("animEventsState")] 
		public gameReplicatedAnimControllerEventsState AnimEventsState
		{
			get
			{
				if (_animEventsState == null)
				{
					_animEventsState = (gameReplicatedAnimControllerEventsState) CR2WTypeManager.Create("gameReplicatedAnimControllerEventsState", "animEventsState", cr2w, this);
				}
				return _animEventsState;
			}
			set
			{
				if (_animEventsState == value)
				{
					return;
				}
				_animEventsState = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("entityEventsState")] 
		public gameReplicatedEntityEventsState EntityEventsState
		{
			get
			{
				if (_entityEventsState == null)
				{
					_entityEventsState = (gameReplicatedEntityEventsState) CR2WTypeManager.Create("gameReplicatedEntityEventsState", "entityEventsState", cr2w, this);
				}
				return _entityEventsState;
			}
			set
			{
				if (_entityEventsState == value)
				{
					return;
				}
				_entityEventsState = value;
				PropertySet(this);
			}
		}

		public gamePuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
