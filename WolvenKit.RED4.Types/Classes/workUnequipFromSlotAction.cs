using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workUnequipFromSlotAction : workIWorkspotItemAction
	{
		private TweakDBID _itemSlot;

		[Ordinal(0)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetProperty(ref _itemSlot);
			set => SetProperty(ref _itemSlot, value);
		}
	}
}
