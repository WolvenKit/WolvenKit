using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleGameplayMappinVisibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleGameplayMappinVisibilityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
