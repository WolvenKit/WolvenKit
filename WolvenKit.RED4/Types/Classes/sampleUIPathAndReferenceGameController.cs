using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIPathAndReferenceGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public inkWidgetPath ImageWidgetPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkImageWidget> ImageWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("panelWidget")] 
		public CWeakHandle<inkBasePanelWidget> PanelWidget
		{
			get => GetPropertyValue<CWeakHandle<inkBasePanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkBasePanelWidget>>(value);
		}

		public sampleUIPathAndReferenceGameController()
		{
			TextWidget = new();
			ImageWidgetPath = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
