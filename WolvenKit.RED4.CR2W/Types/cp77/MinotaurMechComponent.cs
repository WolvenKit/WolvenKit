using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinotaurMechComponent : gameScriptableComponent
	{
		private TweakDBID _deathAttackRecordID;
		private wCHandle<NPCPuppet> _owner;
		private CHandle<MinotaurOnStatusEffectAppliedListener> _statusEffectListener;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entSimpleColliderComponent> _npcDeathCollisionComponent;
		private CEnum<MechanicalScanType> _currentScanType;
		private CName _currentScanAnimation;

		[Ordinal(5)] 
		[RED("deathAttackRecordID")] 
		public TweakDBID DeathAttackRecordID
		{
			get
			{
				if (_deathAttackRecordID == null)
				{
					_deathAttackRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "deathAttackRecordID", cr2w, this);
				}
				return _deathAttackRecordID;
			}
			set
			{
				if (_deathAttackRecordID == value)
				{
					return;
				}
				_deathAttackRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("statusEffectListener")] 
		public CHandle<MinotaurOnStatusEffectAppliedListener> StatusEffectListener
		{
			get
			{
				if (_statusEffectListener == null)
				{
					_statusEffectListener = (CHandle<MinotaurOnStatusEffectAppliedListener>) CR2WTypeManager.Create("handle:MinotaurOnStatusEffectAppliedListener", "statusEffectListener", cr2w, this);
				}
				return _statusEffectListener;
			}
			set
			{
				if (_statusEffectListener == value)
				{
					return;
				}
				_statusEffectListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get
			{
				if (_npcDeathCollisionComponent == null)
				{
					_npcDeathCollisionComponent = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "npcDeathCollisionComponent", cr2w, this);
				}
				return _npcDeathCollisionComponent;
			}
			set
			{
				if (_npcDeathCollisionComponent == value)
				{
					return;
				}
				_npcDeathCollisionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get
			{
				if (_currentScanType == null)
				{
					_currentScanType = (CEnum<MechanicalScanType>) CR2WTypeManager.Create("MechanicalScanType", "currentScanType", cr2w, this);
				}
				return _currentScanType;
			}
			set
			{
				if (_currentScanType == value)
				{
					return;
				}
				_currentScanType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get
			{
				if (_currentScanAnimation == null)
				{
					_currentScanAnimation = (CName) CR2WTypeManager.Create("CName", "currentScanAnimation", cr2w, this);
				}
				return _currentScanAnimation;
			}
			set
			{
				if (_currentScanAnimation == value)
				{
					return;
				}
				_currentScanAnimation = value;
				PropertySet(this);
			}
		}

		public MinotaurMechComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
