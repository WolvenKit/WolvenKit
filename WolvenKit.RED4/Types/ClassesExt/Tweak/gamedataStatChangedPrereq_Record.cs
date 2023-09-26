
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatChangedPrereq_Record
	{
		[RED("changeType")]
		[REDProperty(IsIgnored = true)]
		public CName ChangeType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("objectToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statType")]
		[REDProperty(IsIgnored = true)]
		public CName StatType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
