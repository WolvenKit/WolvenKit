using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackPanelStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickHackPanelStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
