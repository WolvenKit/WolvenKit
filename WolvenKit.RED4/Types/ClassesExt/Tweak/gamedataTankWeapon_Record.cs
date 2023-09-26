
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankWeapon_Record
	{
		[RED("chargingTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChargingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("perBurstProjectileCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PerBurstProjectileCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("perBurstProjectileSpawnInterval")]
		[REDProperty(IsIgnored = true)]
		public CFloat PerBurstProjectileSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("projectileID")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("rof")]
		[REDProperty(IsIgnored = true)]
		public CFloat Rof
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotation")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector2> Rotation
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}
	}
}
