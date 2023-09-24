
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterNPCDrone_Record
	{
		[RED("bobbing")]
		[REDProperty(IsIgnored = true)]
		public CFloat Bobbing
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fireRate")]
		[REDProperty(IsIgnored = true)]
		public CFloat FireRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
