using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStepperController : inkWidgetLogicController
	{
		private CBool _cycledNavigation;
		private CName _indicatorUnitLibraryID;
		private inkTextWidgetReference _currentValueDisplay;
		private inkCompoundWidgetReference _indicatorContainer;
		private inkWidgetReference _leftButton;
		private inkWidgetReference _rightButton;
		private inkStepperChangedCallback _change;

		[Ordinal(1)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get => GetProperty(ref _cycledNavigation);
			set => SetProperty(ref _cycledNavigation, value);
		}

		[Ordinal(2)] 
		[RED("indicatorUnitLibraryID")] 
		public CName IndicatorUnitLibraryID
		{
			get => GetProperty(ref _indicatorUnitLibraryID);
			set => SetProperty(ref _indicatorUnitLibraryID, value);
		}

		[Ordinal(3)] 
		[RED("currentValueDisplay")] 
		public inkTextWidgetReference CurrentValueDisplay
		{
			get => GetProperty(ref _currentValueDisplay);
			set => SetProperty(ref _currentValueDisplay, value);
		}

		[Ordinal(4)] 
		[RED("indicatorContainer")] 
		public inkCompoundWidgetReference IndicatorContainer
		{
			get => GetProperty(ref _indicatorContainer);
			set => SetProperty(ref _indicatorContainer, value);
		}

		[Ordinal(5)] 
		[RED("leftButton")] 
		public inkWidgetReference LeftButton
		{
			get => GetProperty(ref _leftButton);
			set => SetProperty(ref _leftButton, value);
		}

		[Ordinal(6)] 
		[RED("rightButton")] 
		public inkWidgetReference RightButton
		{
			get => GetProperty(ref _rightButton);
			set => SetProperty(ref _rightButton, value);
		}

		[Ordinal(7)] 
		[RED("Change")] 
		public inkStepperChangedCallback Change
		{
			get => GetProperty(ref _change);
			set => SetProperty(ref _change, value);
		}

		public inkStepperController()
		{
			_cycledNavigation = true;
		}
	}
}
