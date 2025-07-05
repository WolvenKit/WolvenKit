using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsToggleAimDownSightsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggleOn")] 
		public CBool ToggleOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameaudioeventsToggleAimDownSightsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
