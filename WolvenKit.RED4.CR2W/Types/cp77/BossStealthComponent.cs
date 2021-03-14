using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossStealthComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		public BossStealthComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
