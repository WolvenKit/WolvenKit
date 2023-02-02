using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("singleBodyPartName")] 
		public CName SingleBodyPartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("singleTargetSlot")] 
		public CName SingleTargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("bodyTargetSlot")] 
		public CName BodyTargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("headTargetSlot")] 
		public CName HeadTargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("eyesTargetSlot")] 
		public CName EyesTargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("singleWeight")] 
		public CFloat SingleWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("bodyWeight")] 
		public CFloat BodyWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("headWeight")] 
		public CFloat HeadWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("eyesWeight")] 
		public CFloat EyesWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("useSingleWeightCurve")] 
		public CBool UseSingleWeightCurve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useBodyWeightCurve")] 
		public CBool UseBodyWeightCurve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useHeadWeightCurve")] 
		public CBool UseHeadWeightCurve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("useEyesWeightCurve")] 
		public CBool UseEyesWeightCurve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("singleWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> SingleWeightCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(16)] 
		[RED("bodyWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> BodyWeightCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("headWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> HeadWeightCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(18)] 
		[RED("eyesWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> EyesWeightCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("singleLimits")] 
		public animLookAtLimits SingleLimits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		[Ordinal(20)] 
		[RED("bodyLimits")] 
		public animLookAtLimits BodyLimits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		[Ordinal(21)] 
		[RED("headLimits")] 
		public animLookAtLimits HeadLimits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		[Ordinal(22)] 
		[RED("eyesLimits")] 
		public animLookAtLimits EyesLimits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		public scnLookAtEventData()
		{
			Id = 4294967295;
			Enable = true;
			SingleWeight = 1.000000F;
			BodyWeight = 1.000000F;
			HeadWeight = 1.000000F;
			EyesWeight = 1.000000F;
			SingleLimits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F };
			BodyLimits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F };
			HeadLimits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F };
			EyesLimits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
