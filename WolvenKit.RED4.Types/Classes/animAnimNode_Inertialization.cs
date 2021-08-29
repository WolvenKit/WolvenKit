using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Inertialization : animAnimNode_OnePoseInput
	{
		private CBool _safeMode;
		private CUInt32 _transformsCountUpperBound;
		private CUInt32 _tracksCountUpperBound;
		private CArray<animInertializationRotationLimit> _rotationLimits;

		[Ordinal(12)] 
		[RED("safeMode")] 
		public CBool SafeMode
		{
			get => GetProperty(ref _safeMode);
			set => SetProperty(ref _safeMode, value);
		}

		[Ordinal(13)] 
		[RED("transformsCountUpperBound")] 
		public CUInt32 TransformsCountUpperBound
		{
			get => GetProperty(ref _transformsCountUpperBound);
			set => SetProperty(ref _transformsCountUpperBound, value);
		}

		[Ordinal(14)] 
		[RED("tracksCountUpperBound")] 
		public CUInt32 TracksCountUpperBound
		{
			get => GetProperty(ref _tracksCountUpperBound);
			set => SetProperty(ref _tracksCountUpperBound, value);
		}

		[Ordinal(15)] 
		[RED("rotationLimits")] 
		public CArray<animInertializationRotationLimit> RotationLimits
		{
			get => GetProperty(ref _rotationLimits);
			set => SetProperty(ref _rotationLimits, value);
		}
	}
}
