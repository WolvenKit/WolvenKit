using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseToggleView : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ToggleController")] 
		public CWeakHandle<inkToggleController> ToggleController
		{
			get => GetPropertyValue<CWeakHandle<inkToggleController>>();
			set => SetPropertyValue<CWeakHandle<inkToggleController>>(value);
		}

		[Ordinal(2)] 
		[RED("OldState")] 
		public CEnum<inkEToggleState> OldState
		{
			get => GetPropertyValue<CEnum<inkEToggleState>>();
			set => SetPropertyValue<CEnum<inkEToggleState>>(value);
		}

		public BaseToggleView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
