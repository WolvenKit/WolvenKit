using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeSubwayGateStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChangeSubwayGateStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
