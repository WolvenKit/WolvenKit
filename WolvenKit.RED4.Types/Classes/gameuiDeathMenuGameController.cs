using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDeathMenuGameController : gameuiMenuItemListGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CHandle<inkanimProxy> _animIntro;

		[Ordinal(6)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(8)] 
		[RED("animIntro")] 
		public CHandle<inkanimProxy> AnimIntro
		{
			get => GetProperty(ref _animIntro);
			set => SetProperty(ref _animIntro, value);
		}
	}
}
