using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioStateData : CVariable
	{
		private CName _stateName;
		private CName _enterEvent;
		private CName _exitEvent;
		private CArray<audioAudioStateTransitionData> _exitTransitions;
		private CArray<audioMixingActionData> _mixingActions;
		private CArray<CName> _interruptionSources;
		private CArray<audioAudioSceneVariableWriteActionData> _writeVariableActions;

		[Ordinal(0)] 
		[RED("stateName")] 
		public CName StateName
		{
			get
			{
				if (_stateName == null)
				{
					_stateName = (CName) CR2WTypeManager.Create("CName", "stateName", cr2w, this);
				}
				return _stateName;
			}
			set
			{
				if (_stateName == value)
				{
					return;
				}
				_stateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get
			{
				if (_enterEvent == null)
				{
					_enterEvent = (CName) CR2WTypeManager.Create("CName", "enterEvent", cr2w, this);
				}
				return _enterEvent;
			}
			set
			{
				if (_enterEvent == value)
				{
					return;
				}
				_enterEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get
			{
				if (_exitEvent == null)
				{
					_exitEvent = (CName) CR2WTypeManager.Create("CName", "exitEvent", cr2w, this);
				}
				return _exitEvent;
			}
			set
			{
				if (_exitEvent == value)
				{
					return;
				}
				_exitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exitTransitions")] 
		public CArray<audioAudioStateTransitionData> ExitTransitions
		{
			get
			{
				if (_exitTransitions == null)
				{
					_exitTransitions = (CArray<audioAudioStateTransitionData>) CR2WTypeManager.Create("array:audioAudioStateTransitionData", "exitTransitions", cr2w, this);
				}
				return _exitTransitions;
			}
			set
			{
				if (_exitTransitions == value)
				{
					return;
				}
				_exitTransitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mixingActions")] 
		public CArray<audioMixingActionData> MixingActions
		{
			get
			{
				if (_mixingActions == null)
				{
					_mixingActions = (CArray<audioMixingActionData>) CR2WTypeManager.Create("array:audioMixingActionData", "mixingActions", cr2w, this);
				}
				return _mixingActions;
			}
			set
			{
				if (_mixingActions == value)
				{
					return;
				}
				_mixingActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("interruptionSources")] 
		public CArray<CName> InterruptionSources
		{
			get
			{
				if (_interruptionSources == null)
				{
					_interruptionSources = (CArray<CName>) CR2WTypeManager.Create("array:CName", "interruptionSources", cr2w, this);
				}
				return _interruptionSources;
			}
			set
			{
				if (_interruptionSources == value)
				{
					return;
				}
				_interruptionSources = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("writeVariableActions")] 
		public CArray<audioAudioSceneVariableWriteActionData> WriteVariableActions
		{
			get
			{
				if (_writeVariableActions == null)
				{
					_writeVariableActions = (CArray<audioAudioSceneVariableWriteActionData>) CR2WTypeManager.Create("array:audioAudioSceneVariableWriteActionData", "writeVariableActions", cr2w, this);
				}
				return _writeVariableActions;
			}
			set
			{
				if (_writeVariableActions == value)
				{
					return;
				}
				_writeVariableActions = value;
				PropertySet(this);
			}
		}

		public audioAudioStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
