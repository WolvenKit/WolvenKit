using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workEquipItemToSlotAction : workIWorkspotItemAction
	{
		private TweakDBID _item;
		private TweakDBID _itemSlot;

		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetProperty(ref _itemSlot);
			set => SetProperty(ref _itemSlot, value);
		}
	}
}
