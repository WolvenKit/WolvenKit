using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDefaultLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>();
			set => SetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>(value);
		}

		public inkDefaultLoadingScreenLogicController()
		{
			ProgressBarRoot = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
