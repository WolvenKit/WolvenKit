
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankPickup_Record
	{
		[RED("pickupLocKey")]
		[REDProperty(IsIgnored = true)]
		public CName PickupLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
