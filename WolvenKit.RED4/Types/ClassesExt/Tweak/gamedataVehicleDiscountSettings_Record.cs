
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDiscountSettings_Record
	{
		[RED("discountFact")]
		[REDProperty(IsIgnored = true)]
		public CName DiscountFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("discountValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> DiscountValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
	}
}
