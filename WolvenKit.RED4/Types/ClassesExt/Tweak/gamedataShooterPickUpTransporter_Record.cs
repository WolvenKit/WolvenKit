
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterPickUpTransporter_Record
	{
		[RED("pickUpTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PickUpTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
