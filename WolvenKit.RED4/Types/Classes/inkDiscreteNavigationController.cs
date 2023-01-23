using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDiscreteNavigationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("shouldUpdateScrollController")] 
		public CBool ShouldUpdateScrollController
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isNavigalbe")] 
		public CBool IsNavigalbe
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("supportsHoldInput")] 
		public CBool SupportsHoldInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkDiscreteNavigationController()
		{
			IsNavigalbe = true;
			SupportsHoldInput = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
