
namespace WolvenKit.RED4.Types
{
	public partial class gamedataQuery_Record
	{
		[RED("recordType")]
		[REDProperty(IsIgnored = true)]
		public CName RecordType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
