
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVisionGroup_Record
	{
		[RED("groupName")]
		[REDProperty(IsIgnored = true)]
		public CName GroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
