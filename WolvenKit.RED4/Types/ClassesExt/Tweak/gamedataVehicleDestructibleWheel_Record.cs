
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
		
		[RED("hitsToFlatten")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitsToFlatten
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("intact")]
		[REDProperty(IsIgnored = true)]
		public CName Intact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("linkedTire")]
		[REDProperty(IsIgnored = true)]
		public CInt32 LinkedTire
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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
