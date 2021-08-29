using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLookAtEventData : RedBaseClass
	{
		private CUInt32 _id;
		private CBool _enable;
		private CName _singleBodyPartName;
		private CName _singleTargetSlot;
		private CName _bodyTargetSlot;
		private CName _headTargetSlot;
		private CName _eyesTargetSlot;
		private CFloat _singleWeight;
		private CFloat _bodyWeight;
		private CFloat _headWeight;
		private CFloat _eyesWeight;
		private CBool _useSingleWeightCurve;
		private CBool _useBodyWeightCurve;
		private CBool _useHeadWeightCurve;
		private CBool _useEyesWeightCurve;
		private CLegacySingleChannelCurve<CFloat> _singleWeightCurve;
		private CLegacySingleChannelCurve<CFloat> _bodyWeightCurve;
		private CLegacySingleChannelCurve<CFloat> _headWeightCurve;
		private CLegacySingleChannelCurve<CFloat> _eyesWeightCurve;
		private animLookAtLimits _singleLimits;
		private animLookAtLimits _bodyLimits;
		private animLookAtLimits _headLimits;
		private animLookAtLimits _eyesLimits;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("singleBodyPartName")] 
		public CName SingleBodyPartName
		{
			get => GetProperty(ref _singleBodyPartName);
			set => SetProperty(ref _singleBodyPartName, value);
		}

		[Ordinal(3)] 
		[RED("singleTargetSlot")] 
		public CName SingleTargetSlot
		{
			get => GetProperty(ref _singleTargetSlot);
			set => SetProperty(ref _singleTargetSlot, value);
		}

		[Ordinal(4)] 
		[RED("bodyTargetSlot")] 
		public CName BodyTargetSlot
		{
			get => GetProperty(ref _bodyTargetSlot);
			set => SetProperty(ref _bodyTargetSlot, value);
		}

		[Ordinal(5)] 
		[RED("headTargetSlot")] 
		public CName HeadTargetSlot
		{
			get => GetProperty(ref _headTargetSlot);
			set => SetProperty(ref _headTargetSlot, value);
		}

		[Ordinal(6)] 
		[RED("eyesTargetSlot")] 
		public CName EyesTargetSlot
		{
			get => GetProperty(ref _eyesTargetSlot);
			set => SetProperty(ref _eyesTargetSlot, value);
		}

		[Ordinal(7)] 
		[RED("singleWeight")] 
		public CFloat SingleWeight
		{
			get => GetProperty(ref _singleWeight);
			set => SetProperty(ref _singleWeight, value);
		}

		[Ordinal(8)] 
		[RED("bodyWeight")] 
		public CFloat BodyWeight
		{
			get => GetProperty(ref _bodyWeight);
			set => SetProperty(ref _bodyWeight, value);
		}

		[Ordinal(9)] 
		[RED("headWeight")] 
		public CFloat HeadWeight
		{
			get => GetProperty(ref _headWeight);
			set => SetProperty(ref _headWeight, value);
		}

		[Ordinal(10)] 
		[RED("eyesWeight")] 
		public CFloat EyesWeight
		{
			get => GetProperty(ref _eyesWeight);
			set => SetProperty(ref _eyesWeight, value);
		}

		[Ordinal(11)] 
		[RED("useSingleWeightCurve")] 
		public CBool UseSingleWeightCurve
		{
			get => GetProperty(ref _useSingleWeightCurve);
			set => SetProperty(ref _useSingleWeightCurve, value);
		}

		[Ordinal(12)] 
		[RED("useBodyWeightCurve")] 
		public CBool UseBodyWeightCurve
		{
			get => GetProperty(ref _useBodyWeightCurve);
			set => SetProperty(ref _useBodyWeightCurve, value);
		}

		[Ordinal(13)] 
		[RED("useHeadWeightCurve")] 
		public CBool UseHeadWeightCurve
		{
			get => GetProperty(ref _useHeadWeightCurve);
			set => SetProperty(ref _useHeadWeightCurve, value);
		}

		[Ordinal(14)] 
		[RED("useEyesWeightCurve")] 
		public CBool UseEyesWeightCurve
		{
			get => GetProperty(ref _useEyesWeightCurve);
			set => SetProperty(ref _useEyesWeightCurve, value);
		}

		[Ordinal(15)] 
		[RED("singleWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> SingleWeightCurve
		{
			get => GetProperty(ref _singleWeightCurve);
			set => SetProperty(ref _singleWeightCurve, value);
		}

		[Ordinal(16)] 
		[RED("bodyWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> BodyWeightCurve
		{
			get => GetProperty(ref _bodyWeightCurve);
			set => SetProperty(ref _bodyWeightCurve, value);
		}

		[Ordinal(17)] 
		[RED("headWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> HeadWeightCurve
		{
			get => GetProperty(ref _headWeightCurve);
			set => SetProperty(ref _headWeightCurve, value);
		}

		[Ordinal(18)] 
		[RED("eyesWeightCurve")] 
		public CLegacySingleChannelCurve<CFloat> EyesWeightCurve
		{
			get => GetProperty(ref _eyesWeightCurve);
			set => SetProperty(ref _eyesWeightCurve, value);
		}

		[Ordinal(19)] 
		[RED("singleLimits")] 
		public animLookAtLimits SingleLimits
		{
			get => GetProperty(ref _singleLimits);
			set => SetProperty(ref _singleLimits, value);
		}

		[Ordinal(20)] 
		[RED("bodyLimits")] 
		public animLookAtLimits BodyLimits
		{
			get => GetProperty(ref _bodyLimits);
			set => SetProperty(ref _bodyLimits, value);
		}

		[Ordinal(21)] 
		[RED("headLimits")] 
		public animLookAtLimits HeadLimits
		{
			get => GetProperty(ref _headLimits);
			set => SetProperty(ref _headLimits, value);
		}

		[Ordinal(22)] 
		[RED("eyesLimits")] 
		public animLookAtLimits EyesLimits
		{
			get => GetProperty(ref _eyesLimits);
			set => SetProperty(ref _eyesLimits, value);
		}
	}
}
