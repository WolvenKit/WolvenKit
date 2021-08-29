using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractionsHubGameController : gameuiHUDGameController
	{
		private CArray<inkWidgetLibraryReference> _topInteractionWidgetsLibraries;
		private inkWidgetReference _topInteractionsRoot;
		private CArray<inkWidgetLibraryReference> _botInteractionWidgetsLibraries;
		private inkWidgetReference _botInteractionsRoot;
		private inkWidgetReference _tooltipsManagerRef;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(9)] 
		[RED("TopInteractionWidgetsLibraries")] 
		public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries
		{
			get => GetProperty(ref _topInteractionWidgetsLibraries);
			set => SetProperty(ref _topInteractionWidgetsLibraries, value);
		}

		[Ordinal(10)] 
		[RED("TopInteractionsRoot")] 
		public inkWidgetReference TopInteractionsRoot
		{
			get => GetProperty(ref _topInteractionsRoot);
			set => SetProperty(ref _topInteractionsRoot, value);
		}

		[Ordinal(11)] 
		[RED("BotInteractionWidgetsLibraries")] 
		public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries
		{
			get => GetProperty(ref _botInteractionWidgetsLibraries);
			set => SetProperty(ref _botInteractionWidgetsLibraries, value);
		}

		[Ordinal(12)] 
		[RED("BotInteractionsRoot")] 
		public inkWidgetReference BotInteractionsRoot
		{
			get => GetProperty(ref _botInteractionsRoot);
			set => SetProperty(ref _botInteractionsRoot, value);
		}

		[Ordinal(13)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(14)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}
	}
}
