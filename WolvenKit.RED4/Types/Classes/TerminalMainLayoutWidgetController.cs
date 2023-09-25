using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TerminalMainLayoutWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("thumbnailsListSlot")] 
		public inkWidgetReference ThumbnailsListSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("deviceSlot")] 
		public inkWidgetReference DeviceSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("returnButton")] 
		public inkWidgetReference ReturnButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("titleWidget")] 
		public inkTextWidgetReference TitleWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("backgroundImage")] 
		public inkImageWidgetReference BackgroundImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("backgroundImageTrace")] 
		public inkImageWidgetReference BackgroundImageTrace
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("main_canvas")] 
		public CWeakHandle<inkWidget> Main_canvas
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public TerminalMainLayoutWidgetController()
		{
			ThumbnailsListSlot = new inkWidgetReference();
			DeviceSlot = new inkWidgetReference();
			ReturnButton = new inkWidgetReference();
			TitleWidget = new inkTextWidgetReference();
			BackgroundImage = new inkImageWidgetReference();
			BackgroundImageTrace = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
