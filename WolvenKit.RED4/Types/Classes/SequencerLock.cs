using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SequencerLock : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldLock")] 
		public CBool ShouldLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SequencerLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
