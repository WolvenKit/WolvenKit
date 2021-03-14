using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightEditableData : IScriptable
	{
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private CEnum<EPriority> _priority;
		private CFloat _inTransitionTime;
		private CFloat _outTransitionTime;
		private CBool _isRevealed;
		private CEnum<gameVisionModePatternType> _patternType;

		[Ordinal(0)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get
			{
				if (_highlightType == null)
				{
					_highlightType = (CEnum<EFocusForcedHighlightType>) CR2WTypeManager.Create("EFocusForcedHighlightType", "highlightType", cr2w, this);
				}
				return _highlightType;
			}
			set
			{
				if (_highlightType == value)
				{
					return;
				}
				_highlightType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get
			{
				if (_outlineType == null)
				{
					_outlineType = (CEnum<EFocusOutlineType>) CR2WTypeManager.Create("EFocusOutlineType", "outlineType", cr2w, this);
				}
				return _outlineType;
			}
			set
			{
				if (_outlineType == value)
				{
					return;
				}
				_outlineType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CEnum<EPriority>) CR2WTypeManager.Create("EPriority", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inTransitionTime")] 
		public CFloat InTransitionTime
		{
			get
			{
				if (_inTransitionTime == null)
				{
					_inTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "inTransitionTime", cr2w, this);
				}
				return _inTransitionTime;
			}
			set
			{
				if (_inTransitionTime == value)
				{
					return;
				}
				_inTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outTransitionTime")] 
		public CFloat OutTransitionTime
		{
			get
			{
				if (_outTransitionTime == null)
				{
					_outTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "outTransitionTime", cr2w, this);
				}
				return _outTransitionTime;
			}
			set
			{
				if (_outTransitionTime == value)
				{
					return;
				}
				_outTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get
			{
				if (_isRevealed == null)
				{
					_isRevealed = (CBool) CR2WTypeManager.Create("Bool", "isRevealed", cr2w, this);
				}
				return _isRevealed;
			}
			set
			{
				if (_isRevealed == value)
				{
					return;
				}
				_isRevealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get
			{
				if (_patternType == null)
				{
					_patternType = (CEnum<gameVisionModePatternType>) CR2WTypeManager.Create("gameVisionModePatternType", "patternType", cr2w, this);
				}
				return _patternType;
			}
			set
			{
				if (_patternType == value)
				{
					return;
				}
				_patternType = value;
				PropertySet(this);
			}
		}

		public HighlightEditableData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
