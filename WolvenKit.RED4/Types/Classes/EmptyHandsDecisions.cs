using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmptyHandsDecisions : UpperBodyTransition
	{
		[Ordinal(0)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EmptyHandsDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
