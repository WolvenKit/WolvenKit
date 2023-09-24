
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDifficulty_Record
	{
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
