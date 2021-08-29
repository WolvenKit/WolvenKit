using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleHornProbsEvent : redEvent
	{
		private CFloat _honkMinTime;
		private CFloat _honkMaxTime;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("honkMinTime")] 
		public CFloat HonkMinTime
		{
			get => GetProperty(ref _honkMinTime);
			set => SetProperty(ref _honkMinTime, value);
		}

		[Ordinal(1)] 
		[RED("honkMaxTime")] 
		public CFloat HonkMaxTime
		{
			get => GetProperty(ref _honkMaxTime);
			set => SetProperty(ref _honkMaxTime, value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}
	}
}
