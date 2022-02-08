using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetRevealedInNetwork : redEvent
	{
		[Ordinal(0)] 
		[RED("wasRevealed")] 
		public CBool WasRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
