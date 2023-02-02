using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STransformAnimationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<ETransformAnimationOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<ETransformAnimationOperationType>>();
			set => SetPropertyValue<CEnum<ETransformAnimationOperationType>>(value);
		}

		[Ordinal(2)] 
		[RED("playData")] 
		public STransformAnimationPlayEventData PlayData
		{
			get => GetPropertyValue<STransformAnimationPlayEventData>();
			set => SetPropertyValue<STransformAnimationPlayEventData>(value);
		}

		[Ordinal(3)] 
		[RED("skipData")] 
		public STransformAnimationSkipEventData SkipData
		{
			get => GetPropertyValue<STransformAnimationSkipEventData>();
			set => SetPropertyValue<STransformAnimationSkipEventData>(value);
		}

		public STransformAnimationData()
		{
			PlayData = new() { TimeScale = 1.000000F, TimesPlayed = 1 };
			SkipData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
