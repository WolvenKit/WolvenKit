using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TarotPreviewGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("previewImage")] 
		public inkImageWidgetReference PreviewImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("previewTitle")] 
		public inkTextWidgetReference PreviewTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("previewDescription")] 
		public inkTextWidgetReference PreviewDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get => GetPropertyValue<CHandle<TarotCardPreviewData>>();
			set => SetPropertyValue<CHandle<TarotCardPreviewData>>(value);
		}

		public TarotPreviewGameController()
		{
			Background = new();
			PreviewImage = new();
			PreviewTitle = new();
			PreviewDescription = new();
		}
	}
}
