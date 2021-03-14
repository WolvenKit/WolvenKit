using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialMainController : gameuiWidgetGameController
	{
		private inkWidgetReference _instructionPanel;
		private inkTextWidgetReference _instructionDesc;
		private inkWidgetReference _pointer;
		private CBool _tutorialActive;
		private TutorialStep _currentTutorialStep;

		[Ordinal(2)] 
		[RED("instructionPanel")] 
		public inkWidgetReference InstructionPanel
		{
			get
			{
				if (_instructionPanel == null)
				{
					_instructionPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "instructionPanel", cr2w, this);
				}
				return _instructionPanel;
			}
			set
			{
				if (_instructionPanel == value)
				{
					return;
				}
				_instructionPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("instructionDesc")] 
		public inkTextWidgetReference InstructionDesc
		{
			get
			{
				if (_instructionDesc == null)
				{
					_instructionDesc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "instructionDesc", cr2w, this);
				}
				return _instructionDesc;
			}
			set
			{
				if (_instructionDesc == value)
				{
					return;
				}
				_instructionDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pointer")] 
		public inkWidgetReference Pointer
		{
			get
			{
				if (_pointer == null)
				{
					_pointer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pointer", cr2w, this);
				}
				return _pointer;
			}
			set
			{
				if (_pointer == value)
				{
					return;
				}
				_pointer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tutorialActive")] 
		public CBool TutorialActive
		{
			get
			{
				if (_tutorialActive == null)
				{
					_tutorialActive = (CBool) CR2WTypeManager.Create("Bool", "tutorialActive", cr2w, this);
				}
				return _tutorialActive;
			}
			set
			{
				if (_tutorialActive == value)
				{
					return;
				}
				_tutorialActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentTutorialStep")] 
		public TutorialStep CurrentTutorialStep
		{
			get
			{
				if (_currentTutorialStep == null)
				{
					_currentTutorialStep = (TutorialStep) CR2WTypeManager.Create("TutorialStep", "currentTutorialStep", cr2w, this);
				}
				return _currentTutorialStep;
			}
			set
			{
				if (_currentTutorialStep == value)
				{
					return;
				}
				_currentTutorialStep = value;
				PropertySet(this);
			}
		}

		public TutorialMainController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
