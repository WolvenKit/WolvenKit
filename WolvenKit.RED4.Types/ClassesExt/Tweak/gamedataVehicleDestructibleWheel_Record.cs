
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDestructibleWheel_Record
	{
		[RED("flat")]
		[REDProperty(IsIgnored = true)]
		public CName Flat
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("intact")]
		[REDProperty(IsIgnored = true)]
		public CName Intact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
