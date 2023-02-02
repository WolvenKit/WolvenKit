using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomEventCondition : AISignalCondition
	{
		[Ordinal(5)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CustomEventCondition()
		{
			RequiredFlags = new();
			ConsumesSignal = true;
			ExecutingSignal = new() { Tags = new(0), Priority = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
