using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateAutoRevealStatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UpdateAutoRevealStatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
