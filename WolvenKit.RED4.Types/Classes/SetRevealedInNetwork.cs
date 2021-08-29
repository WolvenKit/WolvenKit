using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetRevealedInNetwork : redEvent
	{
		private CBool _wasRevealed;

		[Ordinal(0)] 
		[RED("wasRevealed")] 
		public CBool WasRevealed
		{
			get => GetProperty(ref _wasRevealed);
			set => SetProperty(ref _wasRevealed, value);
		}
	}
}
