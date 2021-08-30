using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTransformHistoryComponent : entIComponent
	{
		private CFloat _historyLength;
		private CUInt32 _samplesAmount;

		[Ordinal(3)] 
		[RED("historyLength")] 
		public CFloat HistoryLength
		{
			get => GetProperty(ref _historyLength);
			set => SetProperty(ref _historyLength, value);
		}

		[Ordinal(4)] 
		[RED("samplesAmount")] 
		public CUInt32 SamplesAmount
		{
			get => GetProperty(ref _samplesAmount);
			set => SetProperty(ref _samplesAmount, value);
		}

		public entTransformHistoryComponent()
		{
			_historyLength = 30.000000F;
			_samplesAmount = 60;
		}
	}
}
