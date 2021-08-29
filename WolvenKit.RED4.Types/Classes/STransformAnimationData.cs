using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STransformAnimationData : RedBaseClass
	{
		private CName _animationName;
		private CEnum<ETransformAnimationOperationType> _operationType;
		private STransformAnimationPlayEventData _playData;
		private STransformAnimationSkipEventData _skipData;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<ETransformAnimationOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(2)] 
		[RED("playData")] 
		public STransformAnimationPlayEventData PlayData
		{
			get => GetProperty(ref _playData);
			set => SetProperty(ref _playData, value);
		}

		[Ordinal(3)] 
		[RED("skipData")] 
		public STransformAnimationSkipEventData SkipData
		{
			get => GetProperty(ref _skipData);
			set => SetProperty(ref _skipData, value);
		}
	}
}
