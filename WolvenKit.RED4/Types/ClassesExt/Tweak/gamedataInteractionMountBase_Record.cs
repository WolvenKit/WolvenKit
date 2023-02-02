
namespace WolvenKit.RED4.Types
{
	public partial class gamedataInteractionMountBase_Record
	{
		[RED("tag")]
		[REDProperty(IsIgnored = true)]
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vehicleMountSlot")]
		[REDProperty(IsIgnored = true)]
		public CName VehicleMountSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
