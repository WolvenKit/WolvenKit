using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReplaceEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("addToInventory")] 
		public CBool AddToInventory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("rerollIdOnAddToInventory")] 
		public CBool RerollIdOnAddToInventory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("removeOldItem")] 
		public CBool RemoveOldItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("customPartToGenerateID")] 
		public gameItemID CustomPartToGenerateID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(7)] 
		[RED("transferInstalledParts")] 
		public CBool TransferInstalledParts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ReplaceEquipmentRequest()
		{
			ItemID = new gameItemID();
			CustomPartToGenerateID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
