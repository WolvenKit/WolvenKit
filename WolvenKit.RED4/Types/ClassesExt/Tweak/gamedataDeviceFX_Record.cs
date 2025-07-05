
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDeviceFX_Record
	{
		[RED("idleEffectLength")]
		[REDProperty(IsIgnored = true)]
		public CFloat IdleEffectLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("scanGameEffectLength")]
		[REDProperty(IsIgnored = true)]
		public CFloat ScanGameEffectLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("visionConeEffectLength")]
		[REDProperty(IsIgnored = true)]
		public CFloat VisionConeEffectLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
