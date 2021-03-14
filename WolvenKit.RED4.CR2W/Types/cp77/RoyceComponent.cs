using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<RoyceHealthChangeListener> _healthListener;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entIComponent> _npcHitRepresentationComponent;
		private CHandle<animAnimFeature_HitReactionsData> _hitData;

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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("healthListener")] 
		public CHandle<RoyceHealthChangeListener> HealthListener
		{
			get
			{
				if (_healthListener == null)
				{
					_healthListener = (CHandle<RoyceHealthChangeListener>) CR2WTypeManager.Create("handle:RoyceHealthChangeListener", "healthListener", cr2w, this);
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("npcHitRepresentationComponent")] 
		public CHandle<entIComponent> NpcHitRepresentationComponent
		{
			get
			{
				if (_npcHitRepresentationComponent == null)
				{
					_npcHitRepresentationComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "npcHitRepresentationComponent", cr2w, this);
				}
				return _npcHitRepresentationComponent;
			}
			set
			{
				if (_npcHitRepresentationComponent == value)
				{
					return;
				}
				_npcHitRepresentationComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get
			{
				if (_hitData == null)
				{
					_hitData = (CHandle<animAnimFeature_HitReactionsData>) CR2WTypeManager.Create("handle:animAnimFeature_HitReactionsData", "hitData", cr2w, this);
				}
				return _hitData;
			}
			set
			{
				if (_hitData == value)
				{
					return;
				}
				_hitData = value;
				PropertySet(this);
			}
		}

		public RoyceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
