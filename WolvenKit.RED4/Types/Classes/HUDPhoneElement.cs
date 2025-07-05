using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class HUDPhoneElement : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public HUDPhoneElement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
