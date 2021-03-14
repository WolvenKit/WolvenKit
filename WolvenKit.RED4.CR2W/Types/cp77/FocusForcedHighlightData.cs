using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusForcedHighlightData : IScriptable
	{
		private entEntityID _sourceID;
		private CName _sourceName;
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private CEnum<EPriority> _priority;
		private CFloat _inTransitionTime;
		private CFloat _outTransitionTime;
		private CHandle<HighlightInstance> _hudData;
		private CBool _isRevealed;
		private CBool _isSavable;
		private CEnum<gameVisionModePatternType> _patternType;

		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get
			{
				if (_sourceID == null)
				{
					_sourceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "sourceID", cr2w, this);
				}
				return _sourceID;
			}
			set
			{
				if (_sourceID == value)
				{
					return;
				}
				_sourceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("hudData")] 
		public CHandle<HighlightInstance> HudData
		{
			get
			{
				if (_hudData == null)
				{
					_hudData = (CHandle<HighlightInstance>) CR2WTypeManager.Create("handle:HighlightInstance", "hudData", cr2w, this);
				}
				return _hudData;
			}
			set
			{
				if (_hudData == value)
				{
					return;
				}
				_hudData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("isSavable")] 
		public CBool IsSavable
		{
			get
			{
				if (_isSavable == null)
				{
					_isSavable = (CBool) CR2WTypeManager.Create("Bool", "isSavable", cr2w, this);
				}
				return _isSavable;
			}
			set
			{
				if (_isSavable == value)
				{
					return;
				}
				_isSavable = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		public FocusForcedHighlightData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
