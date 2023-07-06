using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class BaseButtonView : inkWidgetLogicController
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
