using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class artist_test_area_r : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("linesWidget")] 
		public CWeakHandle<inkCanvasWidget> LinesWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		public artist_test_area_r()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
