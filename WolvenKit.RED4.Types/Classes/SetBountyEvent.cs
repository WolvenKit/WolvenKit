using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBountyEvent : redEvent
	{
		private TweakDBID _bountyID;

		[Ordinal(0)] 
		[RED("bountyID")] 
		public TweakDBID BountyID
		{
			get => GetProperty(ref _bountyID);
			set => SetProperty(ref _bountyID, value);
		}
	}
}
