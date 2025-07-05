using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseEnabledEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public senseEnabledEvent()
		{
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
