using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPlaybackOptions : RedBaseClass
	{
		private CBool _playReversed;
		private CEnum<inkanimLoopType> _loopType;
		private CUInt32 _loopCounter;
		private CFloat _executionDelay;
		private CBool _loopInfinite;
		private CName _fromMarker;
		private CName _toMarker;
		private CBool _oneSegment;
		private CBool _dependsOnTimeDilation;

		[Ordinal(0)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get => GetProperty(ref _playReversed);
			set => SetProperty(ref _playReversed, value);
		}

		[Ordinal(1)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		[Ordinal(2)] 
		[RED("loopCounter")] 
		public CUInt32 LoopCounter
		{
			get => GetProperty(ref _loopCounter);
			set => SetProperty(ref _loopCounter, value);
		}

		[Ordinal(3)] 
		[RED("executionDelay")] 
		public CFloat ExecutionDelay
		{
			get => GetProperty(ref _executionDelay);
			set => SetProperty(ref _executionDelay, value);
		}

		[Ordinal(4)] 
		[RED("loopInfinite")] 
		public CBool LoopInfinite
		{
			get => GetProperty(ref _loopInfinite);
			set => SetProperty(ref _loopInfinite, value);
		}

		[Ordinal(5)] 
		[RED("fromMarker")] 
		public CName FromMarker
		{
			get => GetProperty(ref _fromMarker);
			set => SetProperty(ref _fromMarker, value);
		}

		[Ordinal(6)] 
		[RED("toMarker")] 
		public CName ToMarker
		{
			get => GetProperty(ref _toMarker);
			set => SetProperty(ref _toMarker, value);
		}

		[Ordinal(7)] 
		[RED("oneSegment")] 
		public CBool OneSegment
		{
			get => GetProperty(ref _oneSegment);
			set => SetProperty(ref _oneSegment, value);
		}

		[Ordinal(8)] 
		[RED("dependsOnTimeDilation")] 
		public CBool DependsOnTimeDilation
		{
			get => GetProperty(ref _dependsOnTimeDilation);
			set => SetProperty(ref _dependsOnTimeDilation, value);
		}
	}
}
