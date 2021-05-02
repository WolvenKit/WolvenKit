using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseMenuGameController : gameuiMenuItemListGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private ScriptGameInstance _gameInstance;
		private CBool _quickSaveInProgress;

		[Ordinal(6)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(8)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(9)] 
		[RED("quickSaveInProgress")] 
		public CBool QuickSaveInProgress
		{
			get => GetProperty(ref _quickSaveInProgress);
			set => SetProperty(ref _quickSaveInProgress, value);
		}

		public PauseMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
