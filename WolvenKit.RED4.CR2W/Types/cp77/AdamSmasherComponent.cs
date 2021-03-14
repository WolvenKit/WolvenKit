using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdamSmasherComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private TweakDBID _statusEffect_armor1_id;
		private TweakDBID _statusEffect_armor2_id;
		private TweakDBID _statusEffect_armor3_id;
		private TweakDBID _statusEffect_smashed_id;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<AdamSmasherHealthChangeListener> _healthListener;
		private CFloat _phase2Threshold;
		private CFloat _phase3Threshold;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
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
		[RED("statusEffect_armor1_id")] 
		public TweakDBID StatusEffect_armor1_id
		{
			get
			{
				if (_statusEffect_armor1_id == null)
				{
					_statusEffect_armor1_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect_armor1_id", cr2w, this);
				}
				return _statusEffect_armor1_id;
			}
			set
			{
				if (_statusEffect_armor1_id == value)
				{
					return;
				}
				_statusEffect_armor1_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("statusEffect_armor2_id")] 
		public TweakDBID StatusEffect_armor2_id
		{
			get
			{
				if (_statusEffect_armor2_id == null)
				{
					_statusEffect_armor2_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect_armor2_id", cr2w, this);
				}
				return _statusEffect_armor2_id;
			}
			set
			{
				if (_statusEffect_armor2_id == value)
				{
					return;
				}
				_statusEffect_armor2_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statusEffect_armor3_id")] 
		public TweakDBID StatusEffect_armor3_id
		{
			get
			{
				if (_statusEffect_armor3_id == null)
				{
					_statusEffect_armor3_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect_armor3_id", cr2w, this);
				}
				return _statusEffect_armor3_id;
			}
			set
			{
				if (_statusEffect_armor3_id == value)
				{
					return;
				}
				_statusEffect_armor3_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("statusEffect_smashed_id")] 
		public TweakDBID StatusEffect_smashed_id
		{
			get
			{
				if (_statusEffect_smashed_id == null)
				{
					_statusEffect_smashed_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect_smashed_id", cr2w, this);
				}
				return _statusEffect_smashed_id;
			}
			set
			{
				if (_statusEffect_smashed_id == value)
				{
					return;
				}
				_statusEffect_smashed_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("healthListener")] 
		public CHandle<AdamSmasherHealthChangeListener> HealthListener
		{
			get
			{
				if (_healthListener == null)
				{
					_healthListener = (CHandle<AdamSmasherHealthChangeListener>) CR2WTypeManager.Create("handle:AdamSmasherHealthChangeListener", "healthListener", cr2w, this);
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

		[Ordinal(14)] 
		[RED("phase2Threshold")] 
		public CFloat Phase2Threshold
		{
			get
			{
				if (_phase2Threshold == null)
				{
					_phase2Threshold = (CFloat) CR2WTypeManager.Create("Float", "phase2Threshold", cr2w, this);
				}
				return _phase2Threshold;
			}
			set
			{
				if (_phase2Threshold == value)
				{
					return;
				}
				_phase2Threshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("phase3Threshold")] 
		public CFloat Phase3Threshold
		{
			get
			{
				if (_phase3Threshold == null)
				{
					_phase3Threshold = (CFloat) CR2WTypeManager.Create("Float", "phase3Threshold", cr2w, this);
				}
				return _phase3Threshold;
			}
			set
			{
				if (_phase3Threshold == value)
				{
					return;
				}
				_phase3Threshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get
			{
				if (_npcCollisionComponent == null)
				{
					_npcCollisionComponent = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "npcCollisionComponent", cr2w, this);
				}
				return _npcCollisionComponent;
			}
			set
			{
				if (_npcCollisionComponent == value)
				{
					return;
				}
				_npcCollisionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		public AdamSmasherComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
