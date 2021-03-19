using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeypadDeviceController : DeviceWidgetControllerBase
	{
		private wCHandle<inkTextWidget> _enteredPasswordWidget;
		private wCHandle<inkTextWidget> _passwordStatusWidget;
		private wCHandle<inkWidget> _actionButton;
		private wCHandle<inkTextWidget> _actionText;
		private CArray<CName> _passwordsList;
		private CString _cardName;
		private CBool _isPasswordKnown;
		private wCHandle<inkHorizontalPanelWidget> _row1;
		private wCHandle<inkHorizontalPanelWidget> _row2;
		private wCHandle<inkHorizontalPanelWidget> _row3;
		private wCHandle<inkHorizontalPanelWidget> _row4;

		[Ordinal(10)] 
		[RED("enteredPasswordWidget")] 
		public wCHandle<inkTextWidget> EnteredPasswordWidget
		{
			get => GetProperty(ref _enteredPasswordWidget);
			set => SetProperty(ref _enteredPasswordWidget, value);
		}

		[Ordinal(11)] 
		[RED("passwordStatusWidget")] 
		public wCHandle<inkTextWidget> PasswordStatusWidget
		{
			get => GetProperty(ref _passwordStatusWidget);
			set => SetProperty(ref _passwordStatusWidget, value);
		}

		[Ordinal(12)] 
		[RED("actionButton")] 
		public wCHandle<inkWidget> ActionButton
		{
			get => GetProperty(ref _actionButton);
			set => SetProperty(ref _actionButton, value);
		}

		[Ordinal(13)] 
		[RED("ActionText")] 
		public wCHandle<inkTextWidget> ActionText
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
		public wCHandle<inkHorizontalPanelWidget> Row1
		{
			get => GetProperty(ref _row1);
			set => SetProperty(ref _row1, value);
		}

		[Ordinal(18)] 
		[RED("row2")] 
		public wCHandle<inkHorizontalPanelWidget> Row2
		{
			get => GetProperty(ref _row2);
			set => SetProperty(ref _row2, value);
		}

		[Ordinal(19)] 
		[RED("row3")] 
		public wCHandle<inkHorizontalPanelWidget> Row3
		{
			get => GetProperty(ref _row3);
			set => SetProperty(ref _row3, value);
		}

		[Ordinal(20)] 
		[RED("row4")] 
		public wCHandle<inkHorizontalPanelWidget> Row4
		{
			get => GetProperty(ref _row4);
			set => SetProperty(ref _row4, value);
		}

		public KeypadDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
