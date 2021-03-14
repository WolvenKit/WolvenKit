using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionEquipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		private CHandle<AIArgumentMapping> _slotId;
		private CHandle<AIArgumentMapping> _itemId;
		private CHandle<AIArgumentMapping> _duration;
		private CHandle<AIArgumentMapping> _failIfItemNotFound;
		private CHandle<AIArgumentMapping> _spawnDelay;

		[Ordinal(1)] 
		[RED("slotId")] 
		public CHandle<AIArgumentMapping> SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemId")] 
		public CHandle<AIArgumentMapping> ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("failIfItemNotFound")] 
		public CHandle<AIArgumentMapping> FailIfItemNotFound
		{
			get
			{
				if (_failIfItemNotFound == null)
				{
					_failIfItemNotFound = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "failIfItemNotFound", cr2w, this);
				}
				return _failIfItemNotFound;
			}
			set
			{
				if (_failIfItemNotFound == value)
				{
					return;
				}
				_failIfItemNotFound = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("spawnDelay")] 
		public CHandle<AIArgumentMapping> SpawnDelay
		{
			get
			{
				if (_spawnDelay == null)
				{
					_spawnDelay = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spawnDelay", cr2w, this);
				}
				return _spawnDelay;
			}
			set
			{
				if (_spawnDelay == value)
				{
					return;
				}
				_spawnDelay = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
