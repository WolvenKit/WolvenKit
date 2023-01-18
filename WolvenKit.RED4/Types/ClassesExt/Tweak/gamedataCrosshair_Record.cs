
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCrosshair_Record
	{
		[RED("widgetResourcePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> WidgetResourcePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
