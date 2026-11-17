using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameInventoryItemAttachments : IScriptable
	{
		[Ordinal(0)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("ItemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(2)] 
		[RED("SlotName")] 
		public CString SlotName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("SlotType")] 
		public CEnum<gameInventoryItemAttachmentType> SlotType
		{
			get => GetPropertyValue<CEnum<gameInventoryItemAttachmentType>>();
			set => SetPropertyValue<CEnum<gameInventoryItemAttachmentType>>(value);
		}

		public gameInventoryItemAttachments()
		{
			ItemData = new gameInventoryItemData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
