using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckRemovedItemWithSlotActiveItem : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public CheckRemovedItemWithSlotActiveItem()
		{
			ItemID = new();
		}
	}
}
