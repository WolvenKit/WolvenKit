using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexEntryViewController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("imageWidget")] 
		public inkImageWidgetReference ImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("imageWidgetFallback")] 
		public inkWidgetReference ImageWidgetFallback
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("imageWidgetWrapper")] 
		public inkWidgetReference ImageWidgetWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("scrollWidget")] 
		public inkWidgetReference ScrollWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("contentWrapper")] 
		public inkWidgetReference ContentWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("noEntrySelectedWidget")] 
		public inkWidgetReference NoEntrySelectedWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<GenericCodexEntryData> Data
		{
			get => GetPropertyValue<CHandle<GenericCodexEntryData>>();
			set => SetPropertyValue<CHandle<GenericCodexEntryData>>(value);
		}

		[Ordinal(10)] 
		[RED("scroll")] 
		public CWeakHandle<inkScrollController> Scroll
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		public CodexEntryViewController()
		{
			TitleText = new();
			DescriptionText = new();
			ImageWidget = new();
			ImageWidgetFallback = new();
			ImageWidgetWrapper = new();
			ScrollWidget = new();
			ContentWrapper = new();
			NoEntrySelectedWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
