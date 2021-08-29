using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIGuardAreaConnectedCommunity : RedBaseClass
	{
		private gameEntityReference _communityArea;
		private CBool _isPrimary;

		[Ordinal(0)] 
		[RED("communityArea")] 
		public gameEntityReference CommunityArea
		{
			get => GetProperty(ref _communityArea);
			set => SetProperty(ref _communityArea, value);
		}

		[Ordinal(1)] 
		[RED("isPrimary")] 
		public CBool IsPrimary
		{
			get => GetProperty(ref _isPrimary);
			set => SetProperty(ref _isPrimary, value);
		}
	}
}
