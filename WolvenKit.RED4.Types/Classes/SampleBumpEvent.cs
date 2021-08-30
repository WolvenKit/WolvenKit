using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleBumpEvent : redEvent
	{
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public SampleBumpEvent()
		{
			_amount = 1;
		}
	}
}
