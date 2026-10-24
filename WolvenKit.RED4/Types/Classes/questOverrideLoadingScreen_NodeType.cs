using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questOverrideLoadingScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(1)] 
		[RED("videos")] 
		public CArray<CResourceAsyncReference<Bink>> Videos
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<Bink>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<Bink>>>(value);
		}

		[Ordinal(2)] 
		[RED("minimumPlayCount")] 
		public CUInt32 MinimumPlayCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("tooltips")] 
		public CArray<CString> Tooltips
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(5)] 
		[RED("tooltipDuration")] 
		public CFloat TooltipDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("glitchEffectTime")] 
		public CFloat GlitchEffectTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("keepLoadingScreenWhileVideoIsPlaying")] 
		public CBool KeepLoadingScreenWhileVideoIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questOverrideLoadingScreen_NodeType()
		{
			Videos = new() { null };
			MinimumPlayCount = 3;
			Tooltips = new();
			TooltipDuration = 1.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
