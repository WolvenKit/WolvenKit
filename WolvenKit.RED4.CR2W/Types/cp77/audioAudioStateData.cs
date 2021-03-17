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
			get => GetProperty(ref _stateName);
			set => SetProperty(ref _stateName, value);
		}

		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get => GetProperty(ref _enterEvent);
			set => SetProperty(ref _enterEvent, value);
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get => GetProperty(ref _exitEvent);
			set => SetProperty(ref _exitEvent, value);
		}

		[Ordinal(3)] 
		[RED("exitTransitions")] 
		public CArray<audioAudioStateTransitionData> ExitTransitions
		{
			get => GetProperty(ref _exitTransitions);
			set => SetProperty(ref _exitTransitions, value);
		}

		[Ordinal(4)] 
		[RED("mixingActions")] 
		public CArray<audioMixingActionData> MixingActions
		{
			get => GetProperty(ref _mixingActions);
			set => SetProperty(ref _mixingActions, value);
		}

		[Ordinal(5)] 
		[RED("interruptionSources")] 
		public CArray<CName> InterruptionSources
		{
			get => GetProperty(ref _interruptionSources);
			set => SetProperty(ref _interruptionSources, value);
		}

		[Ordinal(6)] 
		[RED("writeVariableActions")] 
		public CArray<audioAudioSceneVariableWriteActionData> WriteVariableActions
		{
			get => GetProperty(ref _writeVariableActions);
			set => SetProperty(ref _writeVariableActions, value);
		}

		public audioAudioStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
