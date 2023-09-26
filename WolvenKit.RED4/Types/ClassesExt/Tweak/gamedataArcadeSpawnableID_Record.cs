
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeSpawnableID_Record
	{
		[RED("id")]
		[REDProperty(IsIgnored = true)]
		public CName Id
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
