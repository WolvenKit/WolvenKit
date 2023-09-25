using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemPartDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("PartIconImage")] 
		public inkImageWidgetReference PartIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("Rarity")] 
		public inkWidgetReference Rarity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("TexturePartName")] 
		public CName TexturePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("attachmentData")] 
		public CHandle<gameInventoryItemAttachments> AttachmentData
		{
			get => GetPropertyValue<CHandle<gameInventoryItemAttachments>>();
			set => SetPropertyValue<CHandle<gameInventoryItemAttachments>>(value);
		}

		public InventoryItemPartDisplay()
		{
			PartIconImage = new inkImageWidgetReference();
			Rarity = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
