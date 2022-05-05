using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioStateData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stateName")] 
		public CName StateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("exitTransitions")] 
		public CArray<audioAudioStateTransitionData> ExitTransitions
		{
			get => GetPropertyValue<CArray<audioAudioStateTransitionData>>();
			set => SetPropertyValue<CArray<audioAudioStateTransitionData>>(value);
		}

		[Ordinal(4)] 
		[RED("mixingActions")] 
		public CArray<audioMixingActionData> MixingActions
		{
			get => GetPropertyValue<CArray<audioMixingActionData>>();
			set => SetPropertyValue<CArray<audioMixingActionData>>(value);
		}

		[Ordinal(5)] 
		[RED("interruptionSources")] 
		public CArray<CName> InterruptionSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("writeVariableActions")] 
		public CArray<audioAudioSceneVariableWriteActionData> WriteVariableActions
		{
			get => GetPropertyValue<CArray<audioAudioSceneVariableWriteActionData>>();
			set => SetPropertyValue<CArray<audioAudioSceneVariableWriteActionData>>(value);
		}

		public audioAudioStateData()
		{
			ExitTransitions = new();
			MixingActions = new();
			InterruptionSources = new();
			WriteVariableActions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
