using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkButtonController : inkWidgetLogicController
	{
		private inkButtonClickCallback _buttonClick;
		private inkButtonHoldCompleteCallback _buttonHoldComplete;
		private inkButtonStateChangeCallback _buttonStateChanged;
		private inkButtonSelectionCallback _buttonSelectionChanged;
		private inkButtonProgressChangedCallback _buttonHoldProgressChanged;
		private CBool _canHold;
		private CBool _selectable;
		private CBool _selected;
		private CBool _autoUpdateWidgetState;

		[Ordinal(1)] 
		[RED("ButtonClick")] 
		public inkButtonClickCallback ButtonClick
		{
			get => GetProperty(ref _buttonClick);
			set => SetProperty(ref _buttonClick, value);
		}

		[Ordinal(2)] 
		[RED("ButtonHoldComplete")] 
		public inkButtonHoldCompleteCallback ButtonHoldComplete
		{
			get => GetProperty(ref _buttonHoldComplete);
			set => SetProperty(ref _buttonHoldComplete, value);
		}

		[Ordinal(3)] 
		[RED("ButtonStateChanged")] 
		public inkButtonStateChangeCallback ButtonStateChanged
		{
			get => GetProperty(ref _buttonStateChanged);
			set => SetProperty(ref _buttonStateChanged, value);
		}

		[Ordinal(4)] 
		[RED("ButtonSelectionChanged")] 
		public inkButtonSelectionCallback ButtonSelectionChanged
		{
			get => GetProperty(ref _buttonSelectionChanged);
			set => SetProperty(ref _buttonSelectionChanged, value);
		}

		[Ordinal(5)] 
		[RED("ButtonHoldProgressChanged")] 
		public inkButtonProgressChangedCallback ButtonHoldProgressChanged
		{
			get => GetProperty(ref _buttonHoldProgressChanged);
			set => SetProperty(ref _buttonHoldProgressChanged, value);
		}

		[Ordinal(6)] 
		[RED("canHold")] 
		public CBool CanHold
		{
			get => GetProperty(ref _canHold);
			set => SetProperty(ref _canHold, value);
		}

		[Ordinal(7)] 
		[RED("selectable")] 
		public CBool Selectable
		{
			get => GetProperty(ref _selectable);
			set => SetProperty(ref _selectable, value);
		}

		[Ordinal(8)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}

		[Ordinal(9)] 
		[RED("autoUpdateWidgetState")] 
		public CBool AutoUpdateWidgetState
		{
			get => GetProperty(ref _autoUpdateWidgetState);
			set => SetProperty(ref _autoUpdateWidgetState, value);
		}
	}
}
