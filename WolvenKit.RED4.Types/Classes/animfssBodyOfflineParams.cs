using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animfssBodyOfflineParams : RedBaseClass
	{
		private CFloat _hipsTilt;
		private CFloat _hipsShift;
		private CFloat _legsPullFactorMin;
		private CFloat _legsPullFactorMax;
		private CFloat _legLengthAdjustment;
		private CFloat _legMaxStretchOffset;
		private CFloat _legMaxStretchAdjustment;

		[Ordinal(0)] 
		[RED("HipsTilt")] 
		public CFloat HipsTilt
		{
			get => GetProperty(ref _hipsTilt);
			set => SetProperty(ref _hipsTilt, value);
		}

		[Ordinal(1)] 
		[RED("HipsShift")] 
		public CFloat HipsShift
		{
			get => GetProperty(ref _hipsShift);
			set => SetProperty(ref _hipsShift, value);
		}

		[Ordinal(2)] 
		[RED("LegsPullFactorMin")] 
		public CFloat LegsPullFactorMin
		{
			get => GetProperty(ref _legsPullFactorMin);
			set => SetProperty(ref _legsPullFactorMin, value);
		}

		[Ordinal(3)] 
		[RED("LegsPullFactorMax")] 
		public CFloat LegsPullFactorMax
		{
			get => GetProperty(ref _legsPullFactorMax);
			set => SetProperty(ref _legsPullFactorMax, value);
		}

		[Ordinal(4)] 
		[RED("LegLengthAdjustment")] 
		public CFloat LegLengthAdjustment
		{
			get => GetProperty(ref _legLengthAdjustment);
			set => SetProperty(ref _legLengthAdjustment, value);
		}

		[Ordinal(5)] 
		[RED("LegMaxStretchOffset")] 
		public CFloat LegMaxStretchOffset
		{
			get => GetProperty(ref _legMaxStretchOffset);
			set => SetProperty(ref _legMaxStretchOffset, value);
		}

		[Ordinal(6)] 
		[RED("LegMaxStretchAdjustment")] 
		public CFloat LegMaxStretchAdjustment
		{
			get => GetProperty(ref _legMaxStretchAdjustment);
			set => SetProperty(ref _legMaxStretchAdjustment, value);
		}

		public animfssBodyOfflineParams()
		{
			_hipsTilt = 25.000000F;
			_hipsShift = 0.100000F;
			_legsPullFactorMin = 0.050000F;
			_legsPullFactorMax = 0.165000F;
			_legLengthAdjustment = 0.005000F;
			_legMaxStretchOffset = 0.050000F;
			_legMaxStretchAdjustment = 0.015000F;
		}
	}
}
