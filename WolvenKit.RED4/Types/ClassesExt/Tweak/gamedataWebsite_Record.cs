
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWebsite_Record
	{
		[RED("url")]
		[REDProperty(IsIgnored = true)]
		public CString Url
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("widgetPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> WidgetPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
