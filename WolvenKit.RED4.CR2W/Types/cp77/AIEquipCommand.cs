using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEquipCommand : AICommand
	{
		private TweakDBID _slotId;
		private TweakDBID _itemId;
		private CBool _failIfItemNotFound;
		private CFloat _durationOverride;

		[Ordinal(4)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(5)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(6)] 
		[RED("failIfItemNotFound")] 
		public CBool FailIfItemNotFound
		{
			get => GetProperty(ref _failIfItemNotFound);
			set => SetProperty(ref _failIfItemNotFound, value);
		}

		[Ordinal(7)] 
		[RED("durationOverride")] 
		public CFloat DurationOverride
		{
			get => GetProperty(ref _durationOverride);
			set => SetProperty(ref _durationOverride, value);
		}

		public AIEquipCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
