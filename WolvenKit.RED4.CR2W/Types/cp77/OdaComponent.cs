using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private CHandle<AIHumanComponent> _odaAIComponent;
		private CHandle<gameIBlackboard> _actionBlackBoard;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<OdaEmergencyListener> _healthListener;
		private TweakDBID _statusEffect_emergency;
		private CHandle<AITargetTrackerComponent> _targetTrackerComponent;

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get
			{
				if (_owner_id == null)
				{
					_owner_id = (entEntityID) CR2WTypeManager.Create("entEntityID", "owner_id", cr2w, this);
				}
				return _owner_id;
			}
			set
			{
				if (_owner_id == value)
				{
					return;
				}
				_owner_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("odaAIComponent")] 
		public CHandle<AIHumanComponent> OdaAIComponent
		{
			get
			{
				if (_odaAIComponent == null)
				{
					_odaAIComponent = (CHandle<AIHumanComponent>) CR2WTypeManager.Create("handle:AIHumanComponent", "odaAIComponent", cr2w, this);
				}
				return _odaAIComponent;
			}
			set
			{
				if (_odaAIComponent == value)
				{
					return;
				}
				_odaAIComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("actionBlackBoard")] 
		public CHandle<gameIBlackboard> ActionBlackBoard
		{
			get
			{
				if (_actionBlackBoard == null)
				{
					_actionBlackBoard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "actionBlackBoard", cr2w, this);
				}
				return _actionBlackBoard;
			}
			set
			{
				if (_actionBlackBoard == value)
				{
					return;
				}
				_actionBlackBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get
			{
				if (_statPoolSystem == null)
				{
					_statPoolSystem = (CHandle<gameStatPoolsSystem>) CR2WTypeManager.Create("handle:gameStatPoolsSystem", "statPoolSystem", cr2w, this);
				}
				return _statPoolSystem;
			}
			set
			{
				if (_statPoolSystem == value)
				{
					return;
				}
				_statPoolSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("healthListener")] 
		public CHandle<OdaEmergencyListener> HealthListener
		{
			get
			{
				if (_healthListener == null)
				{
					_healthListener = (CHandle<OdaEmergencyListener>) CR2WTypeManager.Create("handle:OdaEmergencyListener", "healthListener", cr2w, this);
				}
				return _healthListener;
			}
			set
			{
				if (_healthListener == value)
				{
					return;
				}
				_healthListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("statusEffect_emergency")] 
		public TweakDBID StatusEffect_emergency
		{
			get
			{
				if (_statusEffect_emergency == null)
				{
					_statusEffect_emergency = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect_emergency", cr2w, this);
				}
				return _statusEffect_emergency;
			}
			set
			{
				if (_statusEffect_emergency == value)
				{
					return;
				}
				_statusEffect_emergency = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get
			{
				if (_targetTrackerComponent == null)
				{
					_targetTrackerComponent = (CHandle<AITargetTrackerComponent>) CR2WTypeManager.Create("handle:AITargetTrackerComponent", "targetTrackerComponent", cr2w, this);
				}
				return _targetTrackerComponent;
			}
			set
			{
				if (_targetTrackerComponent == value)
				{
					return;
				}
				_targetTrackerComponent = value;
				PropertySet(this);
			}
		}

		public OdaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
