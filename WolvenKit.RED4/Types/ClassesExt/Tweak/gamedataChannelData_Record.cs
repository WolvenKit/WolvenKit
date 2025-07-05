
namespace WolvenKit.RED4.Types
{
	public partial class gamedataChannelData_Record
	{
		[RED("audioEvent")]
		[REDProperty(IsIgnored = true)]
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("channelWidget")]
		[REDProperty(IsIgnored = true)]
		public CName ChannelWidget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("dynamicTexturePath")]
		[REDProperty(IsIgnored = true)]
		public CString DynamicTexturePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("orderID")]
		[REDProperty(IsIgnored = true)]
		public CInt32 OrderID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("overlayWidgetPath")]
		[REDProperty(IsIgnored = true)]
		public CString OverlayWidgetPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
