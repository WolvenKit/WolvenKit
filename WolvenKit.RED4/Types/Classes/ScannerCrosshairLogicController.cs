using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerCrosshairLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		public ScannerCrosshairLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
