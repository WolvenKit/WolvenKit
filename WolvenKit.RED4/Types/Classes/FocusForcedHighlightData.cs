using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FocusForcedHighlightData : IScriptable
	{
		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetPropertyValue<CEnum<EFocusForcedHighlightType>>();
			set => SetPropertyValue<CEnum<EFocusForcedHighlightType>>(value);
		}

		[Ordinal(3)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetPropertyValue<CEnum<EFocusOutlineType>>();
			set => SetPropertyValue<CEnum<EFocusOutlineType>>(value);
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetPropertyValue<CEnum<EPriority>>();
			set => SetPropertyValue<CEnum<EPriority>>(value);
		}

		[Ordinal(5)] 
		[RED("inTransitionTime")] 
		public CFloat InTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("outTransitionTime")] 
		public CFloat OutTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("hudData")] 
		public CHandle<HighlightInstance> HudData
		{
			get => GetPropertyValue<CHandle<HighlightInstance>>();
			set => SetPropertyValue<CHandle<HighlightInstance>>(value);
		}

		[Ordinal(8)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isSavable")] 
		public CBool IsSavable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get => GetPropertyValue<CEnum<gameVisionModePatternType>>();
			set => SetPropertyValue<CEnum<gameVisionModePatternType>>(value);
		}

		public FocusForcedHighlightData()
		{
			SourceID = new entEntityID();
			OutlineType = Enums.EFocusOutlineType.INVALID;
			InTransitionTime = 0.500000F;
			OutTransitionTime = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
