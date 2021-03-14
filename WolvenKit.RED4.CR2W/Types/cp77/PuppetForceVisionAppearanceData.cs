using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetForceVisionAppearanceData : IScriptable
	{
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private wCHandle<gamedataStim_Record> _stimRecord;
		private CFloat _transitionTime;
		private CEnum<EPriority> _priority;
		private CArray<wCHandle<ScriptedPuppet>> _targets;
		private CArray<wCHandle<ScriptedPuppet>> _highlightedTargets;
		private CInt32 _investigationSlots;
		private CBool _sourceHighlighted;
		private CString _effectName;
		private CBool _isInvalid;

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
		[RED("stimRecord")] 
		public wCHandle<gamedataStim_Record> StimRecord
		{
			get
			{
				if (_stimRecord == null)
				{
					_stimRecord = (wCHandle<gamedataStim_Record>) CR2WTypeManager.Create("whandle:gamedataStim_Record", "stimRecord", cr2w, this);
				}
				return _stimRecord;
			}
			set
			{
				if (_stimRecord == value)
				{
					return;
				}
				_stimRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get
			{
				if (_transitionTime == null)
				{
					_transitionTime = (CFloat) CR2WTypeManager.Create("Float", "transitionTime", cr2w, this);
				}
				return _transitionTime;
			}
			set
			{
				if (_transitionTime == value)
				{
					return;
				}
				_transitionTime = value;
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
		[RED("targets")] 
		public CArray<wCHandle<ScriptedPuppet>> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<wCHandle<ScriptedPuppet>>) CR2WTypeManager.Create("array:whandle:ScriptedPuppet", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("highlightedTargets")] 
		public CArray<wCHandle<ScriptedPuppet>> HighlightedTargets
		{
			get
			{
				if (_highlightedTargets == null)
				{
					_highlightedTargets = (CArray<wCHandle<ScriptedPuppet>>) CR2WTypeManager.Create("array:whandle:ScriptedPuppet", "highlightedTargets", cr2w, this);
				}
				return _highlightedTargets;
			}
			set
			{
				if (_highlightedTargets == value)
				{
					return;
				}
				_highlightedTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("investigationSlots")] 
		public CInt32 InvestigationSlots
		{
			get
			{
				if (_investigationSlots == null)
				{
					_investigationSlots = (CInt32) CR2WTypeManager.Create("Int32", "investigationSlots", cr2w, this);
				}
				return _investigationSlots;
			}
			set
			{
				if (_investigationSlots == value)
				{
					return;
				}
				_investigationSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sourceHighlighted")] 
		public CBool SourceHighlighted
		{
			get
			{
				if (_sourceHighlighted == null)
				{
					_sourceHighlighted = (CBool) CR2WTypeManager.Create("Bool", "sourceHighlighted", cr2w, this);
				}
				return _sourceHighlighted;
			}
			set
			{
				if (_sourceHighlighted == value)
				{
					return;
				}
				_sourceHighlighted = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("effectName")] 
		public CString EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CString) CR2WTypeManager.Create("String", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isInvalid")] 
		public CBool IsInvalid
		{
			get
			{
				if (_isInvalid == null)
				{
					_isInvalid = (CBool) CR2WTypeManager.Create("Bool", "isInvalid", cr2w, this);
				}
				return _isInvalid;
			}
			set
			{
				if (_isInvalid == value)
				{
					return;
				}
				_isInvalid = value;
				PropertySet(this);
			}
		}

		public PuppetForceVisionAppearanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
