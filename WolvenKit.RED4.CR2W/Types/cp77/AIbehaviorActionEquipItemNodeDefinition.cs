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
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(2)] 
		[RED("itemId")] 
		public CHandle<AIArgumentMapping> ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("failIfItemNotFound")] 
		public CHandle<AIArgumentMapping> FailIfItemNotFound
		{
			get => GetProperty(ref _failIfItemNotFound);
			set => SetProperty(ref _failIfItemNotFound, value);
		}

		[Ordinal(5)] 
		[RED("spawnDelay")] 
		public CHandle<AIArgumentMapping> SpawnDelay
		{
			get => GetProperty(ref _spawnDelay);
			set => SetProperty(ref _spawnDelay, value);
		}

		public AIbehaviorActionEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
