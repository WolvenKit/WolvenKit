using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerControllerPS : TerminalControllerPS
	{
		[Ordinal(117)] 
		[RED("computerSetup")] 
		public ComputerSetup ComputerSetup
		{
			get => GetPropertyValue<ComputerSetup>();
			set => SetPropertyValue<ComputerSetup>(value);
		}

		[Ordinal(118)] 
		[RED("quickHackSetup")] 
		public ComputerQuickHackData QuickHackSetup
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		[Ordinal(119)] 
		[RED("activatorActionSetup")] 
		public CEnum<EToggleActivationTypeComputer> ActivatorActionSetup
		{
			get => GetPropertyValue<CEnum<EToggleActivationTypeComputer>>();
			set => SetPropertyValue<CEnum<EToggleActivationTypeComputer>>(value);
		}

		[Ordinal(120)] 
		[RED("computerSkillChecks")] 
		public CHandle<HackEngContainer> ComputerSkillChecks
		{
			get => GetPropertyValue<CHandle<HackEngContainer>>();
			set => SetPropertyValue<CHandle<HackEngContainer>>(value);
		}

		[Ordinal(121)] 
		[RED("openedMailAdress")] 
		public SDocumentAdress OpenedMailAdress
		{
			get => GetPropertyValue<SDocumentAdress>();
			set => SetPropertyValue<SDocumentAdress>(value);
		}

		[Ordinal(122)] 
		[RED("openedFileAdress")] 
		public SDocumentAdress OpenedFileAdress
		{
			get => GetPropertyValue<SDocumentAdress>();
			set => SetPropertyValue<SDocumentAdress>(value);
		}

		[Ordinal(123)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(124)] 
		[RED("isInSleepMode")] 
		public CBool IsInSleepMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(125)] 
		[RED("computerUIpreset")] 
		public CHandle<gamedataComputerStyleUIDefinition_Record> ComputerUIpreset
		{
			get => GetPropertyValue<CHandle<gamedataComputerStyleUIDefinition_Record>>();
			set => SetPropertyValue<CHandle<gamedataComputerStyleUIDefinition_Record>>(value);
		}

		public ComputerControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
