using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CleanUpTimeDilationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CleanUpTimeDilationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
