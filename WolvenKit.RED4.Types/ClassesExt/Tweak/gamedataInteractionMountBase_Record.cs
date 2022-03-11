
namespace WolvenKit.RED4.Types
{
	public partial class gamedataInteractionMountBase_Record
	{
		[RED("vehicleMountSlot")]
		[REDProperty(IsIgnored = true)]
		public CName VehicleMountSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
