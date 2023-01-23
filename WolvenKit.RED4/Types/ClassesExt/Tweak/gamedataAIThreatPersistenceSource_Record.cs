
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIThreatPersistenceSource_Record
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
		
		[RED("enumValue")]
		[REDProperty(IsIgnored = true)]
		public CInt32 EnumValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
