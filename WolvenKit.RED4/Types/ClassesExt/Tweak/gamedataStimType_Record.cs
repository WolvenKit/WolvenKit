
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStimType_Record
	{
		[RED("comment")]
		[REDProperty(IsIgnored = true)]
		public CString Comment
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
	}
}
