using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpBumpEvent : redEvent
	{
		private CUInt32 _amount;

		[Ordinal(0)] 
		[RED("amount")] 
		public CUInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}
	}
}
