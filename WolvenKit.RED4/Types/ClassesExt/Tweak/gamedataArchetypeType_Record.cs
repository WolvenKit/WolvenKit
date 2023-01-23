
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArchetypeType_Record
	{
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
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CName LocalizedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
