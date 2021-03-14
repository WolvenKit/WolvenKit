using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBreathingStateTransitionMetadata : audioAudioMetadata
	{
		private CArray<CName> _fromNames;
		private CName _toName;
		private CName _transitionStateName;
		private CEnum<audioBreathingTransitionType> _conditionType;
		private CEnum<audioBreathingTransitionComparator> _conditionComparator;
		private CName _value;
		private CArray<CEnum<audiobreathingEventTag>> _eventTags;
		private CBool _isImmediate;

		[Ordinal(1)] 
		[RED("fromNames")] 
		public CArray<CName> FromNames
		{
			get
			{
				if (_fromNames == null)
				{
					_fromNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "fromNames", cr2w, this);
				}
				return _fromNames;
			}
			set
			{
				if (_fromNames == value)
				{
					return;
				}
				_fromNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("toName")] 
		public CName ToName
		{
			get
			{
				if (_toName == null)
				{
					_toName = (CName) CR2WTypeManager.Create("CName", "toName", cr2w, this);
				}
				return _toName;
			}
			set
			{
				if (_toName == value)
				{
					return;
				}
				_toName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionStateName")] 
		public CName TransitionStateName
		{
			get
			{
				if (_transitionStateName == null)
				{
					_transitionStateName = (CName) CR2WTypeManager.Create("CName", "transitionStateName", cr2w, this);
				}
				return _transitionStateName;
			}
			set
			{
				if (_transitionStateName == value)
				{
					return;
				}
				_transitionStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("conditionType")] 
		public CEnum<audioBreathingTransitionType> ConditionType
		{
			get
			{
				if (_conditionType == null)
				{
					_conditionType = (CEnum<audioBreathingTransitionType>) CR2WTypeManager.Create("audioBreathingTransitionType", "conditionType", cr2w, this);
				}
				return _conditionType;
			}
			set
			{
				if (_conditionType == value)
				{
					return;
				}
				_conditionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("conditionComparator")] 
		public CEnum<audioBreathingTransitionComparator> ConditionComparator
		{
			get
			{
				if (_conditionComparator == null)
				{
					_conditionComparator = (CEnum<audioBreathingTransitionComparator>) CR2WTypeManager.Create("audioBreathingTransitionComparator", "conditionComparator", cr2w, this);
				}
				return _conditionComparator;
			}
			set
			{
				if (_conditionComparator == value)
				{
					return;
				}
				_conditionComparator = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("value")] 
		public CName Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CName) CR2WTypeManager.Create("CName", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("eventTags")] 
		public CArray<CEnum<audiobreathingEventTag>> EventTags
		{
			get
			{
				if (_eventTags == null)
				{
					_eventTags = (CArray<CEnum<audiobreathingEventTag>>) CR2WTypeManager.Create("array:audiobreathingEventTag", "eventTags", cr2w, this);
				}
				return _eventTags;
			}
			set
			{
				if (_eventTags == value)
				{
					return;
				}
				_eventTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isImmediate")] 
		public CBool IsImmediate
		{
			get
			{
				if (_isImmediate == null)
				{
					_isImmediate = (CBool) CR2WTypeManager.Create("Bool", "isImmediate", cr2w, this);
				}
				return _isImmediate;
			}
			set
			{
				if (_isImmediate == value)
				{
					return;
				}
				_isImmediate = value;
				PropertySet(this);
			}
		}

		public audioBreathingStateTransitionMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
