using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBountyObjectEvent : redEvent
	{
		private Bounty _bounty;

		[Ordinal(0)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get => GetProperty(ref _bounty);
			set => SetProperty(ref _bounty, value);
		}
	}
}
