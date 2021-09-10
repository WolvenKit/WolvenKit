using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ImageButtonCustomData : WidgetCustomData
	{
		[Ordinal(0)] 
		[RED("imageAtlasImageID")] 
		public CName ImageAtlasImageID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("additionalText")] 
		public CString AdditionalText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
