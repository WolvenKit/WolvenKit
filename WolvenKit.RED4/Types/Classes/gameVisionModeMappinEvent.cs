using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeMappinEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameVisionModeMappinEvent()
		{
			Show = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
