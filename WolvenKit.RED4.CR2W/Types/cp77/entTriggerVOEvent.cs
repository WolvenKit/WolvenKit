using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerVOEvent : redEvent
	{
		private CName _triggerBaseName;
		private CUInt32 _triggerVariationIndex;
		private CUInt32 _triggerVariationNumber;
		private CName _debugInitialContext;
		private CUInt64 _answeringEntityIDHash;
		private CBool _ignoreGlobalVoLimitCheck;
		private CEnum<locVoiceoverContext> _overridingVoContext;
		private CEnum<locVoiceoverExpression> _overridingVoiceoverExpression;
		private CBool _overrideVoiceoverExpression;
		private CUInt8 _overridingVisualStyleValue;
		private CBool _overrideVisualStyle;

		[Ordinal(0)] 
		[RED("triggerBaseName")] 
		public CName TriggerBaseName
		{
			get => GetProperty(ref _triggerBaseName);
			set => SetProperty(ref _triggerBaseName, value);
		}

		[Ordinal(1)] 
		[RED("triggerVariationIndex")] 
		public CUInt32 TriggerVariationIndex
		{
			get => GetProperty(ref _triggerVariationIndex);
			set => SetProperty(ref _triggerVariationIndex, value);
		}

		[Ordinal(2)] 
		[RED("triggerVariationNumber")] 
		public CUInt32 TriggerVariationNumber
		{
			get => GetProperty(ref _triggerVariationNumber);
			set => SetProperty(ref _triggerVariationNumber, value);
		}

		[Ordinal(3)] 
		[RED("debugInitialContext")] 
		public CName DebugInitialContext
		{
			get => GetProperty(ref _debugInitialContext);
			set => SetProperty(ref _debugInitialContext, value);
		}

		[Ordinal(4)] 
		[RED("answeringEntityIDHash")] 
		public CUInt64 AnsweringEntityIDHash
		{
			get => GetProperty(ref _answeringEntityIDHash);
			set => SetProperty(ref _answeringEntityIDHash, value);
		}

		[Ordinal(5)] 
		[RED("ignoreGlobalVoLimitCheck")] 
		public CBool IgnoreGlobalVoLimitCheck
		{
			get => GetProperty(ref _ignoreGlobalVoLimitCheck);
			set => SetProperty(ref _ignoreGlobalVoLimitCheck, value);
		}

		[Ordinal(6)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get => GetProperty(ref _overridingVoContext);
			set => SetProperty(ref _overridingVoContext, value);
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get => GetProperty(ref _overridingVoiceoverExpression);
			set => SetProperty(ref _overridingVoiceoverExpression, value);
		}

		[Ordinal(8)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get => GetProperty(ref _overrideVoiceoverExpression);
			set => SetProperty(ref _overrideVoiceoverExpression, value);
		}

		[Ordinal(9)] 
		[RED("overridingVisualStyleValue")] 
		public CUInt8 OverridingVisualStyleValue
		{
			get => GetProperty(ref _overridingVisualStyleValue);
			set => SetProperty(ref _overridingVisualStyleValue, value);
		}

		[Ordinal(10)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get => GetProperty(ref _overrideVisualStyle);
			set => SetProperty(ref _overrideVisualStyle, value);
		}

		public entTriggerVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
