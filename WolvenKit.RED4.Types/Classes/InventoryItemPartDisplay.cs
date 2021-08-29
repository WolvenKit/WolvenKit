using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemPartDisplay : inkWidgetLogicController
	{
		private inkImageWidgetReference _partIconImage;
		private inkWidgetReference _rarity;
		private CName _texturePartName;
		private InventoryItemAttachments _attachmentData;

		[Ordinal(1)] 
		[RED("PartIconImage")] 
		public inkImageWidgetReference PartIconImage
		{
			get => GetProperty(ref _partIconImage);
			set => SetProperty(ref _partIconImage, value);
		}

		[Ordinal(2)] 
		[RED("Rarity")] 
		public inkWidgetReference Rarity
		{
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}

		[Ordinal(3)] 
		[RED("TexturePartName")] 
		public CName TexturePartName
		{
			get => GetProperty(ref _texturePartName);
			set => SetProperty(ref _texturePartName, value);
		}

		[Ordinal(4)] 
		[RED("attachmentData")] 
		public InventoryItemAttachments AttachmentData
		{
			get => GetProperty(ref _attachmentData);
			set => SetProperty(ref _attachmentData, value);
		}
	}
}
