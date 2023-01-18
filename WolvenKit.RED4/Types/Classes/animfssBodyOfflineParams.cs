using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animfssBodyOfflineParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("HipsTilt")] 
		public CFloat HipsTilt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("HipsShift")] 
		public CFloat HipsShift
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("LegsPullFactorMin")] 
		public CFloat LegsPullFactorMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("LegsPullFactorMax")] 
		public CFloat LegsPullFactorMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("LegLengthAdjustment")] 
		public CFloat LegLengthAdjustment
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("LegMaxStretchOffset")] 
		public CFloat LegMaxStretchOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("LegMaxStretchAdjustment")] 
		public CFloat LegMaxStretchAdjustment
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animfssBodyOfflineParams()
		{
			HipsTilt = 25.000000F;
			HipsShift = 0.100000F;
			LegsPullFactorMin = 0.050000F;
			LegsPullFactorMax = 0.165000F;
			LegLengthAdjustment = 0.005000F;
			LegMaxStretchOffset = 0.050000F;
			LegMaxStretchAdjustment = 0.015000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
