using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiarcadeArcadeHealthController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public gameuiarcadeArcadeHealthController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
