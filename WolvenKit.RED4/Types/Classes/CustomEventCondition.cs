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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
