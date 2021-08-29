using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entGameplayVOEvent : redEvent
	{
		private CName _voContext;
		private CBool _isQuest;
		private CBool _ignoreFrustumCheck;
		private CBool _ignoreDistanceCheck;
		private CName _debugInitialContext;
		private CBool _ignoreGlobalVoLimitCheck;
		private entEntityID _answeringEntityId;
		private CEnum<locVoiceoverContext> _overridingVoiceoverContext;
		private CEnum<locVoiceoverExpression> _overridingVoiceoverExpression;
		private CBool _overrideVoiceoverExpression;
		private CUInt8 _overridingVisualStyleValue;
		private CBool _overrideVisualStyle;

		[Ordinal(0)] 
		[RED("voContext")] 
		public CName VoContext
		{
			get => GetProperty(ref _voContext);
			set => SetProperty(ref _voContext, value);
		}

		[Ordinal(1)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get => GetProperty(ref _isQuest);
			set => SetProperty(ref _isQuest, value);
		}

		[Ordinal(2)] 
		[RED("ignoreFrustumCheck")] 
		public CBool IgnoreFrustumCheck
		{
			get => GetProperty(ref _ignoreFrustumCheck);
			set => SetProperty(ref _ignoreFrustumCheck, value);
		}

		[Ordinal(3)] 
		[RED("ignoreDistanceCheck")] 
		public CBool IgnoreDistanceCheck
		{
			get => GetProperty(ref _ignoreDistanceCheck);
			set => SetProperty(ref _ignoreDistanceCheck, value);
		}

		[Ordinal(4)] 
		[RED("debugInitialContext")] 
		public CName DebugInitialContext
		{
			get => GetProperty(ref _debugInitialContext);
			set => SetProperty(ref _debugInitialContext, value);
		}

		[Ordinal(5)] 
		[RED("ignoreGlobalVoLimitCheck")] 
		public CBool IgnoreGlobalVoLimitCheck
		{
			get => GetProperty(ref _ignoreGlobalVoLimitCheck);
			set => SetProperty(ref _ignoreGlobalVoLimitCheck, value);
		}

		[Ordinal(6)] 
		[RED("answeringEntityId")] 
		public entEntityID AnsweringEntityId
		{
			get => GetProperty(ref _answeringEntityId);
			set => SetProperty(ref _answeringEntityId, value);
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverContext")] 
		public CEnum<locVoiceoverContext> OverridingVoiceoverContext
		{
			get => GetProperty(ref _overridingVoiceoverContext);
			set => SetProperty(ref _overridingVoiceoverContext, value);
		}

		[Ordinal(8)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get => GetProperty(ref _overridingVoiceoverExpression);
			set => SetProperty(ref _overridingVoiceoverExpression, value);
		}

		[Ordinal(9)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get => GetProperty(ref _overrideVoiceoverExpression);
			set => SetProperty(ref _overrideVoiceoverExpression, value);
		}

		[Ordinal(10)] 
		[RED("overridingVisualStyleValue")] 
		public CUInt8 OverridingVisualStyleValue
		{
			get => GetProperty(ref _overridingVisualStyleValue);
			set => SetProperty(ref _overridingVisualStyleValue, value);
		}

		[Ordinal(11)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get => GetProperty(ref _overrideVisualStyle);
			set => SetProperty(ref _overrideVisualStyle, value);
		}
	}
}
