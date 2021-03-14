using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioStateTransitionData : CVariable
	{
		private CUInt8 _targetStateId;
		private CBool _allConditionsFulfilled;
		private CFloat _transitionTime;
		private CFloat _exitTime;
		private CName _exitSignal;
		private CArray<audioAudioSceneVariableReadActionData> _readVariableActions;
		private CArray<CName> _conditions;

		[Ordinal(0)] 
		[RED("targetStateId")] 
		public CUInt8 TargetStateId
		{
			get
			{
				if (_targetStateId == null)
				{
					_targetStateId = (CUInt8) CR2WTypeManager.Create("Uint8", "targetStateId", cr2w, this);
				}
				return _targetStateId;
			}
			set
			{
				if (_targetStateId == value)
				{
					return;
				}
				_targetStateId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("allConditionsFulfilled")] 
		public CBool AllConditionsFulfilled
		{
			get
			{
				if (_allConditionsFulfilled == null)
				{
					_allConditionsFulfilled = (CBool) CR2WTypeManager.Create("Bool", "allConditionsFulfilled", cr2w, this);
				}
				return _allConditionsFulfilled;
			}
			set
			{
				if (_allConditionsFulfilled == value)
				{
					return;
				}
				_allConditionsFulfilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("exitTime")] 
		public CFloat ExitTime
		{
			get
			{
				if (_exitTime == null)
				{
					_exitTime = (CFloat) CR2WTypeManager.Create("Float", "exitTime", cr2w, this);
				}
				return _exitTime;
			}
			set
			{
				if (_exitTime == value)
				{
					return;
				}
				_exitTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exitSignal")] 
		public CName ExitSignal
		{
			get
			{
				if (_exitSignal == null)
				{
					_exitSignal = (CName) CR2WTypeManager.Create("CName", "exitSignal", cr2w, this);
				}
				return _exitSignal;
			}
			set
			{
				if (_exitSignal == value)
				{
					return;
				}
				_exitSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("readVariableActions")] 
		public CArray<audioAudioSceneVariableReadActionData> ReadVariableActions
		{
			get
			{
				if (_readVariableActions == null)
				{
					_readVariableActions = (CArray<audioAudioSceneVariableReadActionData>) CR2WTypeManager.Create("array:audioAudioSceneVariableReadActionData", "readVariableActions", cr2w, this);
				}
				return _readVariableActions;
			}
			set
			{
				if (_readVariableActions == value)
				{
					return;
				}
				_readVariableActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("conditions")] 
		public CArray<CName> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "conditions", cr2w, this);
				}
				return _conditions;
			}
			set
			{
				if (_conditions == value)
				{
					return;
				}
				_conditions = value;
				PropertySet(this);
			}
		}

		public audioAudioStateTransitionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
