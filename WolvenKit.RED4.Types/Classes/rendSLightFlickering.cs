using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendSLightFlickering : RedBaseClass
	{
		private CFloat _positionOffset;
		private CFloat _flickerStrength;
		private CFloat _flickerPeriod;

		[Ordinal(0)] 
		[RED("positionOffset")] 
		public CFloat PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}

		[Ordinal(1)] 
		[RED("flickerStrength")] 
		public CFloat FlickerStrength
		{
			get => GetProperty(ref _flickerStrength);
			set => SetProperty(ref _flickerStrength, value);
		}

		[Ordinal(2)] 
		[RED("flickerPeriod")] 
		public CFloat FlickerPeriod
		{
			get => GetProperty(ref _flickerPeriod);
			set => SetProperty(ref _flickerPeriod, value);
		}
	}
}
