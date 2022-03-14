
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAdvertisementFormatDef_Record
	{
		[RED("format")]
		[REDProperty(IsIgnored = true)]
		public CString Format
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("libraryName")]
		[REDProperty(IsIgnored = true)]
		public CString LibraryName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizationKeyOverride")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizationKeyOverride
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
	}
}
