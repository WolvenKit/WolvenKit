using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModItemDownloadProgressBarController : LoadingScreenProgressBarController
	{
		[Ordinal(7)] 
		[RED("backgroundOpacity")] 
		public inkWidgetReference BackgroundOpacity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("progressText")] 
		public inkTextWidgetReference ProgressText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModItemDownloadProgressBarController()
		{
			BackgroundOpacity = new inkWidgetReference();
			ProgressText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
