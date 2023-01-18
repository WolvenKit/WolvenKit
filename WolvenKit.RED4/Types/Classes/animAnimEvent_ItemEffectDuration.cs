using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_ItemEffectDuration : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("breakAllLoopsOnStop")] 
		public CBool BreakAllLoopsOnStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimEvent_ItemEffectDuration()
		{
			DurationInFrames = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
