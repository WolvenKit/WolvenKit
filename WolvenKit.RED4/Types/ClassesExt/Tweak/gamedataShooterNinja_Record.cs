
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterNinja_Record
	{
		[RED("chargeCoolDown")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChargeCoolDown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dashChargeRate")]
		[REDProperty(IsIgnored = true)]
		public CFloat DashChargeRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dashCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DashCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("enragedDashCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 EnragedDashCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("enragedWaveCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 EnragedWaveCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("fireRate")]
		[REDProperty(IsIgnored = true)]
		public CFloat FireRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("waveCoolDown")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaveCoolDown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("waveCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 WaveCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
