using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimSetVisibilityEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkanimSetVisibilityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
