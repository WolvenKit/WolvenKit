using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTriggerVOEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("triggerBaseName")] 
		public CName TriggerBaseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("triggerVariationIndex")] 
		public CUInt32 TriggerVariationIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("triggerVariationNumber")] 
		public CUInt32 TriggerVariationNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("debugInitialContext")] 
		public CName DebugInitialContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("answeringEntityIDHash")] 
		public CUInt64 AnsweringEntityIDHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreGlobalVoLimitCheck")] 
		public CBool IgnoreGlobalVoLimitCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get => GetPropertyValue<CEnum<locVoiceoverExpression>>();
			set => SetPropertyValue<CEnum<locVoiceoverExpression>>(value);
		}

		[Ordinal(8)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("overridingVisualStyleValue")] 
		public CUInt8 OverridingVisualStyleValue
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(10)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entTriggerVOEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
