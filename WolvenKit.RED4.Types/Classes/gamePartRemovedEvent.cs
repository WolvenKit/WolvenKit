using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePartRemovedEvent : redEvent
	{
		private gameItemID _itemID;
		private gameItemID _removedPartID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("removedPartID")] 
		public gameItemID RemovedPartID
		{
			get => GetProperty(ref _removedPartID);
			set => SetProperty(ref _removedPartID, value);
		}
	}
}
