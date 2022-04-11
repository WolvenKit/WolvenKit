using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KeypadDeviceController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] 
		[RED("enteredPasswordWidget")] 
		public CWeakHandle<inkTextWidget> EnteredPasswordWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("passwordStatusWidget")] 
		public CWeakHandle<inkTextWidget> PasswordStatusWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("actionButton")] 
		public CWeakHandle<inkWidget> ActionButton
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("ActionText")] 
		public CWeakHandle<inkTextWidget> ActionText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("passwordsList")] 
		public CArray<CName> PasswordsList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(15)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(16)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("row1")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row1
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("row2")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row2
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("row3")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row3
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("row4")] 
		public CWeakHandle<inkHorizontalPanelWidget> Row4
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		public KeypadDeviceController()
		{
			PasswordsList = new();
		}
	}
}
