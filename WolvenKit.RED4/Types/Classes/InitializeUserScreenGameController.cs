using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InitializeUserScreenGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("breachingContainer")] 
		public inkCompoundWidgetReference BreachingContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("progressBar")] 
		public inkCompoundWidgetReference ProgressBar
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(7)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(8)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>();
			set => SetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>(value);
		}

		public InitializeUserScreenGameController()
		{
			BackgroundVideo = new inkVideoWidgetReference();
			BreachingContainer = new inkCompoundWidgetReference();
			ProgressBar = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
