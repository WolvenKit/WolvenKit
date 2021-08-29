using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ButtonHintListItem : inkWidgetLogicController
	{
		private inkWidgetReference _inputDisplay;
		private inkTextWidgetReference _label;
		private CWeakHandle<inkInputDisplayController> _buttonHint;
		private CName _actionName;

		[Ordinal(1)] 
		[RED("inputDisplay")] 
		public inkWidgetReference InputDisplay
		{
			get => GetProperty(ref _inputDisplay);
			set => SetProperty(ref _inputDisplay, value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("buttonHint")] 
		public CWeakHandle<inkInputDisplayController> ButtonHint
		{
			get => GetProperty(ref _buttonHint);
			set => SetProperty(ref _buttonHint, value);
		}

		[Ordinal(4)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}
	}
}
