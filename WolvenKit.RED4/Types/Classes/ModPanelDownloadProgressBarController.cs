using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModPanelDownloadProgressBarController : LoadingScreenProgressBarController
	{
		[Ordinal(7)] 
		[RED("spinnerFluff")] 
		public inkWidgetReference SpinnerFluff
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("textFluff")] 
		public inkWidgetReference TextFluff
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("progressText")] 
		public inkTextWidgetReference ProgressText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModPanelDownloadProgressBarController()
		{
			SpinnerFluff = new inkWidgetReference();
			TextFluff = new inkWidgetReference();
			ProgressText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
