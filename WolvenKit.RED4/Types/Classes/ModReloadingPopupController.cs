using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModReloadingPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("progressBarRef")] 
		public inkWidgetReference ProgressBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("noTurnOffTextWidget")] 
		public inkTextWidgetReference NoTurnOffTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>();
			set => SetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<ModReloadingPopupData> Data
		{
			get => GetPropertyValue<CHandle<ModReloadingPopupData>>();
			set => SetPropertyValue<CHandle<ModReloadingPopupData>>(value);
		}

		[Ordinal(6)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		public ModReloadingPopupController()
		{
			ProgressBarRef = new inkWidgetReference();
			NoTurnOffTextWidget = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
