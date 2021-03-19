using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _gogButtonWidgetRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CInt32 _savesCount;

		[Ordinal(7)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(8)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetProperty(ref _gogButtonWidgetRef);
			set => SetProperty(ref _gogButtonWidgetRef, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(10)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get => GetProperty(ref _savesCount);
			set => SetProperty(ref _savesCount, value);
		}

		public SingleplayerMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
