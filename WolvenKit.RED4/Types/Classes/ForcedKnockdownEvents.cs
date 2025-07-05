using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForcedKnockdownEvents : KnockdownEvents
	{
		[Ordinal(20)] 
		[RED("firstUpdate")] 
		public CBool FirstUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForcedKnockdownEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
