using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KeyboardHintItemController : AHintItemController
	{
		private inkTextWidgetReference _numberText;
		private inkImageWidgetReference _frame;
		private CName _disabledStateName;
		private CName _selectedStateName;
		private CName _frameSelectedName;
		private CName _frameUnselectedName;
		private CName _animationName;

		[Ordinal(4)] 
		[RED("NumberText")] 
		public inkTextWidgetReference NumberText
		{
			get => GetProperty(ref _numberText);
			set => SetProperty(ref _numberText, value);
		}

		[Ordinal(5)] 
		[RED("Frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(6)] 
		[RED("DisabledStateName")] 
		public CName DisabledStateName
		{
			get => GetProperty(ref _disabledStateName);
			set => SetProperty(ref _disabledStateName, value);
		}

		[Ordinal(7)] 
		[RED("SelectedStateName")] 
		public CName SelectedStateName
		{
			get => GetProperty(ref _selectedStateName);
			set => SetProperty(ref _selectedStateName, value);
		}

		[Ordinal(8)] 
		[RED("FrameSelectedName")] 
		public CName FrameSelectedName
		{
			get => GetProperty(ref _frameSelectedName);
			set => SetProperty(ref _frameSelectedName, value);
		}

		[Ordinal(9)] 
		[RED("FrameUnselectedName")] 
		public CName FrameUnselectedName
		{
			get => GetProperty(ref _frameUnselectedName);
			set => SetProperty(ref _frameUnselectedName, value);
		}

		[Ordinal(10)] 
		[RED("AnimationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}
	}
}
