using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleStylesGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("stateText")] 
		public CWeakHandle<inkTextWidget> StateText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("button1Controller")] 
		public CWeakHandle<inkButtonController> Button1Controller
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(4)] 
		[RED("button2Controller")] 
		public CWeakHandle<inkButtonController> Button2Controller
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		public sampleStylesGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
