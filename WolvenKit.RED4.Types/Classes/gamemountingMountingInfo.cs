using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemountingMountingInfo : RedBaseClass
	{
		private entEntityID _childId;
		private entEntityID _parentId;
		private gamemountingMountingSlotId _slotId;

		[Ordinal(0)] 
		[RED("childId")] 
		public entEntityID ChildId
		{
			get => GetProperty(ref _childId);
			set => SetProperty(ref _childId, value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get => GetProperty(ref _parentId);
			set => SetProperty(ref _parentId, value);
		}

		[Ordinal(2)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}
	}
}
