
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSenseShape_Record
	{
		[RED("detectionMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
