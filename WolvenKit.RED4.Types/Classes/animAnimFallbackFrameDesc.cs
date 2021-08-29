using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFallbackFrameDesc : RedBaseClass
	{
		private CUInt16 _mPositions;
		private CUInt16 _mRotations;

		[Ordinal(0)] 
		[RED("mPositions")] 
		public CUInt16 MPositions
		{
			get => GetProperty(ref _mPositions);
			set => SetProperty(ref _mPositions, value);
		}

		[Ordinal(1)] 
		[RED("mRotations")] 
		public CUInt16 MRotations
		{
			get => GetProperty(ref _mRotations);
			set => SetProperty(ref _mRotations, value);
		}
	}
}
