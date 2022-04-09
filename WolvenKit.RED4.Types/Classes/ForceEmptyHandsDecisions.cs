using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceEmptyHandsDecisions : UpperBodyTransition
	{
		[Ordinal(0)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForceEmptyHandsDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
