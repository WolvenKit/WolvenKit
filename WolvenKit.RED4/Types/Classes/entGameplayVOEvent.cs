using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entGameplayVOEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("voContext")] 
		public CName VoContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreFrustumCheck")] 
		public CBool IgnoreFrustumCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ignoreDistanceCheck")] 
		public CBool IgnoreDistanceCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("debugInitialContext")] 
		public CName DebugInitialContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreGlobalVoLimitCheck")] 
		public CBool IgnoreGlobalVoLimitCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("answeringEntityId")] 
		public entEntityID AnsweringEntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverContext")] 
		public CEnum<locVoiceoverContext> OverridingVoiceoverContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(8)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get => GetPropertyValue<CEnum<locVoiceoverExpression>>();
			set => SetPropertyValue<CEnum<locVoiceoverExpression>>(value);
		}

		[Ordinal(9)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("overridingVisualStyleValue")] 
		public CUInt8 OverridingVisualStyleValue
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(11)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entGameplayVOEvent()
		{
			AnsweringEntityId = new entEntityID();
			OverridingVoiceoverContext = Enums.locVoiceoverContext.Default_Vo_Context;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
