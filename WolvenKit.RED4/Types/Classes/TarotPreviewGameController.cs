using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("ep1Icon")] 
		public inkWidgetReference Ep1Icon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("previewImage")] 
		public inkImageWidgetReference PreviewImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("previewTitle")] 
		public inkTextWidgetReference PreviewTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("previewDescription")] 
		public inkTextWidgetReference PreviewDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get => GetPropertyValue<CHandle<TarotCardPreviewData>>();
			set => SetPropertyValue<CHandle<TarotCardPreviewData>>(value);
		}

		[Ordinal(8)] 
		[RED("isClosing")] 
		public CBool IsClosing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TarotPreviewGameController()
		{
			Background = new inkWidgetReference();
			Ep1Icon = new inkWidgetReference();
			PreviewImage = new inkImageWidgetReference();
			PreviewTitle = new inkTextWidgetReference();
			PreviewDescription = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
