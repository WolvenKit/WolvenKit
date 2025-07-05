using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSendSignalTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("startAction")] 
		public CEnum<gameBoolSignalAction> StartAction
		{
			get => GetPropertyValue<CEnum<gameBoolSignalAction>>();
			set => SetPropertyValue<CEnum<gameBoolSignalAction>>(value);
		}

		[Ordinal(3)] 
		[RED("startActionUserData")] 
		public CHandle<gameSignalUserDataDefinition> StartActionUserData
		{
			get => GetPropertyValue<CHandle<gameSignalUserDataDefinition>>();
			set => SetPropertyValue<CHandle<gameSignalUserDataDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("endAction")] 
		public CEnum<gameBoolSignalAction> EndAction
		{
			get => GetPropertyValue<CEnum<gameBoolSignalAction>>();
			set => SetPropertyValue<CEnum<gameBoolSignalAction>>(value);
		}

		[Ordinal(5)] 
		[RED("endActionUserData")] 
		public CHandle<gameSignalUserDataDefinition> EndActionUserData
		{
			get => GetPropertyValue<CHandle<gameSignalUserDataDefinition>>();
			set => SetPropertyValue<CHandle<gameSignalUserDataDefinition>>(value);
		}

		public AIbehaviorSendSignalTaskDefinition()
		{
			StartAction = Enums.gameBoolSignalAction.TurnOn;
			EndAction = Enums.gameBoolSignalAction.TurnOff;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
