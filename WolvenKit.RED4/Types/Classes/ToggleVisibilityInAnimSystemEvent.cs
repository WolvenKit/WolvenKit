using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleVisibilityInAnimSystemEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ToggleVisibilityInAnimSystemEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
