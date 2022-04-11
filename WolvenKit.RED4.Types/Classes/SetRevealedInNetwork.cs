using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetRevealedInNetwork : redEvent
	{
		[Ordinal(0)] 
		[RED("wasRevealed")] 
		public CBool WasRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetRevealedInNetwork()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
