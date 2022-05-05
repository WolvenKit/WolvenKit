
namespace WolvenKit.RED4.Types
{
	public partial class gamedataConsumableBaseName_Record
	{
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CName EnumComment
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
