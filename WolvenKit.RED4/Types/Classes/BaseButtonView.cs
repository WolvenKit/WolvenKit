using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class BaseButtonView : inkDiscreteNavigationController
	{
		[Ordinal(4)] 
		[RED("ButtonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		public BaseButtonView()
		{
			IsNavigalbe = true;
			SupportsHoldInput = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
