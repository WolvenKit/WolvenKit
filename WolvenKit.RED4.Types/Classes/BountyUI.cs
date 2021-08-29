using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BountyUI : RedBaseClass
	{
		private CString _issuedBy;
		private CInt32 _moneyReward;
		private CInt32 _streetCredReward;
		private CArray<CString> _transgressions;
		private CBool _hasAccess;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("issuedBy")] 
		public CString IssuedBy
		{
			get => GetProperty(ref _issuedBy);
			set => SetProperty(ref _issuedBy, value);
		}

		[Ordinal(1)] 
		[RED("moneyReward")] 
		public CInt32 MoneyReward
		{
			get => GetProperty(ref _moneyReward);
			set => SetProperty(ref _moneyReward, value);
		}

		[Ordinal(2)] 
		[RED("streetCredReward")] 
		public CInt32 StreetCredReward
		{
			get => GetProperty(ref _streetCredReward);
			set => SetProperty(ref _streetCredReward, value);
		}

		[Ordinal(3)] 
		[RED("transgressions")] 
		public CArray<CString> Transgressions
		{
			get => GetProperty(ref _transgressions);
			set => SetProperty(ref _transgressions, value);
		}

		[Ordinal(4)] 
		[RED("hasAccess")] 
		public CBool HasAccess
		{
			get => GetProperty(ref _hasAccess);
			set => SetProperty(ref _hasAccess, value);
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}
	}
}
