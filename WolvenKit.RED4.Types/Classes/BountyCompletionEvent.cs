using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BountyCompletionEvent : redEvent
	{
		private CInt32 _streetCredAwarded;
		private CInt32 _moneyAwarded;

		[Ordinal(0)] 
		[RED("streetCredAwarded")] 
		public CInt32 StreetCredAwarded
		{
			get => GetProperty(ref _streetCredAwarded);
			set => SetProperty(ref _streetCredAwarded, value);
		}

		[Ordinal(1)] 
		[RED("moneyAwarded")] 
		public CInt32 MoneyAwarded
		{
			get => GetProperty(ref _moneyAwarded);
			set => SetProperty(ref _moneyAwarded, value);
		}
	}
}
