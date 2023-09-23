using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TutorialMainController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("instructionPanel")] 
		public inkWidgetReference InstructionPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("instructionDesc")] 
		public inkTextWidgetReference InstructionDesc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("pointer")] 
		public inkWidgetReference Pointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("tutorialActive")] 
		public CBool TutorialActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("currentTutorialStep")] 
		public TutorialStep CurrentTutorialStep
		{
			get => GetPropertyValue<TutorialStep>();
			set => SetPropertyValue<TutorialStep>(value);
		}

		public TutorialMainController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
