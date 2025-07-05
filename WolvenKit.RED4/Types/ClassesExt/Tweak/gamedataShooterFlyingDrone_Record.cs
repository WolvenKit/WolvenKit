
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterFlyingDrone_Record
	{
		[RED("bobbing")]
		[REDProperty(IsIgnored = true)]
		public CFloat Bobbing
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionRange
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
