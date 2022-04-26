using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseButtonView : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ButtonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		public BaseButtonView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
