using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateMachineConditionalEntry : ISerializable
	{
		private CUInt32 _targetStateIndex;
		private CHandle<animIAnimStateTransitionCondition> _condition;
		private CBool _isEnabled;
		private CInt32 _priority;
		private CBool _isForcedToTrue;

		[Ordinal(0)] 
		[RED("targetStateIndex")] 
		public CUInt32 TargetStateIndex
		{
			get
			{
				if (_targetStateIndex == null)
				{
					_targetStateIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "targetStateIndex", cr2w, this);
				}
				return _targetStateIndex;
			}
			set
			{
				if (_targetStateIndex == value)
				{
					return;
				}
				_targetStateIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIAnimStateTransitionCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<animIAnimStateTransitionCondition>) CR2WTypeManager.Create("handle:animIAnimStateTransitionCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
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

		[Ordinal(4)] 
		[RED("isForcedToTrue")] 
		public CBool IsForcedToTrue
		{
			get
			{
				if (_isForcedToTrue == null)
				{
					_isForcedToTrue = (CBool) CR2WTypeManager.Create("Bool", "isForcedToTrue", cr2w, this);
				}
				return _isForcedToTrue;
			}
			set
			{
				if (_isForcedToTrue == value)
				{
					return;
				}
				_isForcedToTrue = value;
				PropertySet(this);
			}
		}

		public animAnimStateMachineConditionalEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
