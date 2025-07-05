using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimPlaybackOptions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetPropertyValue<CEnum<inkanimLoopType>>();
			set => SetPropertyValue<CEnum<inkanimLoopType>>(value);
		}

		[Ordinal(2)] 
		[RED("loopCounter")] 
		public CUInt32 LoopCounter
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("executionDelay")] 
		public CFloat ExecutionDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("loopInfinite")] 
		public CBool LoopInfinite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("fromMarker")] 
		public CName FromMarker
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("toMarker")] 
		public CName ToMarker
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("oneSegment")] 
		public CBool OneSegment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("dependsOnTimeDilation")] 
		public CBool DependsOnTimeDilation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("applyCustomTimeDilation")] 
		public CBool ApplyCustomTimeDilation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("customTimeDilation")] 
		public CFloat CustomTimeDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkanimPlaybackOptions()
		{
			CustomTimeDilation = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
