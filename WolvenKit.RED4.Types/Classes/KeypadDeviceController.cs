using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KeypadDeviceController : DeviceWidgetControllerBase
	{
		private CWeakHandle<inkTextWidget> _enteredPasswordWidget;
		private CWeakHandle<inkTextWidget> _passwordStatusWidget;
		private CWeakHandle<inkWidget> _actionButton;
		private CWeakHandle<inkTextWidget> _actionText;
		private CArray<CName> _passwordsList;
		private CString _cardName;
		private CBool _isPasswordKnown;
		private CWeakHandle<inkHorizontalPanelWidget> _row1;
		private CWeakHandle<inkHorizontalPanelWidget> _row2;
		private CWeakHandle<inkHorizontalPanelWidget> _row3;
		private CWeakHandle<inkHorizontalPanelWidget> _row4;

		[Ordinal(10)] 
		[RED("enteredPasswordWidget")] 
		public CWeakHandle<inkTextWidget> EnteredPasswordWidget
		{
			get => GetProperty(ref _enteredPasswordWidget);
			set => SetProperty(ref _enteredPasswordWidget, value);
		}

		[Ordinal(11)] 
		[RED("passwordStatusWidget")] 
		public CWeakHandle<inkTextWidget> PasswordStatusWidget
		{
			get => GetProperty(ref _passwordStatusWidget);
			set => SetProperty(ref _passwordStatusWidget, value);
		}

		[Ordinal(12)] 
		[RED("actionButton")] 
		public CWeakHandle<inkWidget> ActionButton
		{
			get => GetProperty(ref _actionButton);
			set => SetProperty(ref _actionButton, value);
		}

		[Ordinal(13)] 
		[RED("ActionText")] 
		public CWeakHandle<inkTextWidget> ActionText
		{
			get => GetProperty(ref _actionText);
			set => SetProperty(ref _actionText, value);
		}

		[Ordinal(14)] 
		[RED("passwordsList")] 
		public CArray<CName> PasswordsList
		{
			get => GetProperty(ref _passwordsList);
			set => SetProperty(ref _passwordsList, value);
		}

		[Ordinal(15)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetProperty(ref _cardName);
			set => SetProperty(ref _cardName, value);
		}

		[Ordinal(16)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get => GetProperty(ref _isPasswordKnown);
			set => SetProperty(ref _isPasswordKnown, value);
		}

		[Ordinal(17)] 
		[RED("row1")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row1
		{
			get => GetProperty(ref _row1);
			set => SetProperty(ref _row1, value);
		}

		[Ordinal(18)] 
		[RED("row2")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row2
		{
			get => GetProperty(ref _row2);
			set => SetProperty(ref _row2, value);
		}

		[Ordinal(19)] 
		[RED("row3")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row3
		{
			get => GetProperty(ref _row3);
			set => SetProperty(ref _row3, value);
		}

		[Ordinal(20)] 
		[RED("row4")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row4
		{
			get => GetProperty(ref _row4);
			set => SetProperty(ref _row4, value);
		}
	}
}
