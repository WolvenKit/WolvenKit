using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerControllerPS : TerminalControllerPS
	{
		private ComputerSetup _computerSetup;
		private ComputerQuickHackData _quickHackSetup;
		private CEnum<EToggleActivationTypeComputer> _activatorActionSetup;
		private CHandle<HackEngContainer> _computerSkillChecks;
		private SDocumentAdress _openedMailAdress;
		private SDocumentAdress _openedFileAdress;
		private CBool _quickhackPerformed;
		private CBool _isInSleepMode;

		[Ordinal(114)] 
		[RED("computerSetup")] 
		public ComputerSetup ComputerSetup
		{
			get => GetProperty(ref _computerSetup);
			set => SetProperty(ref _computerSetup, value);
		}

		[Ordinal(115)] 
		[RED("quickHackSetup")] 
		public ComputerQuickHackData QuickHackSetup
		{
			get => GetProperty(ref _quickHackSetup);
			set => SetProperty(ref _quickHackSetup, value);
		}

		[Ordinal(116)] 
		[RED("activatorActionSetup")] 
		public CEnum<EToggleActivationTypeComputer> ActivatorActionSetup
		{
			get => GetProperty(ref _activatorActionSetup);
			set => SetProperty(ref _activatorActionSetup, value);
		}

		[Ordinal(117)] 
		[RED("computerSkillChecks")] 
		public CHandle<HackEngContainer> ComputerSkillChecks
		{
			get => GetProperty(ref _computerSkillChecks);
			set => SetProperty(ref _computerSkillChecks, value);
		}

		[Ordinal(118)] 
		[RED("openedMailAdress")] 
		public SDocumentAdress OpenedMailAdress
		{
			get => GetProperty(ref _openedMailAdress);
			set => SetProperty(ref _openedMailAdress, value);
		}

		[Ordinal(119)] 
		[RED("openedFileAdress")] 
		public SDocumentAdress OpenedFileAdress
		{
			get => GetProperty(ref _openedFileAdress);
			set => SetProperty(ref _openedFileAdress, value);
		}

		[Ordinal(120)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get => GetProperty(ref _quickhackPerformed);
			set => SetProperty(ref _quickhackPerformed, value);
		}

		[Ordinal(121)] 
		[RED("isInSleepMode")] 
		public CBool IsInSleepMode
		{
			get => GetProperty(ref _isInSleepMode);
			set => SetProperty(ref _isInSleepMode, value);
		}

		public ComputerControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
