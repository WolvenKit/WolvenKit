
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDetectionCurve_Record
	{
		[RED("maxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDistance
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
		
		[RED("states")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> States
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
