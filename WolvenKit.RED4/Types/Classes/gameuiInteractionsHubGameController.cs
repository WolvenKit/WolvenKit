using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInteractionsHubGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("TopInteractionWidgetsLibraries")] 
		public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries
		{
			get => GetPropertyValue<CArray<inkWidgetLibraryReference>>();
			set => SetPropertyValue<CArray<inkWidgetLibraryReference>>(value);
		}

		[Ordinal(10)] 
		[RED("TopInteractionsRoot")] 
		public inkWidgetReference TopInteractionsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("BotInteractionWidgetsLibraries")] 
		public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries
		{
			get => GetPropertyValue<CArray<inkWidgetLibraryReference>>();
			set => SetPropertyValue<CArray<inkWidgetLibraryReference>>(value);
		}

		[Ordinal(12)] 
		[RED("BotInteractionsRoot")] 
		public inkWidgetReference BotInteractionsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("TooltipsAnchorPoint")] 
		public inkWidgetReference TooltipsAnchorPoint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(16)] 
		[RED("tooltipProvider")] 
		public CWeakHandle<TooltipProvider> TooltipProvider
		{
			get => GetPropertyValue<CWeakHandle<TooltipProvider>>();
			set => SetPropertyValue<CWeakHandle<TooltipProvider>>(value);
		}

		public gameuiInteractionsHubGameController()
		{
			TopInteractionWidgetsLibraries = new();
			TopInteractionsRoot = new inkWidgetReference();
			BotInteractionWidgetsLibraries = new();
			BotInteractionsRoot = new inkWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			TooltipsAnchorPoint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
