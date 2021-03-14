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

		[Ordinal(113)] 
		[RED("computerSetup")] 
		public ComputerSetup ComputerSetup
		{
			get
			{
				if (_computerSetup == null)
				{
					_computerSetup = (ComputerSetup) CR2WTypeManager.Create("ComputerSetup", "computerSetup", cr2w, this);
				}
				return _computerSetup;
			}
			set
			{
				if (_computerSetup == value)
				{
					return;
				}
				_computerSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("quickHackSetup")] 
		public ComputerQuickHackData QuickHackSetup
		{
			get
			{
				if (_quickHackSetup == null)
				{
					_quickHackSetup = (ComputerQuickHackData) CR2WTypeManager.Create("ComputerQuickHackData", "quickHackSetup", cr2w, this);
				}
				return _quickHackSetup;
			}
			set
			{
				if (_quickHackSetup == value)
				{
					return;
				}
				_quickHackSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("activatorActionSetup")] 
		public CEnum<EToggleActivationTypeComputer> ActivatorActionSetup
		{
			get
			{
				if (_activatorActionSetup == null)
				{
					_activatorActionSetup = (CEnum<EToggleActivationTypeComputer>) CR2WTypeManager.Create("EToggleActivationTypeComputer", "activatorActionSetup", cr2w, this);
				}
				return _activatorActionSetup;
			}
			set
			{
				if (_activatorActionSetup == value)
				{
					return;
				}
				_activatorActionSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("computerSkillChecks")] 
		public CHandle<HackEngContainer> ComputerSkillChecks
		{
			get
			{
				if (_computerSkillChecks == null)
				{
					_computerSkillChecks = (CHandle<HackEngContainer>) CR2WTypeManager.Create("handle:HackEngContainer", "computerSkillChecks", cr2w, this);
				}
				return _computerSkillChecks;
			}
			set
			{
				if (_computerSkillChecks == value)
				{
					return;
				}
				_computerSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("openedMailAdress")] 
		public SDocumentAdress OpenedMailAdress
		{
			get
			{
				if (_openedMailAdress == null)
				{
					_openedMailAdress = (SDocumentAdress) CR2WTypeManager.Create("SDocumentAdress", "openedMailAdress", cr2w, this);
				}
				return _openedMailAdress;
			}
			set
			{
				if (_openedMailAdress == value)
				{
					return;
				}
				_openedMailAdress = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("openedFileAdress")] 
		public SDocumentAdress OpenedFileAdress
		{
			get
			{
				if (_openedFileAdress == null)
				{
					_openedFileAdress = (SDocumentAdress) CR2WTypeManager.Create("SDocumentAdress", "openedFileAdress", cr2w, this);
				}
				return _openedFileAdress;
			}
			set
			{
				if (_openedFileAdress == value)
				{
					return;
				}
				_openedFileAdress = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get
			{
				if (_quickhackPerformed == null)
				{
					_quickhackPerformed = (CBool) CR2WTypeManager.Create("Bool", "quickhackPerformed", cr2w, this);
				}
				return _quickhackPerformed;
			}
			set
			{
				if (_quickhackPerformed == value)
				{
					return;
				}
				_quickhackPerformed = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("isInSleepMode")] 
		public CBool IsInSleepMode
		{
			get
			{
				if (_isInSleepMode == null)
				{
					_isInSleepMode = (CBool) CR2WTypeManager.Create("Bool", "isInSleepMode", cr2w, this);
				}
				return _isInSleepMode;
			}
			set
			{
				if (_isInSleepMode == value)
				{
					return;
				}
				_isInSleepMode = value;
				PropertySet(this);
			}
		}

		public ComputerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
