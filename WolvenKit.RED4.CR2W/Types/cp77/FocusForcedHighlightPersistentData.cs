using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusForcedHighlightPersistentData : IScriptable
	{
		private entEntityID _sourceID;
		private CName _sourceName;
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private CEnum<EPriority> _priority;
		private CFloat _inTransitionTime;
		private CFloat _outTransitionTime;
		private CBool _isRevealed;
		private CEnum<gameVisionModePatternType> _patternType;

		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetProperty(ref _sourceID);
			set => SetProperty(ref _sourceID, value);
		}

		[Ordinal(1)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(2)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetProperty(ref _highlightType);
			set => SetProperty(ref _highlightType, value);
		}

		[Ordinal(3)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(5)] 
		[RED("inTransitionTime")] 
		public CFloat InTransitionTime
		{
			get => GetProperty(ref _inTransitionTime);
			set => SetProperty(ref _inTransitionTime, value);
		}

		[Ordinal(6)] 
		[RED("outTransitionTime")] 
		public CFloat OutTransitionTime
		{
			get => GetProperty(ref _outTransitionTime);
			set => SetProperty(ref _outTransitionTime, value);
		}

		[Ordinal(7)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetProperty(ref _isRevealed);
			set => SetProperty(ref _isRevealed, value);
		}

		[Ordinal(8)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get => GetProperty(ref _patternType);
			set => SetProperty(ref _patternType, value);
		}

		public FocusForcedHighlightPersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
