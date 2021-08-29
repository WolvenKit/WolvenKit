using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEquippedPrereq : gameIPrereq
	{
		private gameItemID _itemID;
		private TweakDBID _slot;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("slot")] 
		public TweakDBID Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}
	}
}
