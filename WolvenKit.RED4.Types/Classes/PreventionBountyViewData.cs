using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionBountyViewData : gameuiGenericNotificationViewData
	{
		private CBool _canBeMerged;
		private CString _bountyTitle;
		private CInt32 _bountyPrice;

		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		[Ordinal(6)] 
		[RED("bountyTitle")] 
		public CString BountyTitle
		{
			get => GetProperty(ref _bountyTitle);
			set => SetProperty(ref _bountyTitle, value);
		}

		[Ordinal(7)] 
		[RED("bountyPrice")] 
		public CInt32 BountyPrice
		{
			get => GetProperty(ref _bountyPrice);
			set => SetProperty(ref _bountyPrice, value);
		}
	}
}
