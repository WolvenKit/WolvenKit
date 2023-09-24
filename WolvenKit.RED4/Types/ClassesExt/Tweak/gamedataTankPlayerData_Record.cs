
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankPlayerData_Record
	{
		[RED("flatlinedScorePenalty")]
		[REDProperty(IsIgnored = true)]
		public CFloat FlatlinedScorePenalty
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("invincibilityTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat InvincibilityTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxAEAMS")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxAEAMS
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxHealth")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxLives")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxLives
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("projectileSpawnerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileSpawnerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("rammingDamage")]
		[REDProperty(IsIgnored = true)]
		public CInt32 RammingDamage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("velocity")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Velocity
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("weaponLevelList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> WeaponLevelList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
