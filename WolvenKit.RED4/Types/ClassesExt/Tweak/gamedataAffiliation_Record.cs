
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAffiliation_Record
	{
		[RED("animWrappers")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AnimWrappers
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("iconPath")]
		[REDProperty(IsIgnored = true)]
		public CName IconPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
	}
}
