
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterBossAI_Record
	{
		[RED("healthThreshold")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HealthThreshold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("idleDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat IdleDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
