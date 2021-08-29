using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinfluenceHeatAgent : gameinfluenceIAgent
	{
		private CFloat _timeToNextUpdate;
		private CFloat _heatRadius;
		private CFloat _heatValue;

		[Ordinal(0)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetProperty(ref _timeToNextUpdate);
			set => SetProperty(ref _timeToNextUpdate, value);
		}

		[Ordinal(1)] 
		[RED("heatRadius")] 
		public CFloat HeatRadius
		{
			get => GetProperty(ref _heatRadius);
			set => SetProperty(ref _heatRadius, value);
		}

		[Ordinal(2)] 
		[RED("heatValue")] 
		public CFloat HeatValue
		{
			get => GetProperty(ref _heatValue);
			set => SetProperty(ref _heatValue, value);
		}
	}
}
