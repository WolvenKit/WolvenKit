using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TutorialMainController : gameuiWidgetGameController
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
			get => GetProperty(ref _instructionPanel);
			set => SetProperty(ref _instructionPanel, value);
		}

		[Ordinal(3)] 
		[RED("instructionDesc")] 
		public inkTextWidgetReference InstructionDesc
		{
			get => GetProperty(ref _instructionDesc);
			set => SetProperty(ref _instructionDesc, value);
		}

		[Ordinal(4)] 
		[RED("pointer")] 
		public inkWidgetReference Pointer
		{
			get => GetProperty(ref _pointer);
			set => SetProperty(ref _pointer, value);
		}

		[Ordinal(5)] 
		[RED("tutorialActive")] 
		public CBool TutorialActive
		{
			get => GetProperty(ref _tutorialActive);
			set => SetProperty(ref _tutorialActive, value);
		}

		[Ordinal(6)] 
		[RED("currentTutorialStep")] 
		public TutorialStep CurrentTutorialStep
		{
			get => GetProperty(ref _currentTutorialStep);
			set => SetProperty(ref _currentTutorialStep, value);
		}
	}
}
